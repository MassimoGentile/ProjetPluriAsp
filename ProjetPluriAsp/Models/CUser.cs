using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CUser
    {
        private string Password { get; set; }
        public string Email { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Adress { get; private set; }
        private int BankAccount { get; set; }
        protected CUser(string passwordInit, string emailInit, string firstNameInit, string lastNameInit, string adressInit, int bankAccountInit)
        {
            Password = passwordInit;
            Email = emailInit;
            FirstName = firstNameInit;
            LastName = lastNameInit;
            Adress = adressInit;
            BankAccount = bankAccountInit;
        }
    }
}