using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja lemmikvärvi
            //kui kasutaja sisestab "punane" siis konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine" siis konsool kuvab "oled töökas"
            //kui kasutaja sisestab "roheline" siis konsool kuvab "oled looduse sõber"
            //kui kasutaja sisestab midagi muud siis konsool kuvab "oled ükssarvik"
            Console.WriteLine("mis on su lemmikvärv?");
            string UserColor = Console.ReadLine().ToLower();
            if (UserColor == "punane")
            {
                Console.WriteLine("oled romantiline");
            }
            else if(UserColor == "sinine")
            {
                Console.WriteLine("oled töökas");
            }
            else if(UserColor == "roheline")
            {
                Console.WriteLine("oled looduse sõber");

            }
            else
            {
                Console.WriteLine("Oled ükssarvik");
            }
        }
    }
}
