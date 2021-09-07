using System;

namespace IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust
            //kui kasutaja on vanem kui 18, siis konsoolis kuvatakse "oled piisavalt vana"
            //kui kasutaja on noorem kui 18, siis konsoolis kuvatakse "oled liiga noor"
            //kui kasutaja on 18, siis konsoolis kuvatakse "oled 18"
            Console.WriteLine("How old are you?");
            int Age = Int32.Parse(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine("oled piisavalt vana");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Oled liiga noor");
            }
            else 
            {
                Console.WriteLine("Oled 18");
            }

            Console.WriteLine("Ilusat päeva!");

        }
    }
}
