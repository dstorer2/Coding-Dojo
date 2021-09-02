using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using WeddingPlanner.Models;

namespace WeddingPlanner
{
    public class Wedding
    {
        [Key]
        public int WeddingId {get; set; }
        [Required]
        [MinLength(2)]
        public string Wedder1 {get; set; }
        [Required]
        [MinLength(2)]
        public string Wedder2 {get; set; }
        [Required]
        public DateTime Date {get; set; }
        [Required]
        public string Address {get; set; }
        [Required]
        public int UserId {get; set; }
        public User Creator {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public List<Attendance> Attendees {get; set; }
    }
}