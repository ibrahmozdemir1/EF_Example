using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanilab.Entity
{
    class tOgrenci
    {
        [Key]
        public int ogrenciID { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public int bolumID { get; set; }
        [ForeignKey("bolumID")]
        public virtual tBolum tBolum { get; set; }
    }
}