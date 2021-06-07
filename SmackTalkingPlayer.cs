using System;
namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "I'm just looking around to see who's gonna finish second";

        public override void Play(Player other)
        {
            Console.WriteLine(Taunt);
            base.Play(other);
        }
    }
}
