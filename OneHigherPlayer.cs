using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // Override the Play method to make a Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override void Play(Player other)
        {
            int enemyRoll = other.Roll();
            int thisRoll = enemyRoll + 1;
            Console.WriteLine($"{Name} rolls a {thisRoll}");
            Console.WriteLine($"{other.Name} rolls a {enemyRoll}");
        }
    }
}
