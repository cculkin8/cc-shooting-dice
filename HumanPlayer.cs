using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("What would you like to roll?");
            int input;
            do {
                input = Int32.Parse(Console.ReadLine());
            }
            while (input <1 || input > 6);
            return input;
        }
    }
}