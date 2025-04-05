using System;
using System.Collections.Generic;
using System.Threading;

namespace Administratie_Programma
{
    public class clientManager
    {
        private List<Client> clients = new List<Client>();

        internal void ManageClients()
        {
            ClientManagement();
        }

        private void ClientManagement()
        {
            Console.Clear();
            Console.WriteLine("Klanten beheren");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("1. Klant toevoegen");
            Console.WriteLine("2. Klant verwijderen");
            Console.WriteLine("3. Klant bewerken");
            Console.WriteLine("4. Terug");
            Console.Write("Keuze: ");
            string keuze = Console.ReadLine() ?? string.Empty;
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
                    Console.Clear();
                    break;
            }
        }

        private void AddClient()
        {
            Console.Write("Voornaam: ");
            string voornaam = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            Console.Write("Achternaam: ");
            string achternaam = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            Console.Write("Adres: ");
            string adres = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            Console.Write("Telefoonnummer: ");
            string telefoonnummer = Console.ReadLine() ?? string.Empty;
            clients.Add(new Client { Voornaam = voornaam, Achternaam = achternaam, Adres = adres, Telefoonnummer = telefoonnummer });
            Console.Clear();
            Console.WriteLine("Klant succesvol toegevoegd!");
            Thread.Sleep(900);
            Console.Clear();
        }

        private void RemoveClient()
        {
            Console.Write("Voornaam van klant om te verwijderen: ");
            string voornaam = Console.ReadLine() ?? string.Empty;
            clients.RemoveAll(c => c.Voornaam == voornaam);
            Console.Clear();
            Console.WriteLine("Klant verwijderd!");
            Thread.Sleep(900);
            Console.Clear();
        }

        private void EditClient()
        {
            Console.Write("Voornaam van de klant die u wilt bewerken: ");
            string voornaam = Console.ReadLine() ?? string.Empty;
            Client client = clients.Find(c => c.Voornaam == voornaam);
            Console.Clear();

            if (client != null)
            {
                Console.Write("Nieuwe voornaam: ");
                client.Voornaam = Console.ReadLine() ?? string.Empty;
                Console.Clear();
                Console.Write("Nieuwe achternaam: ");
                client.Achternaam = Console.ReadLine() ?? string.Empty;
                Console.Clear();
                Console.Write("Nieuw adres: ");
                client.Adres = Console.ReadLine() ?? string.Empty;
                Console.Clear();
                Console.Write("Nieuw telefoonnummer: ");
                client.Telefoonnummer = Console.ReadLine() ?? string.Empty;
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
        public string? Voornaam { get; internal set; }
        public string? Achternaam { get; internal set; }
        public string? Adres { get; internal set; }
        public string? Telefoonnummer { get; internal set; }
    }
}
