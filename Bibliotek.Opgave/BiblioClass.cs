﻿
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
        public string HentBibliotek() => String.Format($"Velkommen til {_bibliotekNavn} - datoen i dag er: {DateTime.Now.ToShortDateString()}");

        public string OpretLaaner(string navn, string email)
        {
            Laaner laaner = new Laaner(++_laanerNummer, navn, email);
            _laaners.Add(laaner);
            return String.Format($"\nLåner oprettet\nLånernummer: {laaner.LaanerNummer}\nNavn: {laaner.Navn}\nEmail: {laaner.Email}");
        }

        public string HentAlleLaaner()
        {
            string laaners = "";
            if (_laaners.Count > 0)
            {
                foreach (var item in _laaners)
                {
                    laaners += $"Lånernummer: {item.LaanerNummer}\nNavn: {item.Navn}\nEmail: {item.Email}";
                }
                return laaners;
            }
            else
                return "Error: Ingen personer oprettet";
        }

        public string HentLaanerById(int id)
        {
            if (_laaners.Count > 0)
            {
                Laaner? returnLaaner = _laaners.Find(x => x.LaanerNummer == _laanerNummer);
                if (returnLaaner != null)
                {
                    string returnTekst = $"Lånernummer: {returnLaaner.LaanerNummer}\nNavn: {returnLaaner.Navn}\n" +
                        $"Email: {returnLaaner.Email}\n";
                }
                return $"\nIngen bruger fundet med lånenummer {id}";
            }
            else
                return "Der er ikke oprettet nogle bruger i system";
        }
        #endregion

        #region ClearMethods
        public void Clear()
        {
            Console.WriteLine("Tryk på noget hvis du vil forsæt.");
            Console.ReadKey();
            Console.Clear();
        }

        public bool ForsætValg()
        {
            string? forsæt;
            bool loop = true;
            Console.Write("Vil du forsæt? j/n: ");
            forsæt = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(forsæt))
            {
                if (forsæt.ToUpper() == "N" || forsæt.ToUpper() == "NEJ")
                {
                    return loop = false;
                    Console.Clear();
                }
            }
            Console.Clear();
            return loop;
        }
        #endregion
    }
}
