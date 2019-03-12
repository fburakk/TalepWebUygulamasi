using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepWebUygulamasi.Entities
{
    public class Talep
    {
        [Key]
        public int TalepId { get; set; }

        public string TalepKonusu { get; set; }

        public string TalepAciklama { get; set; }
    }
}
