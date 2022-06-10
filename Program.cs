using System;

namespace Dice_Roll_Sim2
{
    class Program
    {
        static void Main(string[] args)
        {
            //WELCOME
            Console.Clear();
            Console.WriteLine("Welcome to the Dice Roll Simulator");
            // Create New Random Number
            Random rnd = new Random();

            

            //MENU
            bool loop = true;
            while (loop) {
                int numSnake = 0;
                //Input
                Console.WriteLine("Dice Roll Simulator Menu");
                Console.WriteLine("1. Roll Dice Once");
                Console.WriteLine("2. Roll dice 5 Times");
                Console.WriteLine("3. Roll Dice 'n' Times");
                Console.WriteLine("4. Roll Dice until Snake Eyes");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Select an option (1-5)");
                int choice1 = Convert.ToInt32(Console.ReadLine());
                // Logic and Output
                if (choice1 == 1) {
                    int randNum1 = rnd.Next(1, 7);
                    int randNum2 = rnd.Next(1, 7);
                    int sum = randNum1 + randNum2;
                    Console.WriteLine($"Your numbers are {randNum1} and {randNum2} (Sum:{sum})");

                } else if (choice1 == 2) {
                    for (int n = 1; n <= 5; n++) {
                    int randNum1 = rnd.Next(1, 7);
                    int randNum2 = rnd.Next(1, 7);
                    int sum = randNum1 + randNum2;
                    Console.WriteLine($"Your numbers are {randNum1} and {randNum2} (Sum:{sum})");
                    }

                } else if (choice1 == 3) {
                    Console.WriteLine("How many times would you like to roll?");
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    for (int n =1; n<=choice2; n++) {
                    int randNum1 = rnd.Next(1, 7);
                    int randNum2 = rnd.Next(1, 7);
                    int sum = randNum1 + randNum2;
                    Console.WriteLine($"Your numbers are {randNum1} and {randNum2} (Sum:{sum})");

                    }
                    
                } else if (choice1 == 4) {
                    bool rolls = true;
                    while (rolls) {
                    int randNum1 = rnd.Next(1, 7);
                    int randNum2 = rnd.Next(1, 7);
                    int sum = randNum1 + randNum2;
                    Console.WriteLine($"Your numbers are {randNum1} and {randNum2} (Sum:{sum})");
                    numSnake++;
                    if (randNum1 == 1 && randNum2 == 1) {
                        rolls = false;
                        Console.WriteLine($"SNAKE EYES! It took {numSnake} rolls to get snake eyes!");
                    }
                    }

                } else if (choice1 == 5) {
                    loop = false;
                    Console.WriteLine("Goodbye!!");
                }


            }
        }
    }
}
