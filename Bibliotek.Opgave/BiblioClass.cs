
namespace Bibliotek.Opgave
{
    public class BiblioClass
    {
        string _bibliotekNavn;

        public BiblioClass(string bibliotekNavn)
        {
            _bibliotekNavn = bibliotekNavn;
        }

        public string HentBibliotek() => String.Format($"Velkommen til {_bibliotekNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}");
    }
}
