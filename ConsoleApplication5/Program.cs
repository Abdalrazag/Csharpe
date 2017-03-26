using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            //     int a = 2;
            //    int temp = a++;
            /*
            Console.WriteLine(a);
            Console.WriteLine(temp);
            Console.ReadKey();
            */
            double var1 = 7.0; double var2 = 2.0;
            double temp2 = var1; double temp3 = var2;
            double temp = var1--/++var2;

            Console.WriteLine(var1);
            Console.WriteLine(var2);

            Console.WriteLine(temp);

            Console.ReadKey();

        }

    }
}
