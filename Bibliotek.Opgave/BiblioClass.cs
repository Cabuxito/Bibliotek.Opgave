
namespace Bibliotek.Opgave
{
    public class BiblioClass
    {
        string _bibliotekNavn;
        List<Laaner> myLaaner = new();

        public BiblioClass(string bibliotekNavn)
        {
            _bibliotekNavn = bibliotekNavn;
        }

        public string HentBibliotek() => String.Format($"Velkommen til {_bibliotekNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}");

        public void OpretLaaner(int lannerNummer, string navn)
        {
           myLaaner.Add(new Laaner (lannerNummer, navn));
        }

        public List<Laaner> HentAlleLaaner()
        {
            return myLaaner;
        }
    }
}
