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
        public string CategoryName { get; set; }
        public Category Category { get; set; }  // Nav. Each Product has one Category

        public int BrandID { get; set; }
        public Brand Brand { get; set; }   // Nav. Each Product has one Brand
    }
}