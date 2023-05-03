using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProps
{
    public class students
    {
        string sid;
        string name;
        string email;
        string password;
        string age;
        string university;
        string degree;

        public string Sid { get => sid; set => sid = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Age { get => age; set => age = value; }
        public string University { get => university; set => university = value; }
        public string Degree { get => degree; set => degree = value; }
    }
}
