using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanilab.Entity
{
    class Ogretmen
    {
        [Key]
        public int ogrtID { get; set; }
        public string ogrtAd { get; set; }
        public string ogrtsoyad { get; set; }
    }
}
