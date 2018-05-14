using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CDish
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double DishPrice { get; set; }
        public string Description { get; set; }
        public virtual CTheme Theme { get; set; }
        public virtual List<CIngredient> Ingredient { get; set; }
        public virtual List<CCalendar> Calendar { get; set; }
    }
}