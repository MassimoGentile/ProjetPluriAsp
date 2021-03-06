﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CBasket
    {
        [Key]
        public int Id { get; set; }
        public double BasketAmount { get; set; }
        public DateTime PaymentDate { get; set; }
        public virtual List<COrder> OrderList { get; set; }
    }
}