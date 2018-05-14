using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CNeighbour : CUser
    {
        public string Description { get; set; }
        public virtual List<CAppreciation> ListAppreciation { get; set; }
        public virtual CBasket Basket { get; set; }
    }
}