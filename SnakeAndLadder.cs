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
            int position = 0;
            int diceRollCount = 0; // variable to keep track of the number of times the dice was rolled
            Console.WriteLine("Welcome to Snake and Ladder game!");

            while (position < 100)
            {
                Console.WriteLine("You are currently at position " + position);
                Console.WriteLine("Press any key to roll the dice");
                Console.ReadKey();

                Random random = new Random();
                int diceRoll = random.Next(1, 7);
                diceRollCount++; // increment the dice roll count

                Console.WriteLine("You rolled a " + diceRoll);

                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No play, stay at the same position");
                        break;
                    case 1:
                        Console.WriteLine("Congratulations! You found a ladder!");
                        position += diceRoll;
                        if (position > 100)
                        {
                            position -= diceRoll; // player stays in the same position
                        }
                        else if (position == 100)
                        {
                            Console.WriteLine("Congratulations! You reached the finish line!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Move ahead by " + diceRoll + " positions");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Oh no! You landed on a snake!");
                        position -= diceRoll;
                        if (position < 0)
                        {
                            position = 0; // player restarts from 0
                        }
                        Console.WriteLine("Move behind by " + diceRoll + " positions");
                        break;
                }

                Console.WriteLine("You are now at position " + position);
            }

            Console.WriteLine("Game over!");
            Console.WriteLine("Number of times the dice was rolled to win the game: " + diceRollCount);
            Console.ReadKey();


        }
    }
}