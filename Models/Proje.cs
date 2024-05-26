using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjeOdevi.Models
{
    [Table("Proje")]
    public class Proje
    {
        public int Id { get; set; }
        
        [Display(Name = "Proje Adı")]
        public string ProjeAdi { get; set; }
        
        [Display(Name = "Başlangıç Tarihi")]
        public DateTime BaslangicTarihi { get; set; }
        
        [Display(Name = "Bitiş Tarihi")]
        public DateTime BitisTarihi { get; set; }
        
        public int DurumId { get; set; }
        public int KategoriId { get; set; }
        public int PersonelId { get; set; }



        public virtual Durum Durum { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Personel Personel { get; set; }
    }
}