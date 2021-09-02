using System.ComponentModel.DataAnnotations;

namespace Test
{
    public class User
    {
        [Required]
        public string Username {get; set; }
        [Required]
        public int Age {get; set; }

    }
}