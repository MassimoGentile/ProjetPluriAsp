using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public abstract class CUser
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
        public int BankAccount { get; set; }
    }
}