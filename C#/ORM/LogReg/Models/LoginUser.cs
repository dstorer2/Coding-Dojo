using System;
using System.ComponentModel.DataAnnotations;
namespace LogReg.Models
{
    public class LoginUser
    {
        [Required]
        [EmailAddress]
        public string LoginEmail {get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword {get; set; }
    }
}