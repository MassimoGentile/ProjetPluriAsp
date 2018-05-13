using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CCooker : CUser
    {
        public virtual List<CDish> DishList { get; set; }
    }
}