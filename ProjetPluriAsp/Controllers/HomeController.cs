using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetPluriAsp.Models;

namespace ProjetPluriAsp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.title = "Bienvenue";
            return View();
        }


        public ActionResult HomePage()
        {
            ViewBag.title = "Accueil";
            return View();
        }

        public ActionResult Dishes()
        {
            Dal dal = new Dal();
            ViewBag.ListDish = dal.ObtainDish();
            ViewBag.title = "Plats";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.title = "Contact";
            return View();
        }
        [HttpPost]
        public ActionResult Identification(string email, string pwd)
        {
            Dal d = new Dal();
            if (d.Identification(email, pwd))
            {
                return View("HomePage");
            }

            ViewBag.erreur = "Erreur. Mot de passe et/ou E-mail incorrect";
            return View("Index");
        }

        public ActionResult Inscription()
        {
            ViewBag.title = "Inscription";

            //Pour tester les utilisateurs enregistrer

            //Dal d = new Dal();
            //ViewBag.test = d.GetCooker();
            //ViewBag.test2 = d.GetNeighbour();

            return View();
        }

        [HttpPost]
        public ActionResult AjouterUser(string firstN, string name, string password, string email, string adress, string bankAccount, string user)
        {
            if (user == "cooker")
            {
                long cb = Convert.ToInt64(bankAccount);
                Dal d = new Dal();
                d.InscriptionCooker(firstN, name, password, email, adress, cb);
            }
            else
            {
                if (user == "neighbour")
                {
                    string description = "";
                    long cb = Convert.ToInt64(bankAccount);
                    Dal d = new Dal();
                    d.InscriptionNeighbour(firstN, name, password, email, adress, cb, description);
                }
            }
            return RedirectToAction("Inscription");
        }
    }
}