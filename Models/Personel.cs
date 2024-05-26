using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjeOdevi.Models
{
    [Table("Personel")]
    public class Personel
    {
        public int Id { get; set; }

        [Display(Name = "Personel Adı")]
        public string PersonelAdi { get; set; }
    }
}