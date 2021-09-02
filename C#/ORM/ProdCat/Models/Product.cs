using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProdCat
{
    public class Product
    {
        [Key]
        public int ProductId {get; set; }
        [Required]
        [MinLength(2)]
        public string Name {get; set; }
        [Required]
        public string Description {get; set; }
        [Required]
        [Range(0.01, 10000.00)]
        public double Price {get; set; }
        public List<Association> AllCategories {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;

    }
}