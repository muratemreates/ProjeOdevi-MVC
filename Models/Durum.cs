using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjeOdevi.Models
{
    [Table("Durum")]
    public class Durum
    {
        public int  Id { get; set; }

        [Display(Name = "Proje durumu")]
        public string Projedurumu { get; set; }
    }
}