using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvmDataBase.Models
{
    public class Users
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int AccessLevel { get; set; }
    }
}
