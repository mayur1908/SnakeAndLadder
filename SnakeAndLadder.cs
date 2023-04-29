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
                position += diceRoll;

                // check for snakes and ladders
                switch (position)
                {
                    case 14:
                        Console.WriteLine("Oh no! You landed on a snake! Slide down to position 4");
                        position = 4;
                        break;
                    case 19:
                        Console.WriteLine("Congratulations! You found a ladder! Climb up to position 38");
                        position = 38;
                        break;
                    case 31:
                        Console.WriteLine("Oh no! You landed on a snake! Slide down to position 9");
                        position = 9;
                        break;
                    case 42:
                        Console.WriteLine("Congratulations! You found a ladder! Climb up to position 63");
                        position = 63;
                        break;
                    case 50:
                        Console.WriteLine("Oh no! You landed on a snake! Slide down to position 20");
                        position = 20;
                        break;
                    case 67:
                        Console.WriteLine("Congratulations! You found a ladder! Climb up to position 86");
                        position = 86;
                        break;
                    case 74:
                        Console.WriteLine("Oh no! You landed on a snake! Slide down to position 53");
                        position = 53;
                        break;
                    case 78:
                        Console.WriteLine("Congratulations! You found a ladder! Climb up to position 98");
                        position = 98;
                        break;
                    case 91:
                        Console.WriteLine("Oh no! You landed on a snake! Slide down to position 61");
                        position = 61;
                        break;
                    case 100:
                        Console.WriteLine("Congratulations! You reached the finish line!");
                        break;
                    default:
                        Console.WriteLine("You are now at position " + position);
                        break;
                }
            }
            Console.WriteLine("Game Over");
        }
    }
}
