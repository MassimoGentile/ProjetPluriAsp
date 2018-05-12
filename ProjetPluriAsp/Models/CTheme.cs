using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CTheme
    {
        private List<string> ListTheme = new List<string> { "Italian", "American", "Chicken", "Fish", "Green Day", "Chinese", "Japanese", "England", "Russian", "Rice" };
        private List<int> AllreadyChoose = new List<int> { };
        public string Theme { get; private set; }
        private Random aleatoire = new Random();
        private int nbrAlea;
        public string GetTheme()
        {
            return Theme;
        }
        public void SetTheme()                  //Permet de générer un nombre aléatoire qui na pas encore été choisis pour définir le thème de la semaine;
        {
            nbrAlea = RandomPaschoisis();       //Récupération d'un nombre aléatoire pas encore choisis depuis 5 semaines
            if (AllreadyChoose.Count >= 5)      //Au bout de 5 semaines un theme peux désormais être de nouveau être choisis
                AllreadyChoose.RemoveAt(0);     //Je retire du tableau la 1ère entrée qui n'aura donc plus été choisis pendant 5semaines
            AllreadyChoose.Add(nbrAlea);        //J'ajoute le nombre du theme de la semaine dans le tableau des nombres déjà choisis
            Theme = ListTheme[nbrAlea - 1];     //J'associe le numéro choisis à la chaine de charactère qui lui correspond
        }
        private int RandomPaschoisis()
        {
            int random = aleatoire.Next(1, ListTheme.Count() + 1); //Génération d'un nombre aléatoire
            int cpt = 0; //Implémentation d'un compteur de valeur 0
            while (true) //Mise en place d'une boucle infinie
            {
                foreach (int i in AllreadyChoose) //Parcour du tableau des nombres déjà choisis il y a moins de 5 semaines
                {
                    if (random == i) // Si le nombre générer correspond au nombre dans le tableau
                        cpt++;      //J'augmente de 1 un compteur
                }
                if (cpt == 0)   //Si le compteur est rester a 0 après le parcour du tableau de nombre déjà choisi il y a moins de 5 semaines
                    break;      //Je casse la boucle infinie
                else //Sinon
                {
                    random = aleatoire.Next(1, ListTheme.Count() + 1); //Je génère à nouveau un nombre aléatoire
                    cpt = 0; //Et je remet le compteur à 0
                }
            }
            return random;
        }
    }
}