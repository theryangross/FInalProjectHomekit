using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace FInalProjectHomekit.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        
        [Display(Name="Product Name")]
        public string ProductName { get; set; }

        [Display (Name = "Price")]
        public string ProductPrice { get; set; }
        
        public int CategoryID { get; set; }   // FK
        public List<Category> Categories { get; set; }  // Nav. Each Product has one Category

        public int BrandID { get; set; }
        public List<Brand> Brands { get; set; }   // Nav. Each Product has one Brand
    }
}