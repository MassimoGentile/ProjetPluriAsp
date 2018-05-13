using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CNeighbour : CUser
    {
        public string Description { get; set; }
        public virtual List<CAppreciation> ListAppreciation { get; set; }
        public virtual CBasket Basket { get; set; }
        /*public CNeighbour(string passwordInit, string emailInit, string firstNameInit, string lastNameInit, string adressInit, int bankAccountInit)
            : base(passwordInit, emailInit, firstNameInit, lastNameInit, adressInit, bankAccountInit)
        {
            Console.WriteLine("Neighbour successfully added !"); //Message temporaire tant que c'est une application console
        }

        public void AddDescription(string descriptionInit)
        {
            Description = descriptionInit;
        }
        public void LeaveAppreciation(CAppreciation appreciationInit)
        {
            ListAppreciation.Add(appreciationInit); //Rajout de l'appréciation laissé dans la liste
        }
        public void AddBasket(CBasket basketInit)
        {
            Basket = basketInit; //Ne pas oublier de faire en sorte de supprimer le panier une fois que celui-ci est commandé pour être en accord avec notre diagramme sinon il faut passer par une liste
        }
        public void ChooseDish(CDish dish, int numberWhanted)
        {
            Basket.AddOrder(new COrder(DateTime.Now, "Commander", numberWhanted, dish));
        }
        public void MakeOrder()
        {
            //Trouver comment implémenter cette fonction
        }*/
    }
}