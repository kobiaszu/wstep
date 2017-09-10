﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Authorisation
    {
        private string Username;
        private string Password;
        private int MaxTries;


        public Authorisation()
        {
            Username = "admin";
            Password = "123";
            MaxTries = 5;
        }

        public Authorisation(string user, string pass, int max)
        {
            Username = user;
            Password = pass;
            MaxTries = max;
        }

        private bool compare ( string username, string password)
        {

            if (username.Equals(this.Username) && password.Equals(this.Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private string getString( string type)
        {
            string tray = "";
            bool check = false;
            do
            {
                if (check)
                    Console.WriteLine($"Pole {type} nie może być puste, spróbuj jeszcze raz: ");
                else
                    Console.WriteLine($"Podaj {type}:");
                tray = Console.ReadLine();
                check = true;
            } while (tray == "");

            return tray;
        } 

        public void login()
        {
            int counter = 0;
            bool result = false;
            do
            {
                result = compare(getString("uzytkownik"), getString("haslo"));
                if (result)
                    break;
                else
                    Console.WriteLine("Nie udalo sie, sprobuj jeszcze raz!");
                counter++;
            }
            while (counter <= MaxTries);

            if (result)
            {
                Console.WriteLine($"Zalogowano po {counter + 1} probach");
            }
            else
            {
                Console.WriteLine($"Przekroczono licznik {MaxTries} prob!");
            }

            
        }

    }
}