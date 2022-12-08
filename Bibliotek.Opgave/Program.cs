using Bibliotek.Opgave;

bool loop = true;
ConsoleKeyInfo input;
BiblioClass myBiblio = new BiblioClass("Sønderborg Bibliotek");
do
{
    Console.Write("V- Vis Bibliotekkekts navn og dato\nO- Opret Låner\nU- Udskriv Låner\nF- Hent laaner by laanernummer\nX- Afslut\nValg: ");
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
                Console.Write("Email: ");
                string? email = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(navn) && !String.IsNullOrWhiteSpace(email))
                {
                    myBiblio.OpretLaaner(navn, email);
                }
            } while (myBiblio.ForsætValg());
            break;
        case ConsoleKey.U:
            Console.WriteLine(myBiblio.HentAlleLaaner());
            myBiblio.ForsætValg();
            break;
        case ConsoleKey.F:
            do
            {
                Console.Write("LaanerNummer: ");
                int laanerNummer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(myBiblio.HentLaanerById(laanerNummer));
            } while (myBiblio.ForsætValg());
            break;
        case ConsoleKey.X:
            loop = false;
            break;
        default:
            Console.WriteLine("Prøv igen.\n\n");
            break;
    }
} while (loop);
