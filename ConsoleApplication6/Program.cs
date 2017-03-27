using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "----------------------------------------------------------------------------------";
            string Time = "|      Time          |", Tech = "|       Tech        |", Room_Number = "|     Room_Number  ||", Name_Of_lucture = "    lucture      |";
            string lucture_WEB = "      Web        |", lucture_Data = "  Data Structor  |", lecture_VB = "  Visual Basic   |", lecture_Lab_WEB = "    Web Lab      |", lecture_Archeology_and_Tourism = "   Archeology    |";

            Console.WriteLine(str);
            Console.Write(Name_Of_lucture, "    |      ");    Console.Write(Time,"    |   ");        Console.Write(Tech, "    |   ");         Console.WriteLine(Room_Number, "       |");
            Console.WriteLine(str);
            Console.WriteLine(str);
           
            Console.Write(lucture_WEB);            Console.Write("|    8:00 - 9:30     |");       Console.Write("|  Yousef AL-Kilany ||");      Console.WriteLine(" IT  201 Floor 2  ||");
            Console.WriteLine(str);

            Console.Write(lucture_Data); Console.Write("|    9:30 - 11:00    |"); Console.Write("|    Sary Awwad     ||"); Console.WriteLine(" IT  101 Floor 1  ||");
            Console.WriteLine(str);

            Console.Write(lecture_VB); Console.Write("|    11:00 - 12:30   |"); Console.Write("|  Mohsen Al-Khaldi ||"); Console.WriteLine(" IT  103 Floor 1  ||");
            Console.WriteLine(str);

            Console.Write(lecture_Lab_WEB); Console.Write("|   12:30 - 1:30     |"); Console.Write("|    Doha-Qtyshat   ||"); Console.WriteLine(" IT  306 Floor 3  ||");
            Console.WriteLine(str);

            Console.Write(lecture_Archeology_and_Tourism); Console.Write("|   14:00 - 15:30    |"); Console.Write("| Nesren Al-Tarawneh||"); Console.WriteLine("(East)106 Floor 1 ||");
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
