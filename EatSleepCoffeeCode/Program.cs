using System;

namespace EatSleepCoffeeCode
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("|CODING CYCLE| Eat(); Sleep(); Coffee(); Code();\n");
            Program pizzaSlices = new Program();
            Console.WriteLine($"\n|SLICES| Number of slices per coding cycle: { pizzaSlices.Eat()}");

        }

        public int Eat()
        {
            bool alive = true;
            int numberOfPizzaSlicesEaten = 2;

            while(alive)
            {
                Console.WriteLine("Eating Fire on the Mountain Pizza... NOM NOM NOM :o :| :o :| :o :|");
                alive = false;
            }

            return numberOfPizzaSlicesEaten;

        }

    }
}
