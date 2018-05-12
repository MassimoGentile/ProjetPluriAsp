using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class BddContext
    {
        public DbSet<CAdmin> T_Admin { get; set; }
    }
}