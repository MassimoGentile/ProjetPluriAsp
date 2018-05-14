using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class COrder
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }
        public int Amount { get; set; }
        public virtual CDish Dish { get; set; }
    }
}