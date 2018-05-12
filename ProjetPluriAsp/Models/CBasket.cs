using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CBasket
    {
        public int Number { get; private set; } //ça sert à quoi?
        public double BasketAmount { get; private set; }
        public DateTime PaymentDate { get; private set; }
        private List<COrder> OrderList = new List<COrder>();
        public CBasket(int numberInit, double basketAmountInit, DateTime paymentDateInit)
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
        }
    }
}