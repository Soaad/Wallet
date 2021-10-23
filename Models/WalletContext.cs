using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wallet.Models;

namespace Wallet.Models
{
    public class WalletContext:DbContext
    {
        public DbSet<User> users { get; set; }
        //public DbSet<BankAccount> bankAccounts { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Transaction> transactions;
        public WalletContext(DbContextOptions<WalletContext> options):base(options)
        {

        }
        public DbSet<Wallet.Models.Transaction> Transaction { get; set; }

         
    }
}
