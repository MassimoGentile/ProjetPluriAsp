using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CAppreciation
    {
        [Key]
        public int Id { get; set; }
        public int Note { get; set; }
        public string Commentaries { get; set; }
        public virtual COrder Commande { get; set; }
    }
}