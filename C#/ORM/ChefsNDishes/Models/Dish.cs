using System;
using System.ComponentModel.DataAnnotations;
namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get; set; }
        [Required]
        public string Name {get; set; }
        [Required]
        [Range(1, 5)]
        public int Tastiness {get; set; }
        [Required]
        [Range(1, 10000)]
        public int Calories {get; set; }
        [Required]
        [MinLength(5)]
        public string Description {get; set; }
        [Required]
        public int ChefId {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public Chef Creator {get; set; }
    }
}