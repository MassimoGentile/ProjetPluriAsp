using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CCalendar
    {
        [Key]
        public int Id { get; set; }
        public DateTime JourDispo { get; set; }
        public virtual CDish Dish { get; set; }
    }
}