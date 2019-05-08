using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace FInalProjectHomekit.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        
        [Required]
        public string ProductName { get; set; }


        [Range(1, 5000)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ProductPrice { get; set; }
        
        public int CategoryID { get; set; }   // FK
        //public string CategoryName { get; set; }

        public Category Category { get; set; }  // Nav. Each Product has one Category

        public int BrandID { get; set; }

        public Brand Brand { get; set; }   // Nav. Each Product has one Brand
    }
}