
namespace Bibliotek.Opgave
{
    public class BiblioClass
    {
        string _bibliotekNavn;
        Laaner myLaaner;

        public BiblioClass(string bibliotekNavn)
        {
            _bibliotekNavn = bibliotekNavn;
        }

        public string HentBibliotek() => String.Format($"Velkommen til {_bibliotekNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}");

        public void OpretLaaner(int lannerNummer, string navn)
        {
           myLaaner = new(lannerNummer, navn);
        }

        public string HentLaaner()
        {
            return String.Format($"Lånernummer: {myLaaner.LaanerNummer} - Navn: {myLaaner.Navn} er låner hos {_bibliotekNavn}");
        }
    }
}
