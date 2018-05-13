using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class COrder
    {
        public DateTime Date { get; set; }
        public string State { get; set; }
        public int Amount { get; set; }
        public virtual CDish Dish { get; set; }
        /*public COrder(DateTime dateInit, string stateInit, int amountInit, CDish dishInit)
        {
            Date = dateInit;
            State = stateInit;
            Amount = amountInit;
            Dish = dishInit; //Chaque commande est lier à un seul plat
        }*/
    }
}