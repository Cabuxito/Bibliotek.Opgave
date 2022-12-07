using Bibliotek.Opgave;
using System.Data;
using System.Xml.XPath;


bool loop = true;
ConsoleKeyInfo input;
BiblioClass myBiblio = new BiblioClass("Sønderborg Bibliotek");
do
{
    Console.Write("V- Vis Bibliotekkekts navn og dato\nO- Opret Låner\nU- Udskriv Låner\nX- Afslut\nValg: ");
    input = Console.ReadKey(true);
    Console.Clear();
    switch (input.Key)
    {
        case ConsoleKey.V:
            Console.WriteLine(myBiblio.HentBibliotek());
            break;
        case ConsoleKey.O:
            do
            {
                Console.Write("Navn: ");
                string? navn = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(navn))
                {
                    myBiblio.OpretLaaner(navn);
                }
            } while (myBiblio.ForsætValg());
            break;
        case ConsoleKey.U:
            Console.WriteLine(myBiblio.HentAlleLaaner());
            myBiblio.ForsætValg();
            break;
        case ConsoleKey.X:
            loop = false;
            break;
        default:
            break;
    }

} while (loop);
