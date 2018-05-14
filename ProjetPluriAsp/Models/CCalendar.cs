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
        [Required]
        public DateTime JourDispo { get; set; }
        [Required]
        public virtual CDish Dish { get; set; }
    }
}