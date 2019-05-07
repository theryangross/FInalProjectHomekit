using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FInalProjectHomekit.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace FInalProjectHomekit.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly FInalProjectHomekit.Models.HomekitDbContext _context;
        private readonly ILogger _logger;

        public IndexModel(FInalProjectHomekit.Models.HomekitDbContext context, ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Product> Product { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Categories { get; set; }
        public SelectList SortList {get; set;}
        [BindProperty(SupportsGet = true)]
        public string ProductCategory { get; set; }

        // PageSize: How many records to display per page.
        // Default: 10
        public int PageSize {get; set;} = 10;

        // PageNum: Current Page Number we are on. Default is 1
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;

        public int TotalCount {get; set;} // Total number of records
        public int TotalPages {get; set;} // Total number of pages
        
        // String to keep track of our current sort order. Needed for 
        // paging to remember current sort
        public string CurrentSort {get; set;} 
        
        // Next Sort for ProductName and BrandName sort. This alternates between asc/desc
        public string ProductNameSort {get; set;} = "ProductName_asc";
        public string PriceSort {get; set;} = "Price_asc";

        public async Task OnGetAsync(string sortOrder)
        {
            CurrentSort = sortOrder;

            // Sorting Technique 2. Create a SelectList of sort options.
            // Set the values equal to our expected sort strings
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem {Text = "Product Name A - Z", Value = "ProductName_asc"},
                new SelectListItem("Product Name Z - A", "ProductName_desc"),
                new SelectListItem("Price Low - High", "Price_asc"),
                new SelectListItem("Price High - Loq", "Price_desc")
            };
            // Default value will be CurrentSort
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);
            
            // Use LINQ to get list of categories.
            IQueryable<string> categoryQuery = from m in _context.Product
                                            orderby m.CategoryName
                                            select m.CategoryName;

            //var movies = from m in _context.Movie
            //            select m;
            // var movies = _context.Movie.Include(m => m.Reviews).Select(m => new {
            //     ID = m.ID,
            //     Title = m.Title,
            //     ReleaseDate = m.ReleaseDate,
            //     Genre = m.Genre,
            //     Price = m.Price,
            //     Rating = m.Rating,
            //     Review = m.Reviews.Average(r => r.Score)            
            // });
            // IQueryable<Movie> movies = _context.Movie.Include(m => m.Reviews);
            // var movies = (from m in _context.Movie
            //     select m).Include("Reviews");
            
            // Use .Include() to bring in the reviews
            var products = _context.Product.Select(m => m);
            
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.ProductName.Contains(SearchString));
            }
            
            if (!string.IsNullOrEmpty(ProductCategory))
            {
                products = products.Where(x => x.CategoryName == ProductCategory);
            }

            // Calculate total number of records and how many pages that takes
            TotalCount = products.Count();
            TotalPages = (int)Math.Ceiling(TotalCount / (double)PageSize);

            Categories = new SelectList(await categoryQuery.Distinct().ToListAsync());

            // Do the sorting. This is the brains of sorting
            // Switch on sort Order and perform proper LINQ query
            switch (sortOrder) 
            {
                case "ProductName_desc":
                    _logger.LogInformation("Sorting by Title descending");
                    products = products.OrderByDescending(m => m.ProductName);
                    ProductNameSort = "title_asc";
                    break;
                case "ProductName_asc":
                    _logger.LogInformation("Sorting by Title ascending");
                    products = products.OrderBy(m => m.ProductName);
                    ProductNameSort = "title_desc";
                    break;
                case "date_desc":
                    _logger.LogInformation("Sorting by Release Date descending");
                    products = products.OrderByDescending(m => m.ProductPrice);
                    PriceSort = "date_asc";
                    break;
                case "date_asc":
                    _logger.LogInformation("Sorting by Release Date ascending");
                    products = products.OrderBy(m => m.ProductPrice);
                    PriceSort = "date_desc";
                    break;
                default:
                    _logger.LogInformation("No Sorting");
                    break;
            }

            // Pick the movies for paging. Skip() to current page and then Take the right
            // number of movies
            Product = await products.Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync();
        }
    }
}
