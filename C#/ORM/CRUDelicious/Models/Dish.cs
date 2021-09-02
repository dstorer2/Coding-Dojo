using System;
using System.ComponentModel.DataAnnotations;
namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set; }
        [Required]
        public string Name {get; set; }
        [Required]
        public string Chef {get; set; }
        [Required]
        [Range(1, 5)]
        // between 1-5
        public int Tastiness {get; set; }
        [Required]
        [Range(1, 10000)]
        // at least 1
        public int Calories {get; set; }
        [Required]
        [MinLength(5)]
        public string Description {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
    }
}