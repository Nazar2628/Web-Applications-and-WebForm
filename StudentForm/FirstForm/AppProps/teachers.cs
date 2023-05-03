using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppProps
{
    public class teachers
    {
        string tid, name, email, password, age, university, degree;

        public string Tid { get => tid; set => tid = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Age { get => age; set => age = value; }
        public string University { get => university; set => university = value; }
        public string Degree { get => degree; set => degree = value; }
    }
}
