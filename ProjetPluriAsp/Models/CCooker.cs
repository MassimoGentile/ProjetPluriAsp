using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CCooker : CUser
    {
        public virtual List<CDish> DishList { get; set; }
        /*public CCooker(string passwordInit, string emailInit, string firstNameInit, string lastNameInit, string adressInit, int bankAccountInit)
            : base(passwordInit, emailInit, firstNameInit, lastNameInit, adressInit, bankAccountInit)
        {
            Console.WriteLine("Cooker successfully added !");
        }
        public void SetCalendar(DateTime day, CDish dish)
        {
            new CCalendar(day, dish); //Ajout du jour dispo
        }
        public void MakeDish(CTheme themeInit, string nameInit, double dishPriceInit, string descriptionInit)
        {
            DishList.Add(new CDish(themeInit, nameInit, dishPriceInit, descriptionInit)); //Création du plat directement en le rajoutant dans la liste
        }
        public void DishModification(CDish previousDish, CTheme themeInit, string nameInit, double dishPriceInit, string descriptionInit)
        {
            CDish alterDish = new CDish(themeInit, nameInit, dishPriceInit, descriptionInit);
            DishList[DishList.FindIndex(x => x.Equals(previousDish))] = alterDish; // A tester!! (Cette commande recherche dans la liste des plat celui qui doit être modifier et puis le remplace par le nouveau)
        }*/
    }
}