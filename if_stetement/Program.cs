using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_stetement
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10, var2 = 6, var3 = 8;

            if (var1 == 10)
            {
                if ((var2 >= 5) && (var3 <= 9)) {

                    Console.WriteLine("تحقق الشرط");
                }
                else
                {
                    Console.WriteLine("لم يتحقق الشرط الثاني");
                }
            }// if

            else

            {
                Console.WriteLine("لم يتحقق الشرط الاول");
            }// else

            Console.ReadKey();

        }
    }
}
