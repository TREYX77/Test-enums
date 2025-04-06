using System;
using System.Collections.Generic;
using Administratie_Programma;

namespace Administratie_Programma;

internal class ClientInfo
{
    public static void ClientInformatie()
    {

        Console.Clear();
        Console.WriteLine("Klant info");
        Thread.Sleep(2000);


        if (ClientData.Clients.Count == 0)
        {
            Console.WriteLine("Geen klanten gevonden.");
        }
        else
        {
            foreach (var client in ClientData.Clients)
            {
                Console.WriteLine($"Voornaam: {client.Voornaam}, Achternaam: {client.Achternaam}, Adres: {client.Adres}, Telefoonnummer: {client.Telefoonnummer}");
            }
        }

        Console.WriteLine("Druk op een toets om terug te gaan...");
        Console.ReadKey();
    }
}

 

