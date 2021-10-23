using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public double Amount { get; set; }
         public int Type { get; set; } //1 for deposite , 2 for withdraw  

         public DateTime TransactionDate { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

    }
}
