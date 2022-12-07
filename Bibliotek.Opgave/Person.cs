using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek.Opgave
{
    public class Person
    {
        string _navn;
        string _email;
        public string Navn
        {
            get
            {
                return _navn;
            }
            set
            {
                _navn = value;
            }
        }
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
    }
}
