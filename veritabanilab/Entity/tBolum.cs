using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanilab.Entity
{
    class tBolum
    {
        [Key]
        public int bolumID { get; set; }
        public string bolumAd { get; set; }
        public int fakulteID { get; set; }
        [ForeignKey("fakulteID")]
        public virtual tFakulte tFakulte { get; set; }
    }
}
