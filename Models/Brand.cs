using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace FInalProjectHomekit.Models
{
    public class Brand
    {
        public int BrandID { get; set; }    // PK
        
        [Required]
        [Display(Name="Brand")]
        public string BrandName { get; set; }
        
        public int ProductID { get; set; }  // FK
        
        public List<Product> Products { get; set; }   // Nav. Each Brand can have one or many Products
    }
}