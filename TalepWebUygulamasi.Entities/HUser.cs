using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalepWebUygulamasi.Entities
{
    public class HUser
    {
        [Key]
        public string UserName { get; set; }

        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public string email { get; set; }
        //public string Role { get; set; }
        public string Password { get; set; }
    }
}
