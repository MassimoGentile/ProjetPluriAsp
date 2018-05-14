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
        public static int idDish = 0;
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
        public void AddOrder(CNeighbour neighbour, int numberWhanted, CDish dish)
        {
            neighbour.Basket.OrderList.Add(new COrder { Date = DateTime.Now, State = "En Attente", Dish = dish, Amount = numberWhanted });
        }
        public void CalculAmount(CNeighbour neighbour)
        {
            double price = 0;
            foreach (COrder order in neighbour.Basket.OrderList)
                price += (order.Dish.DishPrice * order.Amount);
            neighbour.Basket.BasketAmount = price;
        }
        //////////////////////////////////////////////CCalendar//////////////////////////////////////////////////

        //////////////////////////////////////////////CCooker////////////////////////////////////////////////////
        public void InscriptionCooker(string firstNameInit, string lastNameInit, string passwordInit, string emailInit, string adressInit, int bankAccountInit)
        {
            bdd.T_Cooker.Add(new CCooker { FirstName = firstNameInit, LastName = lastNameInit, Password = passwordInit, Email = emailInit, Adress = adressInit, BankAccount = bankAccountInit });
        }
        public void MakeDish(CCooker cooker, string nameInit, double dishPriceInit, string descriptionInit, List<CCalendar> calendarInit, List<CIngredient> ingredientInit)
        {
            cooker.DishList.Add(new CDish { Id = ++idDish, Theme = GetTheme(), Name = nameInit, DishPrice = dishPriceInit, Description = descriptionInit, Calendar = calendarInit, Ingredient = ingredientInit });
        }
        public void DishModification(CCooker cooker, CDish previousDish, string nameInit, double dishPriceInit, string descriptionInit, List<CCalendar> calendarInit, List<CIngredient> ingredientInit)
        {
            CDish alterDish = cooker.DishList.SingleOrDefault(d => d.Id == previousDish.Id);
            alterDish.Name = nameInit;
            alterDish.DishPrice = dishPriceInit;
            alterDish.Description = descriptionInit;
            alterDish.Calendar = calendarInit;
            alterDish.Ingredient = ingredientInit;
            cooker.DishList.Remove(previousDish);
            cooker.DishList.Add(alterDish);
        }
        //////////////////////////////////////////////CDish//////////////////////////////////////////////////////
        public void AddDishIngredient(CDish dish, CIngredient item) //Permet de rajouter les ingredients du plat
        {
            dish.Ingredient.Add(item);
        }
        public void AddAvailableDay(CCalendar day, CDish dish) //Ajout des jours dispo jour par jour
        {
            dish.Calendar.Add(day);
        }
        //////////////////////////////////////////////CIngredient////////////////////////////////////////////////
        public void AddIngredient(double priceInit, string nameInit)
        {
            bdd.T_Ingredient.Add(new CIngredient { Name = nameInit, Price = priceInit });
        }
        //////////////////////////////////////////////CNeighbour/////////////////////////////////////////////////
        public void InscriptionNeighbour(string firstNameInit, string lastNameInit, string passwordInit, string emailInit, string adressInit, int bankAccountInit, string descriptionInit)
        {
            bdd.T_Neighbour.Add(new CNeighbour { FirstName = firstNameInit, LastName = lastNameInit, Password = passwordInit, Email = emailInit, Adress = adressInit, BankAccount = bankAccountInit, Description = descriptionInit, Basket = null, ListAppreciation = null });
        }
        public void DescriptionModification(CNeighbour neighbour, string description)
        {
            neighbour.Description = description;
        }
        public void MakeOrder(CNeighbour neighbour)
        {
            neighbour.Basket.PaymentDate = DateTime.Now; //Evidement le systeme de payement doit être ici
        }
        public void LeaveAppreciation(CNeighbour neighbour, int note, string comment, COrder command)
        {
            neighbour.ListAppreciation.Add(new CAppreciation { Note = note, Commentaries = comment, Commande = command });
        }
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
        public CTheme GetTheme()
        {
            CTheme theme = bdd.T_Theme.SingleOrDefault(t => t.ChoosenTheme == true);
            return theme;
        }
    }
}