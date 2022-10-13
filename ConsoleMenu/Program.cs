using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    internal class Program
    {
        private static string SIX = "6";
        static void Main(string[] args)
        {
            string userchoice = "";
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            while (!userchoice.Equals(SIX))
            {
                Console.WriteLine("1. Prime number\r\n2. Sum of digits\r\n3. Reverse a string\r\n4. Print HTML tags\r\n5. Sort 5 numbers\r\n6. Exit\r\n \r\rEnter your choice ");
                userchoice = Console.ReadLine();
                switch (userchoice)
                {
                    case "1":
                        Console.WriteLine("Please enter a number\n");
                        int num = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.PrimeNumber(num));
                        break;
                    case "2":
                        Console.WriteLine("Please enter a number\n");
                        int nums = int.Parse(Console.ReadLine());
                        Console.WriteLine(client.SumOfDigits(nums));
                        break;
                    case "3":
                        Console.WriteLine("Please enter a string\n");
                        string input = Console.ReadLine();
                        Console.WriteLine(client.ReverseString(input));
                        break;
                    case "4":
                        Console.WriteLine("Please enter a HTML tag\n");
                        string tag = Console.ReadLine();
                        Console.WriteLine("Please enter a string\n");
                        string data = Console.ReadLine();
                        Console.WriteLine(client.PrintHTMLTAGs(tag, data));
                        break;
                    case "5":
                        Console.WriteLine("Enter your sort type\n");
                        string sort = Console.ReadLine().ToLower();
                        Console.WriteLine("Enter your 5 numbers with commas\n");
                        string numbers = Console.ReadLine();
                        Console.WriteLine(client.SortNumbers(sort, numbers));
                        break;
                }
            }
        }
    }
}
