using GuestBookLibrary.Models;
using System;
using System.Collections.Generic;


namespace ConsoleUI
{
    class Program
    {
        private static List<GuestModel> guests = new List<GuestModel>();

        static void Main(string[] args)
        {

            GetGuestInformation();

            PrintGuestInformation();

            Console.ReadLine();
        }

        private static void GetGuestInformation()
        {
            // Capture the information about each guest (assumption is at least one guest and unknown maximum)
            // Info to capture: First name, last name, message to the host
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guests coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();

            } while (moreGuestsComing.ToLower() == "yes");
        }

        private static string GetInfoFromConsole(string message)
        {
            string output = "";

            Console.Write(message);
            output = Console.ReadLine();

            return output;
        }

        private static void PrintGuestInformation()
        {
            // Once done, loop through each guest and print their info
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }

        }
    }
}
