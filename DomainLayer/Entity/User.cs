using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entity
{
    public class User
    {
        public int userId {  get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }

    }
}
