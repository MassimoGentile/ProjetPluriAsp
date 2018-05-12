using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CAppreciation
    {
        public int Note { get; private set; }
        public string Commentaries { get; private set; }
        public COrder Commande { get; private set; }
        //bite
        private List<List<int>> dishList = new List<List<int>>();

        public CAppreciation(int noteInit, string commentariesInit, COrder commandeInit) //Je passe en attribut la commande pour pouvoir identifier la commande
        {
            Note = noteInit;
            Commentaries = commentariesInit;
            Commande = commandeInit; //Je lie l'appréciation à la commande sur laquelle je laisse une appréciation
            int enter = 0;
            foreach (List<int> i in dishList) //Parcours de la liste des plats sur lesquelles une appréciation à déjà été laissée
            {
                if (commandeInit.Dish.Ref == i[0]) //Si une appréciation à déjà été laissée sur le plat alors il correspond à la condition
                {
                    i[1] += noteInit; //J'ajoute la nouvelle note à celle qui y sont déjà
                    i[2]++; //J'incrémente le compteur de 1
                    enter++; //J'incrémente de 1 cette variable pour savoir qu'il est entrer dans la condition
                }
            }
            if (enter == 0)//Si la référence n'est pas dans la liste
            {
                dishList.Add(new List<int> { commandeInit.Dish.Ref, 0, 0 }); //J'ajoute une liste avec comme 1er élement la ref, suivi des notes et du compteur pour terminer
            }
        }
        public CDish AverageAppreciation() //Fonction qui retourne le plat qui à la meilleur moyenne
        {
            CDish dish = null;
            float average = 0;
            int reference;
            foreach (List<int> i in dishList)
            {
                float temp = (float)i[1] / i[2];
                if (average < temp) //Je récupère la moyenne et la référence du plat qui à la meilleur moyenne
                {
                    average = temp;
                    reference = i[0];
                }
            }
            /* 
             ATTENTION IL FAUT REUSSIR A RELIER LA REFERENCE DU PLAT AU PLAT QUI LUI CORRESPOND 
             SI ON PASSE PAR UNE BASE DE DONNEE, TERMINER CETTE METHODE EST SIMPLE CAR IL SUFFIT D'ALLER RECHERCHER L'ID DU PLAT EN QUESTION ET ON RETOMBE SUR LE PLAT DIRECTEMENT
             
             */
            return dish;
        }
    }
}