﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What's your name player?");
            string inputtedName = Console.ReadLine();
            Player player1 = new Player();
            player1.Name = "Bob";

            Player player2 = new Player();
            player2.Name = "Sue";

            player2.Play(player1);

            Console.WriteLine("-------------------");

            SmackTalkingPlayer smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Larry Bird";

            smackTalker.Play(player2);
            Console.WriteLine("-------------------");

            Player player3 = new Player();
            player3.Name = "Wilma";


            player3.Play(smackTalker);

            Console.WriteLine("-------------------");

            HumanPlayer human = new HumanPlayer();
            human.Name = inputtedName;

            human.Play(player3);
            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";

            player1.Play(large);

            Console.WriteLine("-------------------");
            OneHigherPlayer higherRoller = new OneHigherPlayer();
            higherRoller.Name = "Cheater";

            higherRoller.Play(smackTalker);
            List<Player> players = new List<Player>() {
                player1, player2, player3, large, higherRoller, smackTalker
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play noe another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                
                //try {
                    player1.Play(player2);
            }
        }
    }
}