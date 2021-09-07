using System;

namespace PositiveNegative
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub sisestada numbrit
            //programm kontrollib numbrit
            //kui number on positiivne, konsool kuvab "number on positiivne"
            //kui number on negatiivne, konsool kuvab "number on negatiivne"
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (number > 0)
            {
                Console.WriteLine("the number is positive");

            }
            else
            {
                Console.WriteLine("the number is 0");
                    }
        }
    }
}
