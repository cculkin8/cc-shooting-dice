using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            return new Random().Next(4,6);
        }
        public override void Play(Player other)
        {
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
                throw new Exception("You had to be cheating, because I was!");
            }
          }
        }
    }
}
