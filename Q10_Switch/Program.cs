using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            string What_He_Say = "Hello";

            switch (What_He_Say)
            {

               case "hello":

                   Console.WriteLine("Hellow"); break;

               case "Bye":

                    Console.WriteLine("Bye"); break;

               case "Welcome":

                    Console.WriteLine("Welcome"); break;

               default:

                    Console.WriteLine("No One"); break;

            }

            Console.ReadKey();
        }
    }
}
