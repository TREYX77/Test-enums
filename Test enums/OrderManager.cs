using System;
using System.Collections.Generic;

namespace Administratie_Programma
{
    internal class OrderManager
    {
        private List<string> orders = new List<string>();

        public void ManageOrders()
        {
            while (true)
            {
                Console.WriteLine("Bestelbeheer");
                Console.WriteLine("1. Bestelling toevoegen");
                Console.WriteLine("2. Bestelling verwijderen");
                Console.WriteLine("3. Bestellingen weergeven");
                Console.WriteLine("4. Terug naar hoofdmenu");
                Console.Write("Keuze: ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        AddOrder();
                        break;
                    case "2":
                        RemoveOrder();
                        break;
                    case "3":
                        ShowOrders();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Ongeldige keuze.");
                        break;
                }
            }
        }

        private void AddOrder()
        {
            Console.Write("Voer bestelling in: ");
            string order = Console.ReadLine();
            orders.Add(order);
            Console.WriteLine("Bestelling toegevoegd!");
        }

        private void RemoveOrder()
        {
            Console.Write("Voer de bestelling in om te verwijderen: ");
            string order = Console.ReadLine();
            if (orders.Remove(order))
            {
                Console.WriteLine("Bestelling verwijderd!");
            }
            else
            {
                Console.WriteLine("Bestelling niet gevonden.");
            }
        }

        private void ShowOrders()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("Geen bestellingen beschikbaar.");
                return;
            }
            Console.WriteLine("Lijst met bestellingen:");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
