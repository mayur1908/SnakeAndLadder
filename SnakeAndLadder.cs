using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public static void SnakeLadderSimulator()
        {
            int position = 0; // initial position
            Console.WriteLine("Welcome to Snake and Ladder game!");

            while (position < 100) // continue playing until position is 100 or more
            {
                Console.WriteLine("You are currently at position " + position);
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                // generate a random number between 1 and 6 for the dice roll
                Random random = new Random();
                int diceRoll = random.Next(1, 7);

                Console.WriteLine("You rolled a " + diceRoll);

                // generate a random number between 1 and 3 to determine the option
                int option = random.Next(1, 4);

                switch (option)
                {
                    case 1: // No Play
                        Console.WriteLine("No Play - You stay in the same position");
                        break;
                    case 2: // Ladder
                        int ladder = random.Next(1, 7); // generate a random number for the ladder position
                        Console.WriteLine("Ladder - You move ahead by " + ladder + " positions");
                        position += ladder; // update position based on ladder
                        break;
                    case 3: // Snake
                        int snake = random.Next(1, 7); // generate a random number for the snake position
                        Console.WriteLine("Snake - You move back by " + snake + " positions");
                        position -= snake; // update position based on snake
                        if (position < 0) // check if position goes below 0
                        {
                            position = 0; // set position to 0 if it goes below 0
                        }
                        break;
                }

                Console.WriteLine("You are now at position " + position);
            }

            Console.WriteLine("Congratulations! You reached the finish line!");
            Console.WriteLine("Game over!");
            Console.ReadKey();
        }
    }
}