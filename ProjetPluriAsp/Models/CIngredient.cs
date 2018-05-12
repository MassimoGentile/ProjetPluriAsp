using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CIngredient
    {
        public double Price { get; private set; } //Peut-être penser à rajouter un système de reconnaissance d'unitée pour chaque ingredient
        public string Name { get; private set; }
        public CIngredient(double PriceInit, string nameInit)
        {
            Price = PriceInit;
            Name = nameInit;
        }
    }
}