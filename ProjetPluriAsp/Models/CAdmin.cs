using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CAdmin : CUser
    {
        public static CAdmin _instance { get; set; }
        public bool admin { get; set; }
    }
}