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
        }
    }
}
