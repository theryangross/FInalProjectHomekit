using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FInalProjectHomekit.Models;

namespace FInalProjectHomekit.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly FInalProjectHomekit.Models.HomekitDbContext _context;

        public CreateModel(FInalProjectHomekit.Models.HomekitDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["BrandID"] = new SelectList(_context.Brand, "BrandID", "BrandID");
        ViewData["CategoryID"] = new SelectList(_context.Category, "CategoryID", "CategoryID");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Product.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}