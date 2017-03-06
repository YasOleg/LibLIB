using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApplication
{
    public class Users
    {
        public int Id { get; set; }

        public string LoginName { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
