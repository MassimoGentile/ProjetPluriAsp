using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CBasket
    {
        public int Number { get; set; }
        public double BasketAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual List<COrder> OrderList { get; set; }
        /*public CBasket(int numberInit, double basketAmountInit, DateTime paymentDateInit)
        {
            Number = numberInit;
            BasketAmount = basketAmountInit;
            PaymentDate = paymentDateInit;
        }
        public void AddOrder(COrder order)
        {
            OrderList.Add(order);
        }
        public double CalculAmount()
        {
            double price = 0;
            foreach (COrder order in OrderList)
                price += (order.Dish.DishPrice * order.Amount);
            return price;
        }*/
    }
}