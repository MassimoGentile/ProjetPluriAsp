using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CAdmin : CUser
    {
        public bool admin { get; set; }
    }
}