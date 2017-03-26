using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           
            int a = 10 ;
            string My_result ;


            if (a > 10)
            {                       
                 My_result = "Greater than 10";
                 Console.WriteLine(My_result);
            }
          
            else if(a<10)
            {
                 My_result = "Less than 10";
                 Console.WriteLine(My_result);  
            }
               
            else if(a==10)
            {
            
               My_result = "equals 10";         
               Console.WriteLine(My_result);
            }

                */

            /*
            
           // Q1 :

            int variable = 8;
            string str;

            if (variable > 10)
            {
                str = "Greater than 10";
                Console.WriteLine(str);
            }

            else if (variable < 10)
            {
                str = "less than 10";
                Console.WriteLine(str);
            }

            Console.ReadKey();                         */


            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            int var1 = 11, var2 = 5, var3 = 8;


            bool result1 = ((var1 <= 11) || (var2 == 5) && (var3 >= 8)), result2 = ((var1 <= 11) || (var2 == 6) && (var3 >= 8));

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            Console.ReadKey();


        }// main

    }//class

}// name space
