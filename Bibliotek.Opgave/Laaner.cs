using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek.Opgave
{
    public class Laaner
    {
        public int LaanerNummer { get; init; }
        public string? Navn { get; init; }

        public Laaner(int laanerNummer, string navn)
        {
            LaanerNummer = laanerNummer;
            Navn = navn;
        }
    }
}
