using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using Administratie_Programma;


UserManager userManager = new UserManager();
ClientManagement clientManagement = new ClientManagement();
ClientInfo clientInfo = new ClientInfo();
OrderManager orderManager = new OrderManager();


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
    Console.WriteLine("4. Afsluiten");
    Console.Write("Keuze: ");
    string keuze = Console.ReadLine()?.ToLower();
    Console.Clear();

    if (keuze == "1")
    {
        clientManagement.ManageClients();
    }
    else if (keuze == "2")
    {
        ClientInfo.ClientInformatie();
    }
    else if (keuze == "3")
    {
        orderManager.ManageOrders();
    }
    else if (keuze == "4")
    {
        return;
    }
    else
    {
        Console.WriteLine("Kies tussen 1, 2, 3, 4, 5");
    }
}
public static class ClientData
{
    public static List<Client> Clients { get; } = new List<Client>();
}


