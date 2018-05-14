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
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public virtual CDish Dish { get; set; }
    }
}