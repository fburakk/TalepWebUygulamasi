using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepWebUygulamasi.DAL;
using TalepWebUygulamasi.Entities;

namespace TalepWebUygulamasi.Services
{
    public class TalepIslemler
    {
        public List<Talep> TalepleriGetir()
        {
            using (var talepContext = new TalepContext())
            {
                return talepContext.Talepler.ToList();
            }
        }

        public Talep TalebiGetir(int ID)
        {
            using (var talepContext = new TalepContext())
            {
                return talepContext.Talepler.Find(ID);
            }
        }

        public void TalepEkle(Talep talep)
        {
            using (var talepContext = new TalepContext())
            {
                talepContext.Talepler.Add(talep);
                talepContext.SaveChanges();
            }
        }

        public void TalepGuncelle(Talep guncelTalep)
        {
            using (var talepContext = new TalepContext())
            {
                var guncellenecekTalep = talepContext.Talepler.Find(guncelTalep.TalepId);

                //string properties
                guncellenecekTalep.TalepKonusu = guncelTalep.TalepKonusu; 
                guncellenecekTalep.TalepAciklama = guncelTalep.TalepAciklama; 
                guncellenecekTalep.DegerlendirmeZamani = guncelTalep.DegerlendirmeZamani; 
                guncellenecekTalep.TalepDegerlendirmesi = guncelTalep.TalepDegerlendirmesi;
                
                //bool properties
                guncellenecekTalep.Degerlendirildimi = guncelTalep.Degerlendirildimi;
                guncellenecekTalep.olumluOlumsuz = guncelTalep.olumluOlumsuz;

                talepContext.SaveChanges();
            }
        }

        public void TalepSil(int ID)
        {
            using (var talepContext = new TalepContext())
            {
                //var silinecekTalep = TalebiGetir(ID); //Bu şekilde bulunca "Remove" metodu exception veriyordu???
                var silinecekTalep = talepContext.Talepler.Where(t => t.TalepId == ID).FirstOrDefault();
                talepContext.Talepler.Remove(silinecekTalep);
                talepContext.SaveChanges();

            }
        }
    }
}
