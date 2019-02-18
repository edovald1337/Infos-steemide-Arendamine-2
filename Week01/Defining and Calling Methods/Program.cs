using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            DisplayResult(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));


            Console.ReadLine();
            
        }

        private static string ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName, string reversedCity)
        {
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write(message);
        }
    }
}
