using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CCalendar
    {
        public DateTime JourDispo { get; set; }
        public virtual CDish Dish { get; set; }
    }
}