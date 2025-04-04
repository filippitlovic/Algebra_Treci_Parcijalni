
using Ispit.Konzola;
using System.ComponentModel.DataAnnotations;
using Ispit.Konzola.Interfaces;

public class Program
{
    public static void TestirajTelefon(IPametniTelefon pametniTelefon)
    {
        Console.WriteLine("Unesite broj telefona:");
        var unosBroj = Console.ReadLine();
        Console.WriteLine("Unesite URL:");
        var unosUrl = Console.ReadLine();

        ITelefon telefon = pametniTelefon as ITelefon;

        var validiranBroj = telefon.Poziv(unosBroj);
        var validiranUrl = pametniTelefon.Surfanje(unosUrl);

        Console.WriteLine(validiranBroj);
        Console.WriteLine(validiranUrl);
    }

    public static void Main(string[] args)
    {
        // Kreiraj objekt pametnog telefona
        PametniTelefon telefon = new PametniTelefon("Iphone"); 

        // Testiraj telefon
        TestirajTelefon(telefon);
    }

}