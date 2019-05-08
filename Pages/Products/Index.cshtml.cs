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

        public IndexModel(FInalProjectHomekit.Models.HomekitDbContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 5;

        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        public SelectList SortList {get; set;}
        public string CategoryName {get; set;}

        public async Task OnGetAsync()
        {
            var products = _context.Product.Include(r => r.Brand).Include(r => r.Category).Select(r => r);

            var query = _context.Product.Select(r => r);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem { Text = "Product Name Ascending", Value = "PN_asc" },
                new SelectListItem { Text = "Product Name Descending", Value = "PN_desc" },
                new SelectListItem { Text = "Category Name Ascending", Value = "CN_asc" },
                new SelectListItem { Text = "Category Name Descending", Value = "CN_desc" },
                new SelectListItem { Text = "Price Ascending", Value = "Price_asc" },
                new SelectListItem { Text = "Price Descending", Value = "Price_desc" }
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                case "PN_asc":
                    query = query.OrderBy(r => r.ProductName);
                    break;
                case "PN_desc":
                    query = query.OrderByDescending(r => r.ProductName);
                    break;
                case "CN_asc":
                    query = query.OrderBy(r => r.CategoryName);
                    break;
                case "CN_desc":
                    query = query.OrderByDescending(r => r.CategoryName);
                    break;
                case "Price_asc":
                    query = query.OrderBy(r => r.ProductPrice);
                    break;
                case "Price_desc":
                    query = query.OrderByDescending(r => r.ProductPrice);
                    break;
            }
            Product = await products.ToListAsync();

            Product = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}