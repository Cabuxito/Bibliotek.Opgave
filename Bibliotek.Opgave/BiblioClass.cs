
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Bibliotek.Opgave
{
    public class BiblioClass
    {
        string _bibliotekNavn;
        List<Laaner> _laaners = new();
        int _laanerNummer;


        public BiblioClass(string bibliotekNavn)
        {
            _bibliotekNavn = bibliotekNavn;
        }

        #region Methoder
        /// <summary>
        /// Hent biblioteks navn og i dags dato.
        /// </summary>
        /// <returns>string der indholder navn og dato.</returns>
        public string HentBibliotek() => String.Format($"Velkommen til {_bibliotekNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}\n\n");
        /// <summary>
        /// Opret ny laaner.
        /// </summary>
        /// <param name="navn"></param>
        /// <param name="email"></param>
        public void OpretLaaner(string navn, string email)
        {
            Laaner laaner = new Laaner(++_laanerNummer, navn, email);
            _laaners.Add(laaner);
        }
        /// <summary>
        /// Henter alle laaner.
        /// </summary>
        /// <returns>string i table format, med laaners oplysninger.</returns>
        public string HentAlleLaaner()
        {
            string laaners = "";
            if (_laaners.Count > 0)
            {
                foreach (var item in _laaners)
                {
                    laaners += $"Lånernummer: {item.LaanerNummer}\nNavn: {item.Navn}\nEmail: {item.Email}\n\n";
                }
                return laaners;
            }
            else
                return "Error: Ingen personer oprettet";
        }
        /// <summary>
        /// Hent en laaner by laanernummer.
        /// </summary>
        /// <param name="laanerNummer"></param>
        /// <returns>string med en specifik brugers oplysninger.</returns>
        public string HentLaanerById(int laanerNummer)
        {
            if (_laaners.Count > 0)
            {
                Laaner? returnLaaner = _laaners.Find(x => x.LaanerNummer == laanerNummer);
                if (returnLaaner != null)
                {
                    string returnTekst = $"Lånernummer: {returnLaaner.LaanerNummer}\nNavn: {returnLaaner.Navn}\n" +
                        $"Email: {returnLaaner.Email}\n";
                    return returnTekst;
                }
                else
                    return $"\nIngen bruger fundet med lånenummer {laanerNummer}";
            }
            else
                return "Der er ikke oprettet nogle bruger i system";
        }

        public string SletLaanerById(int laanerNummer)
        {
            if (_laaners.Count > 0)
            {
                Laaner laaner = _laaners.Find(x => x.LaanerNummer == laanerNummer);
                _laaners.Remove(laaner);
                return $"\nBruger {laanerNummer} er blev slettet.";
            }
            else
                return "Der er ikke oprettet nogle bruger i system";
        }
        #endregion

        #region ClearMethods
        /// <summary>
        /// methoden kontrollere hvis man vil forsæt eller ej.
        /// </summary>
        /// <returns>nej = false | ja  = true</returns>
        public bool ForsætValg()
        {
            string? forsæt;
            bool loop = true;
            Console.Write("Prøv ingen? J/N: ");
            forsæt = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(forsæt))
            {
                if (forsæt.ToUpper() == "N" || forsæt.ToUpper() == "NEJ")
                {
                    Console.Clear();
                    return loop = false;
                }
            }
            Console.Clear();
            return loop;
        }
        #endregion
    }
}
