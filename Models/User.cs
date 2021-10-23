using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Password { get; set; }

        [ForeignKey("Role")]
        public int roleId { get; set; }
     

       public List<Transaction> transactions { set; get; }
       // public BankAccount BankAccount{ get; set; }
    }
}
