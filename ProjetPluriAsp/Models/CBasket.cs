using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CBasket
    {
        public double BasketAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual List<COrder> OrderList { get; set; }
    }
}