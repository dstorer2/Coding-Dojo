using System.ComponentModel.DataAnnotations;

namespace Test
{
    public class Product
    {
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName{get; set; }
        [Required]
        public double Price {get; set; }

    }
}