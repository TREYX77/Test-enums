using System;
using System.Collections.Generic;
using System.Threading;
using Administratie_Programma;

UserManager userManager = new UserManager();
ClientManager clientManagement = new ClientManager();
OrderManager orderManager = new OrderManager();
InvoiceManager invoiceManager = new InvoiceManager();

while (true)
{
    Console.WriteLine("Welkom bij het administratie programma!");
    Console.WriteLine("Wat wilt u doen?");
    Console.WriteLine("1. Inloggen");
    Console.WriteLine("2. Registreren");
    Console.WriteLine("3. Afsluiten");
    Console.Write("Keuze: ");
    string keuzeMenu = Console.ReadLine()?.ToLower();
    Console.Clear();

    if (keuzeMenu == "1")
    {
        if (userManager.Login())
        {
            Console.Clear();
            break;
        }
    }
    else if (keuzeMenu == "2")
    {
        Console.Clear();
        userManager.Register();
    }
    else if (keuzeMenu == "3")
    {
        Console.Clear();
        return;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Kies tussen 1, 2, 3");
    }
}

while (true)
{
    Console.WriteLine("Welkom bij het administratie programma!");
    Console.WriteLine("Wat wilt u doen?");
    Console.WriteLine("1. Klanten beheren");
    Console.WriteLine("2. Klant info");
    Console.WriteLine("3. Bestellingen beheren");
    Console.WriteLine("4. Facturen beheren");
    Console.WriteLine("5. Afsluiten");
    Console.Write("Keuze: ");
    string keuze = Console.ReadLine()?.ToLower();
    Console.Clear();

    switch (keuze)
    {
        case "1":
            clientManagement.ManageClients();
            break;
        case "2":
            clientManagement.ShowClientInfo();
            break;
        case "3":
            orderManager.ManageOrders();
            break;
        case "4":
            invoiceManager.ManageInvoices();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Kies tussen 1, 2, 3, 4, 5");
            break;
    }
}

namespace Administratie_Programma
{
    internal class InvoiceManager
    {
        internal void ManageInvoices()
        {
            throw new NotImplementedException();
        }
    }
}

internal class ClientManager
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    internal void ManageClients()
    {
        // Implementation here
    }
    internal void ShowClientInfo()
    {
        // Implementation here
    }
}
