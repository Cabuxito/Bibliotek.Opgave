using Bibliotek.Opgave;

BiblioClass myBiblio = new BiblioClass("Sønderborg Bibliotek");
myBiblio.OpretLaaner(1,"brian");
myBiblio.OpretLaaner(2,"Thomas");
myBiblio.OpretLaaner(3,"Max");

List<Laaner> myList = myBiblio.HentAlleLaaner();
Console.WriteLine(myBiblio.HentBibliotek());
foreach (var item in myList)
{
    Console.WriteLine($"Lånernummer: {item.LaanerNummer} - Navn: {item.Navn}");

}

