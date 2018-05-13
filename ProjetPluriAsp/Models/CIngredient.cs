using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CIngredient
    {
        public double Price { get; set; } //Peut-être penser à rajouter un système de reconnaissance d'unitée pour chaque ingredient
        public string Name { get; set; }
        public double Nombre { get; set; } //Détermine le nombre de fois que l'ingredient est utilisée, par exemple 2 salades,etc...
    }
}