using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class BddContext : DbContext
    {
        public DbSet<CAdmin> T_Admin { get; set; }
        public DbSet<CAppreciation> T_Appreciation { get; set; }
        public DbSet<CBasket> T_Basket { get; set; }
        public DbSet<CCalendar> T_Calendar { get; set; }
        public DbSet<CCooker> T_Cooker { get; set; }
        public DbSet<CDish> T_Dish { get; set; }
        public DbSet<CIngredient> T_Ingredient { get; set; }
        public DbSet<CNeighbour> T_Neighbour { get; set; }
        public DbSet<COrder> T_Order { get; set; }
        public DbSet<CTheme> T_Theme { get; set; }
        public DbSet<CUser> T_User { get; set; }
        public BddContext()
            : base ("DefaultConnection")
        {
            Database.SetInitializer(new BddContextInitializer());
        }

    }
    public class BddContextInitializer : DropCreateDatabaseIfModelChanges<BddContext>
    {
        protected override void Seed(BddContext bdd)
        {
            bdd.T_Theme.Add(new CTheme { Name = "Italian", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "American", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "Chicken", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "Fish", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "Green Day", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "Chinese", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "Japanese", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "England", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "Russian", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Theme.Add(new CTheme { Name = "Rice", AllreadyChoose = false, ChoosenTheme = false });
            bdd.T_Ingredient.Add(new CIngredient { Name = "Salade", Price = 2.5, Number = 3});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Tomate", Price = 2.35, Number = 4});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Côte de porc", Price = 7.12, Number = 2});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Filet de poulet", Price = 4.3, Number = 7});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Thon", Price = 3, Number = 5});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Sushi", Price = 5, Number = 12});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Pêche", Price = 0.5, Number = 1});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Cocombre", Price = 1.63, Number = 3});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Vanille", Price = 2.47, Number = 5});
            bdd.T_Ingredient.Add(new CIngredient { Name = "Vodka", Price = 25.3, Number = 9});
            bdd.T_Admin.Add(new CAdmin { FirstName = "Dik", LastName = "Apprio", Password = "BestAdminPassword", Email = "DikApprio@gmail.com", Adress = "Avenue des beaux Art 19 6042 Charleroi", BankAccount = 04545654, admin = true});
            bdd.T_Cooker.Add(new CCooker { FirstName = "Jean", LastName = "Archibald", Password = "JeanPwd", Email = "JeanArchibald@gmail.com", Adress = "Rue des perdus 24 6040 Jumet", BankAccount = 564604560 });
            bdd.T_Cooker.Add(new CCooker { FirstName = "Paul", LastName = "Ice", Password = "PaulPwd", Email = "PaulIce@gmail.com", Adress = "Avenue de la loi 42 6042 Charleroi", BankAccount = 434652450 });
            bdd.T_Order.Add(new COrder { Date = DateTime.Now, State = "OK", Amount = 3, Dish = bdd.T_Dish.SingleOrDefault(d => d.Name == "Bedo sur son coulis de verdure") });
            bdd.T_Order.Add(new COrder { Date = DateTime.Now, State = "NOT OK", Amount = 1, Dish = bdd.T_Dish.SingleOrDefault(d => d.Name == "Steak frite moutarde juif") });
            bdd.T_Appreciation.Add(new CAppreciation { Note = 6, Commentaries = "Pourrie de chez pourrie", Commande = bdd.T_Order.SingleOrDefault(c => c.Id == 1) });
            bdd.T_Appreciation.Add(new CAppreciation { Note = 9, Commentaries = "Délicieux", Commande = bdd.T_Order.SingleOrDefault(c => c.Id == 2) });
            bdd.T_Basket.Add(new CBasket { BasketAmount = CalculAmount(bdd.T_Neighbour.SingleOrDefault(n => n.FirstName == "Alain")), PaymentDate = new DateTime(17 / 10 / 17), OrderList = OrderList(bdd.T_Order.SingleOrDefault(o => o.Id == 1)) });
            bdd.T_Basket.Add(new CBasket { BasketAmount = CalculAmount(bdd.T_Neighbour.SingleOrDefault(n => n.FirstName == "Djamal")), PaymentDate = new DateTime(02 / 02 / 16), OrderList = OrderList(bdd.T_Order.SingleOrDefault(o => o.Id == 2)) });
            bdd.T_Calendar.Add(new CCalendar { JourDispo = new DateTime(2/11/2018) });
            bdd.T_Calendar.Add(new CCalendar { JourDispo = new DateTime(4/12/1996) });
            bdd.T_Dish.Add(new CDish { Name = "Bedo sur son coulis de verdure", DishPrice = 12.45, Description = "C'est trop bon le bedo", Theme = bdd.T_Theme.SingleOrDefault(t => t.Name == "Italian"), Ingredient = ListIngredient("Tomate") , Calendar = ListCalendar(new DateTime(2/11/2018))});
            bdd.T_Dish.Add(new CDish { Name = "Steak frite moutarde juif", DishPrice = 24.63, Description = "Attention à la moutarde elle tue dans certain cas" , Theme = bdd.T_Theme.SingleOrDefault(t => t.Name == "Chicken"), Ingredient = ListIngredient("Vanille"), Calendar = ListCalendar(new DateTime(4/12/1996)) });
            bdd.T_Neighbour.Add(new CNeighbour { FirstName = "Alain", LastName = "Provist", Password = "AlainPwd", Email = "AlainProvist@gmail.com", Adress = "Rue des potiers 24 6040 Jumet", BankAccount = 1456435465, Description = "J'arrive souvent sans prévenir", Basket = bdd.T_Basket.SingleOrDefault(b => b.Id == 1), ListAppreciation = AppList(bdd.T_Appreciation.SingleOrDefault(a => a.Note == 6))});
            bdd.T_Neighbour.Add(new CNeighbour { FirstName = "Djamal", LastName = "Dormi", Password = "DjamalPwd", Email = "DjamalDormi@gmail.com", Adress = "Rue des truants 1 6042 Charleroi", BankAccount = 123456452, Description = "Je suis Arabe mais je paye mes plats", Basket = bdd.T_Basket.SingleOrDefault(b => b.Id == 2), ListAppreciation = AppList(bdd.T_Appreciation.SingleOrDefault(a => a.Note == 9)) });
        }
        private List<CIngredient> ListIngredient(string arg1)
        {
            List<CIngredient> Listingre = new List<CIngredient>();
            CIngredient ingre = new CIngredient();
            BddContext bdd = new BddContext();
            ingre = bdd.T_Ingredient.SingleOrDefault(i => i.Name == arg1);
            Listingre.Add(ingre);
            return Listingre;
        }
        private List<CCalendar> ListCalendar(DateTime date)
        {
            List<CCalendar> ListDate = new List<CCalendar>();
            CCalendar calen = new CCalendar();
            BddContext bdd = new BddContext();
            calen = bdd.T_Calendar.SingleOrDefault(c => c.JourDispo == date);
            ListDate.Add(calen);
            return ListDate;
        }
        private double CalculAmount(CNeighbour neighbour)
        {
            double price = 0;

            foreach (COrder order in neighbour.Basket.OrderList)
                price += (order.Dish.DishPrice * order.Amount);
            neighbour.Basket.BasketAmount = price;

            return price;
        }

        private List<COrder> OrderList(COrder or)
        {
            List<COrder> ListOrder = new List<COrder>();
            COrder order = new COrder();
            BddContext bdd = new BddContext();
            order = bdd.T_Order.SingleOrDefault(o => o.Id == or.Id);
            ListOrder.Add(order);

            return ListOrder;
        }
        private List<CAppreciation> AppList(CAppreciation app)
        {
            List<CAppreciation> ListApp = new List<CAppreciation>();
            CAppreciation appreci = new CAppreciation();
            BddContext bdd = new BddContext();
            appreci = bdd.T_Appreciation.SingleOrDefault(a => a.Note == app.Note);
            ListApp.Add(appreci);

            return ListApp;
        }
        
    }
}