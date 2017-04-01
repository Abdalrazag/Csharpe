using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            double My_Salary = 1000.2, total=0.0;
            int i = 0;
            do
            {
                total += My_Salary;
                i++;
                Console.WriteLine("i values equal {0}", i);
            } while (i < 10);
                Console.WriteLine("Salary values equal {0}",total);
            Console.ReadKey();      


    */

            int Salary = 1020;
            int i=0;
            do
            {
                Salary +=20;
                i++;
                
                
            } while (Salary <= 2000);

            int year = i/12 , month = i%12;

            Console.WriteLine("The Salary need to Equal 2000 of {0}{1} and {2}{3}",year,"year",month,"month");

            Console.ReadKey();

        }
    }
}
