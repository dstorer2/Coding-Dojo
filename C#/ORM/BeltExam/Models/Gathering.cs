using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using BeltExam.Models;

namespace BeltExam.Models
{
    public class Gathering
    {
        [Key]
        public int GatheringId {get; set; }
        [Required]
        [Display(Name = "Title:")]
        public string Title {get; set; }
        [Required]
        [Display(Name = "Description:")]
        public string Description {get; set; }
        [Required]
        [DataType("Date")]
        [Display(Name = "Date:")]
        public DateTime Date {get; set; }
        [Required]
        [DataType("Time")]
        [Display(Name = "Time:")]
        public DateTime Time {get; set; }
        [Required]
        [Display(Name = "Duration:")]
        public int Duration {get; set; }
        [Required]
        public string DurationUnit {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public List<Attendance> Attendees {get; set; }
        public int UserId {get; set; }
        public User Creator {get; set; }
    }
}