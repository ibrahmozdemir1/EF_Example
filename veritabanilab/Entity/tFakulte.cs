using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veritabanilab.Entity
{
    class tFakulte
    {
        [Key]
        public int fakulteID { get; set; }
        public string fakulteAd { get; set; }
    }
}
