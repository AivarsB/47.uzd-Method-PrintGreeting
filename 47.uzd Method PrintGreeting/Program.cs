using System;

namespace _47.uzd_Method_PrintGreeting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                PrintGreeting();
            }
        }

        private static void PrintGreeting()
        {
            Console.WriteLine("Hello World");
        }
    }
}
// Definēt metodi PrintGreeting, kura console izdrukā tekstu “Hello Wordl!”. Izdrukāt šo sveicienu 3 reizes.
