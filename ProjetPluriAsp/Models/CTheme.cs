using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetPluriAsp.Models
{
    public class CTheme
    {
        [Key]
        public int Id { get; set; }
        public bool AllreadyChoose { get; set; }
        public bool ChoosenTheme { get; set; }
        [Required]
        public string Name { get; set; }
    }
}