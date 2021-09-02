using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner
{
    public class Attendance
    {
        public int AttendanceId {get; set; }
        public int WeddingId {get; set; }
        public Wedding Wedding {get; set; }
        public int UserId {get; set; }
        public User User {get; set; }
    }
}