using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//[Key] //ID Bilgisini primary key yapmak için kütüphane
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Siniflar
{
    public class Kategori
    {
        [Key] //ID Bilgisini primary key yapmak için
        public int KategoriID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string KategoriAd { get; set; }
        //her kategoride birden fazla ürün var bire-çok ilişki
        public ICollection<Urun> Uruns { get; set; }
    }
}