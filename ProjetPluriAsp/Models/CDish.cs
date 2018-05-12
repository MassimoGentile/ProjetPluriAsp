using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CDish
    {
        public int Ref { get; private set; }
        public string Name { get; private set; }
        public double DishPrice { get; private set; }
        public string Description { get; private set; }
        private CTheme Theme;
        private List<CIngredient> Ingredient = new List<CIngredient>();
        private List<double> Number = new List<double>();
        private List<CCalendar> Calendar = new List<CCalendar>();
        private static int incremNum = 0;
        public CDish(CTheme themeInit, string nameInit, double dishPriceInit, string descriptionInit)
        {
            Ref = ++incremNum; //Incrémentation automatique de la référence à la création de chaque plat 
            Theme = themeInit;
            Name = nameInit;
            DishPrice = dishPriceInit;
            Description = descriptionInit;
        }
        public void AddIngredient(double number, CIngredient item) //Permet de rajouter les ingredients du plat
        {
            Number.Add(number); //Détermine le nombre de fois que l'ingredient est utilisée, par exemple 2 salades,etc...
            Ingredient.Add(item); //L'ingredient est relier par ça position dans la liste avec le nombre de fois utilisée
        }
        public void AddAvailableDay(CCalendar day) //Ajout des jours dispo jour par jour
        {
            Calendar.Add(day);
        }
    }
}