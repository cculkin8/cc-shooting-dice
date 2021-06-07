using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
            {
            int enemyRoll = other.Roll();
            int thisRoll = Roll();
            Console.WriteLine($"{Name} rolls a {thisRoll}");
            Console.WriteLine($"{other.Name} rolls a {enemyRoll}");
            if (thisRoll > enemyRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else
            {
                throw new Exception("Get out of my face punk");
            }
        }
    }
}