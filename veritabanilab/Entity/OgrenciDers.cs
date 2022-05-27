using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanilab.Entity
{
    class OgrenciDers
    {
        [Key]
        public int ıd { get; set; }
        public int ogrenciID { get; set; }
        [ForeignKey("ogrenciID")]
        public virtual tOgrenci tOgrenci { get; set; }
        public int dersID {get; set;}
        public string yil { get; set; }
        public string yariyil { get; set; }
        public int vize { get; set; }
        public int final { get; set; }
    }
}
