using System;

namespace Opdracht1Klasse_opdracht1class.pdf_
{
    class Program
    {
        static void Main(string[] args)
        {
            Leerling lln = new Leerling();
            Leerling.AanvullenGegevens(lln);
            Leerling.GegevensWeergeven(lln);

        }


    }
}
