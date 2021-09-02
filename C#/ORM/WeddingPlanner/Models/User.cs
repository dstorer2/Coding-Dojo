using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using WeddingPlanner.Models;

namespace WeddingPlanner.Models
{
    public class User
    {
        [Key]
        public int UserId {get; set; }
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
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage ="Password must be at least 8 characters")]
        public string Password {get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        [NotMapped]
        public string Confirm {get; set; }
        public List<Wedding> CreatedWeddings {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public List<Attendance> RSVPs {get; set; }
    }
}