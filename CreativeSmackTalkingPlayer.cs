using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> AdvancedSmack { get; } = new List<string>()
        {
            "When my time on Earth is gone, and my activities here are past, I want them to bury me upside down, and my critics can kiss my ass.",
            "I'm not arrogant, I'm good.",
            "Get your popcorn ready, cause I'm gonna put on a show",
            "It ain't braggin' if you can back it up.",
            "You think season is over?",
            "Damn! I didn't mean to leave any time left on the clock.",
            "Float like a butterfly and sting like a bee...his hands can't hit what his eyes can't see.",
            "Fo', fo', fo."
        };
        public override void Play(Player other)
        {
            int y = new Random().Next(8)+1;
            Console.WriteLine(AdvancedSmack[y]);
            base.Play(other);
    }
    }
}