﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace Administratie_Programma
{
    internal class UserManager
    {
        private Dictionary<string, string> users = new Dictionary<string, string>();

        public void Register()
        {
            Console.WriteLine("Registreren");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Clear();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Registratie laadt...");
            Thread.Sleep(1300);

            if (!users.ContainsKey(username))
            {
                users.Add(username, password);
                Console.WriteLine("Registratie succesvol!");
            }
            else
            {
                Console.WriteLine("Gebruikersnaam bestaat al.");
            }
            Thread.Sleep(900);
            Console.Clear();
        }

        public bool Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Clear();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.Clear();

            if (users.ContainsKey(username) && users[username] == password)
            {
                Console.WriteLine("Inloggen succesvol!");
                Thread.Sleep(900);
                Console.Clear();
                return true;
            }
            else
            {
                Console.WriteLine("Username/password incorrect");
                Thread.Sleep(1300);
                Console.Clear();
                return false;
            }
        }
    }
}
