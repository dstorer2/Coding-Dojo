using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransId {get; set; }
        [Required]
        public int Amount {get; set; }
        [Required]
        public int AcctId {get; set; }
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        public Account AccountOf {get; set; }
    }
}