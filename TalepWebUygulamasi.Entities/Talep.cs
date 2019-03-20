using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepWebUygulamasi.Entities
{
    public class Talep
    {
        public string TalebiYapan { get; set; }

        [Key]
        public int TalepId { get; set; }

        public string TalepKonusu { get; set; }

        public string TalepAciklama { get; set; }

        public string FileUrl { get; set; }

        public bool Degerlendirildimi { get; set; }

        public string TalepDegerlendirmesi { get; set; }

        public bool olumluOlumsuz { get; set; }

        public string DegerlendirmeZamani { get; set; }

        [ForeignKey("TalebiYapan")]
        public HUser HUser { get; set; }
    }
}
