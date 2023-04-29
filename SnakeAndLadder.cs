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

        }
    }
}
