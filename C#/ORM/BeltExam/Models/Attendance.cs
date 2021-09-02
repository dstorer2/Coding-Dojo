using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;

namespace BeltExam
{
    public class Attendance
    {
        public int AttendanceId {get; set; }
        public int GatheringId {get; set; }
        public Gathering Gathering {get; set; }
        public int UserId {get; set; }
        public User User {get; set; }
    }
}