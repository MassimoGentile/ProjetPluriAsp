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
        {
            Database.SetInitializer(new BddContextInitializer());
        }
    }
    public class BddContextInitializer : DropCreateDatabaseIfModelChanges<BddContext>
    {
        protected override void Seed(BddContext bdd)
        {
            bdd.T_Theme.Add(new CTheme { Name = "Italian", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "American", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "Chicken", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "Fish", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "Green Day", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "Chinese", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "Japanese", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "England", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "Russian", AllreadyChoose = false });
            bdd.T_Theme.Add(new CTheme { Name = "Rice", AllreadyChoose = false });
            bdd.T_Ingredient.Add(new CIngredient { Name = "Salade", Price = 2.5, Number = 3 });
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
            //bdd.T_Dish.Add(new CDish {  });
            bdd.T_Cooker.Add(new CCooker { FirstName = "Jean", LastName = "Archibald", Password = "JeanPwd", Email = "JeanArchibald@gmail.com", Adress = "Rue des perdus 24 6040 Jumet", BankAccount = 564604560 });
            bdd.T_Cooker.Add(new CCooker { FirstName = "Paul", LastName = "Ice", Password = "PaulPwd", Email = "PaulIce@gmail.com", Adress = "Avenue de la loi 42 6042 Charleroi", BankAccount = 434652450 });
            bdd.T_Neighbour.Add(new CNeighbour { FirstName = "Alain", LastName = "Provist", Password = "AlainPwd", Email = "AlainProvist@gmail.com", Adress = "Rue des potiers 24 6040 Jumet", BankAccount = 1456435465, Description = "J'arrive souvent sans prévenir" });
            bdd.T_Neighbour.Add(new CNeighbour { FirstName = "Djamal", LastName = "Dormi", Password = "DjamalPwd", Email = "DjamalDormi@gmail.com", Adress = "Rue des truants 1 6042 Charleroi", BankAccount = 123456452, Description = "Je suis Arabe mais je paye mes plats" });
        }
    }
}