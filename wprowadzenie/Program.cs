// See https://aka.ms/new-console-template for more information

using wprowadzenie.Klasy;
using wprowadzenie.osoby;

string sciezkaXML = Path.Combine(AppContext.BaseDirectory, "osoby.xml");
string sciezkaXSD = Path.Combine(AppContext.BaseDirectory, "osoby.xsd");

var uczestnicy = XmlManager.DeseralizujXML<Uczestnicy>(sciezkaXML, sciezkaXSD);

foreach (var osoba in uczestnicy.ListaOsob)
{
    Console.WriteLine($"{osoba.Nazwisko} {osoba.Imie}");
    Console.WriteLine("Kierunek: " + osoba.Kierunek);
    Console.WriteLine("Stypendium: " + osoba.Stypendium);
    Console.WriteLine("Dojazd: " + osoba.Dojazd);
    Console.Write("Przedmioty: ");
    foreach (var przedmiot in osoba.Przedmioty)
    {
        Console.WriteLine($"{przedmiot.Nazwa} {przedmiot.IleGodzin}, ");

    }
    Console.WriteLine("\n\n----------------------------------------------------");
}
Console.ReadKey();
