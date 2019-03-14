using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TalepWebUygulamasi.Entities;

namespace TalepWebUygulamasi.Services
{
    public class LoginIslemler
    {
        public bool IsValid(HUser user)
        {
            return (user.UserName == "test" && user.Password == "test");
        }
    }
}
