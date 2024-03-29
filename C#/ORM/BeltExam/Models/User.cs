using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using BeltExam.Models;

namespace BeltExam.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "First Name:")]
        public string FirstName {get; set; }
        [Required]
        [MinLength(2)]
        [Display(Name = "Last Name:")]
        public string LastName {get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email:")]
        public string Email {get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="Password must be at least 8 characters")]
        [Display(Name = "Password:")]
        public string Password {get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [Display(Name = "Confirm Password:")]
        [NotMapped]
        public string Confirm {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public List<Attendance> Attending {get; set; }
        public List<Gathering> CreatedGatherings {get; set; }
    }
}