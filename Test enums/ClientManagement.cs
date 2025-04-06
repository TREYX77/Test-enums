using System;
using System.Collections.Generic;
using System.Threading;
using Administratie_Programma;

namespace Administratie_Programma
{
    internal class ClientManagement
    {


        public void ManageClients()
        {
            while (true)
            {
                
                Console.WriteLine("Klanten beheren");
                Thread.Sleep(500);
                
                Console.WriteLine("1. Klant toevoegen");
                Console.WriteLine("2. Klant verwijderen");
                Console.WriteLine("3. Klant bewerken");
                Console.WriteLine("4. Terug");
                Console.Write("Keuze: ");
                string keuze = Console.ReadLine();
                Console.Clear();

                switch (keuze)
                {
                    case "1":
                        AddClient();
                        break;
                    case "2":
                        RemoveClient();
                        break;
                    case "3":
                        EditClient();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        Thread.Sleep(900);
                        
                        break;
                }
            }
        }

        private static void AddClient()
        {
            Console.Write("Voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Clear();
            Console.Write("Achternaam: ");
            string achternaam = Console.ReadLine();
            Console.Clear();
            Console.Write("Adres: ");
            string adres = Console.ReadLine();
            Console.Clear();
            Console.Write("Telefoonnummer: ");
            string telefoonnummer = Console.ReadLine();
            ClientData.Clients.Add(new Client { Voornaam = voornaam, Achternaam = achternaam, Adres = adres, Telefoonnummer = telefoonnummer });
            Console.Clear();
            Console.WriteLine("Klant succesvol toegevoegd!");
            Thread.Sleep(900);
            Console.Clear();
        }

        private static void RemoveClient()
        {
            Console.Write("Voornaam van klant om te verwijderen: ");
            string voornaam = Console.ReadLine();
            ClientData.Clients.RemoveAll(c => c.Voornaam == voornaam);
            Console.Clear();
            Console.WriteLine("Klant verwijderd!");
            Thread.Sleep(900);
            Console.Clear();
        }

        private static void EditClient()
        {
            Console.Write("Voornaam van de klant die u wilt bewerken: ");
            string voornaam = Console.ReadLine();
            Client client = ClientData.Clients.Find(c => c.Voornaam == voornaam);
            Console.Clear();

            if (client != null)
            {
                Console.Write("Nieuwe voornaam: ");
                client.Voornaam = Console.ReadLine();
                Console.Clear();
                Console.Write("Nieuwe achternaam: ");
                client.Achternaam = Console.ReadLine();
                Console.Clear();
                Console.Write("Nieuw adres: ");
                client.Adres = Console.ReadLine();
                Console.Clear();
                Console.Write("Nieuw telefoonnummer: ");
                client.Telefoonnummer = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Klantgegevens bijgewerkt!");
                Thread.Sleep(900);
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Klant niet gevonden.");
                Thread.Sleep(900);
                Console.Clear();
            }
        }
    }

    public class Client
    {
        public string? Voornaam { get; set; }
        public string? Achternaam { get; set; }
        public string? Adres { get; set; }
        public string? Telefoonnummer { get; set; }
    }
}
