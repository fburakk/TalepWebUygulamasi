using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepWebUygulamasi.DAL;
using TalepWebUygulamasi.Entities;

namespace TalepWebUygulamasi.Services
{
    public class KullaniciIslemler
    {
        //public List<Talep> TalepleriGetir()
        //{
        //    using (var talepContext = new TalepContext())
        //    {
        //        return talepContext.Talepler.ToList();
        //    }
        //}

        public HUser KullaniciyiGetir(string userName)
        {
            using (var talepContext = new TalepContext())
            {
                return talepContext.Kullanıcılar.Find(userName);
            }
        }

        //public void TalepEkle(Talep talep)
        //{
        //    using (var talepContext = new TalepContext())
        //    {
        //        talepContext.Talepler.Add(talep);
        //        talepContext.SaveChanges();
        //    }
        //}

        //public void TalepGuncelle(Talep guncelTalep)
        //{
        //    using (var talepContext = new TalepContext())
        //    {
        //        var guncellenecekTalep = talepContext.Talepler.Find(guncelTalep.TalepId);
        //        guncellenecekTalep.TalepKonusu = guncelTalep.TalepKonusu;
        //        guncellenecekTalep.TalepAciklama = guncelTalep.TalepAciklama;
        //        talepContext.SaveChanges();
        //    }
        //}

        //public void TalepSil(int ID)
        //{
        //    using (var talepContext = new TalepContext())
        //    {
        //        //var silinecekTalep = TalebiGetir(ID); //Bu şekilde bulunca "Remove" metodu exception veriyordu???
        //        var silinecekTalep = talepContext.Talepler.Where(t => t.TalepId == ID).FirstOrDefault();
        //        talepContext.Talepler.Remove(silinecekTalep);
        //        talepContext.SaveChanges();

        //    }
        //}
    }
}
