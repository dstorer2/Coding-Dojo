using System.ComponentModel.DataAnnotations;

namespace SimpLoginReg
{
    public class Register
    {
        [Required]
        [MinLength(2)]
        public string FirstName {get; set; }
        [Required]
        [MinLength(2)]
        public string LastName {get; set; }
        [Required]
        [EmailAddress]
        public string Email {get; set; }
        [Required]
        [MinLength(8)]
        public string Password {get; set; }
        [Required]
        [Compare("Password", ErrorMessage ="Password and Confirmation do not match ")]
        public string ConfPass {get; set; }
    }
}