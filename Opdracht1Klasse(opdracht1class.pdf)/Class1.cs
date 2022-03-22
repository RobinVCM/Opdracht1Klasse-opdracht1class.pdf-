using System;
using System.Collections.Generic;
using System.Text;

class Leerling
{
    private string strVoornaam;
    private string strNaam;
    private string strKlas;

    public string Voornaam
    {
        get { return strVoornaam; }
        set { strVoornaam = value; }
    }
    public string Naam
    {
        get { return strNaam; }
        set { strNaam = value; }
    }
    public string Klas
    {
        get { return strKlas; }
        set { strKlas = value; }
    }
    public Leerling()
    {
        strVoornaam = "";
        strNaam = "";
        strKlas = "";
    }
    public static void GegevensWeergeven(Leerling lln)
    {
        Console.WriteLine("___________________________");
        Console.WriteLine("\nNog eens overlopen:");
        Console.WriteLine($"Voornaam: {lln.strVoornaam} ");
        Console.WriteLine($"Naam: {lln.strNaam} ");
        Console.WriteLine($"Klas: {lln.strKlas} ");

    }

    public static void AanvullenGegevens(Leerling lln)
    {

        Console.WriteLine("Voornaam:");
        lln.strVoornaam = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Naam:");
        lln.strNaam = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Klas:");
        lln.strKlas = Convert.ToString(Console.ReadLine());
    }

}