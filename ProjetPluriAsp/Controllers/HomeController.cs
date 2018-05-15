﻿using System;
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

        public ActionResult Inscription()
        {
            ViewBag.title = "Inscription";
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


    }
}