using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class Dal
    {
        private BddContext bdd;
        public Dal()
        {
            bdd = new BddContext();
        }
    }
}