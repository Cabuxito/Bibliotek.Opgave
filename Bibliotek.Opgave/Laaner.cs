using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek.Opgave
{
    public class Laaner : Person
    {
        public int LaanerNummer { get; init; }

        public Laaner(int laanerNummer, string navn, string email)
        {
            LaanerNummer = laanerNummer;
            Navn = navn;
            Email = email;
        }
    }
}
