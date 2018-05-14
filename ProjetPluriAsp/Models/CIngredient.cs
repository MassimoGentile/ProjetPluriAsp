using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CIngredient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Price { get; set; } //Peut-être penser à rajouter un système de reconnaissance d'unitée pour chaque ingredient
        [Required]
        public string Name { get; set; }
        [Required]
        public double Number { get; set; } //Détermine le nombre de fois que l'ingredient est utilisée, par exemple 2 salades,etc...
    }
}