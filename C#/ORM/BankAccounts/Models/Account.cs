using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts.Models
{
    public class Account
    {
        [Key]
        public int AcctId {get; set; }
        [Required]
        [MinLength(5)]
        public string Name {get; set; }
        public int Balance {get; set; } = 0;
        public DateTime CreatedAt {get; set; } = DateTime.Now;
        public DateTime UpdatedAt {get; set; } = DateTime.Now;
        [Required]
        public int UserId {get; set; }
        public User Owner {get; set; }
        public List<Transaction> CompletedTransactions {get; set; }
    }
}