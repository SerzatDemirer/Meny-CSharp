using System;

namespace Meny
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Ny uppgift");
                Console.WriteLine("2. Lista uppgifter");
                Console.WriteLine("3. Avsluta");
                Console.Write("Välj ett alternativ: ");

                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == '1')
                {
                    Console.WriteLine("Du valde \"Ny uppgift\"");
                }
                else if (choice == '2')
                {
                    Console.WriteLine("Du valde \"Lista uppgifter\"");
                }
                else if (choice == '3')
                {
                    Console.WriteLine("Applikationen avslutas.");
                    break;
                }
                else
                {
                    Console.WriteLine("Ogiltigt alternativ. Försök igen.");
                }

                Console.WriteLine("\nTryck på valfri knapp för att fortsätta...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
