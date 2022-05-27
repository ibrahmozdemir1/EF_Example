using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanilab.Entity
{
    class tDers
    {
        [Key]
        public int dersID { get; set; }
        public string dersAd { get; set; }
        public int bolumID { get; set; }
        [ForeignKey("bolumID")]
        public virtual tBolum tBolum { get; set; }
        public int ogrtID { get; set; }

    }
}
