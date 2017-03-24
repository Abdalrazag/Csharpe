using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


            float f1 = 1F / 3;
            double l1 = 1D / 3;
            decimal D1 = 1M / 3;

            Console.WriteLine("float value ="+f1 + "double l1 ="+l1 + "decimal ="+D1);

            Console.WriteLine("\n float  = {0}\n double = {1}\n decimal = {2}\n",f1 , l1 , D1);

            Console.ReadKey();


        }
    }
}
