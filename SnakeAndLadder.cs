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

            while (position < 100)
            {
                Console.WriteLine("You are currently at position " + position);
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                // generate a random number between 1 and 6 for the dice roll
                Random random = new Random();
                int diceRoll = random.Next(1, 7);

                Console.WriteLine("You rolled a " + diceRoll);

                // update position based on dice roll and option
                int option = random.Next(0, 3); // 0 for no play, 1 for ladder, 2 for snake
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play! You stay at the same position");
                        break;
                    case 1:
                        int newPosition = position + diceRoll;
                        if (newPosition > 100)
                        {
                            Console.WriteLine("Oops! You cannot move ahead from position " + position);
                            break;
                        }
                        Console.WriteLine("Congratulations! You found a ladder! Climb up to position " + newPosition);
                        position = newPosition;
                        break;
                    case 2:
                         newPosition = position - diceRoll;
                        if (newPosition < 0)
                        {
                            Console.WriteLine("Oops! You cannot go below position 0");
                            position = 0;
                            break;
                        }
                        Console.WriteLine("Oh no! You landed on a snake! Slide down to position " + newPosition);
                        position = newPosition;
                        break;
                }
            }

            Console.WriteLine("Congratulations! You reached the finish line!");
            Console.ReadKey();
        }
    }
}