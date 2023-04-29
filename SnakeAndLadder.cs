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
            { // continue playing until position is 100 or more
                Console.WriteLine("You are currently at position " + position);
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                // generate a random number between 1 and 6 for the dice roll
                Random random = new Random();
                int diceRoll = random.Next(1, 7);

                Console.WriteLine("You rolled a " + diceRoll);

                // update position based on dice roll
                int newPosition = position + diceRoll;

                // check if new position exceeds 100
                if (newPosition > 100)
                {
                    Console.WriteLine("You need " + (100 - position) + " to reach the finish line. Try again.");
                }
                else
                {
                    // check for snakes and ladders
                    switch (newPosition)
                    {
                        case 14:
                            Console.WriteLine("Oh no! You landed on a snake! Slide down to position 4");
                            newPosition = 4;
                            break;
                        case 19:
                            Console.WriteLine("Congratulations! You found a ladder! Climb up to position 38");
                            newPosition = 38;
                            break;
                        case 31:
                            Console.WriteLine("Oh no! You landed on a snake! Slide down to position 9");
                            newPosition = 9;
                            break;
                        case 42:
                            Console.WriteLine("Congratulations! You found a ladder! Climb up to position 63");
                            newPosition = 63;
                            break;
                        case 50:
                            Console.WriteLine("Oh no! You landed on a snake! Slide down to position 20");
                            newPosition = 20;
                            break;
                        case 67:
                            Console.WriteLine("Congratulations! You found a ladder! Climb up to position 86");
                            newPosition = 86;
                            break;
                        case 74:
                            Console.WriteLine("Oh no! You landed on a snake! Slide down to position 53");
                            newPosition = 53;
                            break;
                        case 78:
                            Console.WriteLine("Congratulations! You found a ladder! Climb up to position 98");
                            newPosition = 98;
                            break;
                        case 91:
                            Console.WriteLine("Oh no! You landed on a snake! Slide down to position 61");
                            newPosition = 61;
                            break;
                        case 100:
                            Console.WriteLine("Congratulations! You reached the finish line!");
                            break;
                        default:
                            Console.WriteLine("You are now at position " + newPosition);
                            break;
                    }

                    // update position if new position is valid
                    if (newPosition <= 100)
                    {
                        position = newPosition;
                    }
                }
            }

            Console.WriteLine("Game over!");
            Console.ReadKey();

        }
    }
}