using System;

namespace EpicDiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat
            //iga mängija viskab täringut (1-6)
            //programm kuvab nende visete tulemused ja kuvab ka, kes on võitja
            // ehk kes viskas suuremat

            Random rnd = new Random();

            string playerOne = "Harry Potter";
            string playerTwo = "Voldemort";

            int HarryThrow = rnd.Next(1, 7);
            int VoldemortThrow = rnd.Next(1, 7);

            Console.WriteLine($"{playerOne} threw {HarryThrow};");
            Console.WriteLine($"{playerTwo} threw {VoldemortThrow};");




            if (HarryThrow > VoldemortThrow)
            {
                Console.WriteLine($"{playerOne} Wins!");
            }
            else if (HarryThrow < VoldemortThrow)
            {
                Console.WriteLine($"{playerTwo} Wins!");
            }
            else
            {
                Console.WriteLine("Draw! let them try again.");
            }









        }
    }
}
