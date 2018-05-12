using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CAdmin : CUser
    {
        private static CAdmin _instance = null;
        private bool admin = false;
        public static CAdmin Instance()
        {
            if (_instance == null)
                _instance = new CAdmin("BestAdminPassword", "Carl@gmail.be", "Carl", "Maurice", "Rue des mort vivant 42 PaysMort", 244526, true);
            return _instance;
        }
        private CAdmin(string passwordInit, string emailInit, string firstNameInit, string lastNameInit, string adressInit, int bankAccountInit, bool adminInit)
            : base(passwordInit, emailInit, firstNameInit, lastNameInit, adressInit, bankAccountInit)
        {
            admin = adminInit;
            Console.WriteLine("Admin successfully added !");
        }
    }
}