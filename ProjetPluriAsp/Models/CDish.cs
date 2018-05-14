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
        [Required]
        public string Name { get; set; }
        [Required]
        public double DishPrice { get; set; }
        public string Description { get; set; }
        [Required]
        public virtual CTheme Theme { get; set; }
        [Required]
        public virtual List<CIngredient> Ingredient { get; set; }
        [Required]
        public virtual List<CCalendar> Calendar { get; set; }
    }
}