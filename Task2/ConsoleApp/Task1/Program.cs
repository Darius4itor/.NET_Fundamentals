using System;
using Helpers;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine(StringHelper.GetGreatings(username));
        }
    }
}
