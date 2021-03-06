using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FInalProjectHomekit.Models;

namespace FInalProjectHomekit.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly FInalProjectHomekit.Models.HomekitDbContext _context;

        public DetailsModel(FInalProjectHomekit.Models.HomekitDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Brand)
                .Include(p => p.Category).FirstOrDefaultAsync(m => m.ProductID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
