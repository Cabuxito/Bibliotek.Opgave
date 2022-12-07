using Bibliotek.Opgave;

BiblioClass myBiblio = new BiblioClass("Sønderborg Bibliotek");

Console.WriteLine(myBiblio.HentBibliotek());

myBiblio.OpretLaaner(1,"brian");
Console.WriteLine(myBiblio.HentLaaner());
