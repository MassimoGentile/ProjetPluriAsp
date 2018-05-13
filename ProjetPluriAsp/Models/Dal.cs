using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class Dal : IDisposable
    {
        private BddContext bdd;
        private List<int> ThemeAllreadyChoose = new List<int>();
        public Dal()
        {
            bdd = new BddContext();
        }
        public void Dispose()
        {
            bdd.Dispose();
        }
        //////////////////////////////////////////////CAdmin/////////////////////////////////////////////////////
        /*public void AdminInstance() //Tentative infructueuse de singleton en entity framework
        {
            CAdmin _instance;
            try
            {
                _instance = bdd.T_Admin.SingleOrDefault(a => a.FirstName == "Dik");
            }
            catch(Exception)
            {
                _instance = null;
            }
            if (_instance == null)
                bdd.T_Admin.Add(new CAdmin { FirstName = "Dik", LastName = "Apprio", Password = "BestAdminPassword", Email = "DikApprio@gmail.com", Adress = "Avenue des beaux Art 19 6042 Charleroi", BankAccount = 04545654, admin = true });
        }*/
        //////////////////////////////////////////////CAppreciation//////////////////////////////////////////////

        //////////////////////////////////////////////CBasket////////////////////////////////////////////////////

        //////////////////////////////////////////////CCalendar//////////////////////////////////////////////////

        //////////////////////////////////////////////CCooker////////////////////////////////////////////////////
        public void SetCalendar(DateTime day, CDish dish)
        {
            bdd.T_Calendar.Add(new CCalendar { JourDispo = day, Dish = dish });
        }
        //////////////////////////////////////////////CDish//////////////////////////////////////////////////////
        public void AddIngredient(double number, CIngredient item) //Permet de rajouter les ingredients du plat
        {
            CDish dish;
            Number.Add(number); //Détermine le nombre de fois que l'ingredient est utilisée, par exemple 2 salades,etc...
            Ingredient.Add(item); //L'ingredient est relier par ça position dans la liste avec le nombre de fois utilisée
        }
        //////////////////////////////////////////////CIngredient////////////////////////////////////////////////
        public void AddIngredient(double priceInit, string nameInit)
        {
            bdd.T_Ingredient.Add(new CIngredient { Name = nameInit, Price = priceInit });
        }
        //////////////////////////////////////////////CNeighbour/////////////////////////////////////////////////

        //////////////////////////////////////////////COrder/////////////////////////////////////////////////////

        //////////////////////////////////////////////CThème/////////////////////////////////////////////////////
        private int RandomPaschoisis()  //Méthode de génération d'un nombre random pour les thèmes
        {
            Random alea = null;
            int random = alea.Next(1, bdd.T_Theme.ToList().Count());            //Génération d'un nombre aléatoire
            int cpt = 0;                                                        //Implémentation d'un compteur de valeur 0
            while (true)                                                        //Mise en place d'une boucle infinie
            {
                foreach (CTheme t in bdd.T_Theme)                               //Parcour de tout les thèmes
                {
                    if (t.AllreadyChoose == true)                               // Si un des attributs AllreadyChoose vaux true
                        cpt++;                                                  //Alors j'augmente de 1 un compteur
                }
                if (cpt == 0)                                                   //Si le compteur est rester a 0 après le parcour de tout les thèmes
                    break;                                                      //Je casse la boucle infinie
                else                                                            //Sinon
                {
                    random = alea.Next(1, bdd.T_Theme.ToList().Count());        //Je génère à nouveau un nombre aléatoire
                    cpt = 0;                                                    //Et je remet le compteur à 0
                }
            }
            return random;
        }
        public void SetTheme()  //Permet de générer un nombre aléatoire qui na pas encore été choisis pour définir le thème de la semaine;
        {
            int nbrAlea;
            nbrAlea = RandomPaschoisis();                                   //Récupération d'un nombre aléatoire pas encore choisis depuis 5 semaines
            CTheme theme;
            if (ThemeAllreadyChoose.Count >= 5)                             //Au bout de 5 fois un theme peux désormais être de nouveau être choisis
            {
                theme = bdd.T_Theme.SingleOrDefault(t => t.Id == ThemeAllreadyChoose[0]);
                theme.AllreadyChoose = false;
                ThemeAllreadyChoose.RemoveAt(0);                            //Je retire du tableau la 1ère entrée qui n'aura donc plus été choisis pendant 5 semaines
            }
            ThemeAllreadyChoose.Add(nbrAlea);                               //J'ajoute l'id du theme de la semaine dans le tableau des thèmes déjà choisis
            theme = bdd.T_Theme.SingleOrDefault(t => t.Id == ThemeAllreadyChoose.Last());
            theme.ChoosenTheme = false;
            theme = bdd.T_Theme.SingleOrDefault(t => t.Id == nbrAlea);      //J'associe le numéro choisis à la chaine de charactère qui lui correspond
            theme.ChoosenTheme = true;
            theme.AllreadyChoose = true;
        }
        //////////////////////////////////////////////CUser//////////////////////////////////////////////////////

    }
}