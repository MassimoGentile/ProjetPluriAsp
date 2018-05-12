using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CCalendar
    {
        private DateTime JourDispo;
        public CCalendar(DateTime jourDispoInit, CDish dish)
        {
            JourDispo = jourDispoInit;
            dish.AddAvailableDay(this); //à vérifier ci cette fonction fonctionne correctement (Elle doit servir à rajouter en fonction du plat le jour disponible)
        }
    }
}