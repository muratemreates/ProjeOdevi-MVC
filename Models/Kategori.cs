using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjeOdevi.Models
{
    [Table("Kategori")]
    public class Kategori
    {
        public int Id { get; set; }

        [Display(Name = "Kategori Adı")]
        public string KategoriAdi { get; set; }
    }
}