using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepWebUygulamasi.DAL;
using TalepWebUygulamasi.Entities;

namespace TalepWebUygulamasi.Services
{
    public class LoginIslemler
    {
        TalepContext context = new TalepContext();
        public bool IsValid(HUser user)
        {
            var foundUser = context.Kullanıcılar.Find(user.UserName);
            return (user.UserName == foundUser.UserName && user.Password == foundUser.Password);
        }

        public bool saveUser(HUser user)
        {
            try
            {
                context.Kullanıcılar.Add(user);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

            
        }
    }
}
