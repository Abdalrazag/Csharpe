using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Programe
    {
        static void Main(string[] args)
        {
            /*
            int max_Char = Char.MaxValue;
            int min_Char = Char.MinValue;

            char value = 'G';

            int ch = 'a';

            char conv = Convert.ToChar(97);

            Console.WriteLine("\n Max value of Char = {0}\n Min value of Char = {1}\n value of variable value = {2}\n value of a = {3}\n asscicode of 97 = {4}",
                               max_Char,min_Char,value,ch,conv);
          

            String name = "\n \n This is My Programe";

            Console.WriteLine(name);

    */

            char A = 'A';
            char a = 'a';


            String Value_of_A = "This is my Charectour value of = ";
            String Value_of_a = "This is my Charectour value of = ";

            Console.WriteLine(Value_of_A + Convert.ToInt16(A));
            Console.WriteLine(Value_of_a + Convert.ToInt16(a));

            Console.WriteLine(Value_of_A + "" + Convert.ToInt16(A) + "\n" + Value_of_a + "" + Convert.ToInt16(a));

            Console.ReadKey();





        }//main
    }//class
}//namespace
