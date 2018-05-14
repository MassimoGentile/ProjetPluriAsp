using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CTheme
    {
        public int Id { get; set; }
        public bool AllreadyChoose { get; set; }
        public bool ChoosenTheme { get; set; }
        public string Name { get; set; }
    }
}