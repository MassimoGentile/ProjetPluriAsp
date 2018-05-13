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
        /*protected CUser(string passwordInit, string emailInit, string firstNameInit, string lastNameInit, string adressInit, int bankAccountInit)
        {
            Password = passwordInit;
            Email = emailInit;
            FirstName = firstNameInit;
            LastName = lastNameInit;
            Adress = adressInit;
            BankAccount = bankAccountInit;
        }*/
    }
}