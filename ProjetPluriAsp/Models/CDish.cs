using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CDish
    {
        public int Ref { get; set; }
        public string Name { get; set; }
        public double DishPrice { get; set; }
        public string Description { get; set; }
        public virtual CTheme Theme { get; set; }
        public virtual List<CIngredient> Ingredient { get; set; }
        public virtual List<CCalendar> Calendar { get; set; }
        /*public CDish(CTheme themeInit, string nameInit, double dishPriceInit, string descriptionInit)
        {
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
        }*/
    }
}