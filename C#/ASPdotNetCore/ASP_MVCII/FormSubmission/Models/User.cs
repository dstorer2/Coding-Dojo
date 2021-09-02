using System.ComponentModel.DataAnnotations;

namespace FormSubmission
{
    public class User
    {
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name")]
        public string? FirstName {get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name")]
        public string? LastName {get; set; }
        [Required]
        [MinLength(2)]
        public int? Age {get; set; }
        [Required]
        [EmailAddress]
        public string? Email {get; set; }
        [Required]
        [MinLength(2)]
        public string? Password {get; set; }
    }
}
