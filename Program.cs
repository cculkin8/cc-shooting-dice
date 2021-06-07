using System;
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


            SmackTalkingPlayer smackTalker = new SmackTalkingPlayer();
            smackTalker.Name = "Larry Bird";


            Player player3 = new Player();
            player3.Name = "Wilma";


            HumanPlayer human = new HumanPlayer();
            human.Name = inputtedName;


            Player large = new LargeDicePlayer();
            large.Name = "Bigun Rollsalot";


            OneHigherPlayer higherRoller = new OneHigherPlayer();
            higherRoller.Name = "Cheater";


            CreativeSmackTalkingPlayer Kobe = new CreativeSmackTalkingPlayer();
            Kobe.Name = "Kobe";


            SoreLoserPlayer drew = new SoreLoserPlayer();
            drew.Name = "Drew";

            UpperHalfPlayer alwaysup = new UpperHalfPlayer();
            alwaysup.Name = "Mr.Rodgers";
            
            SoreLoserUpperHalfPlayer highBaller = new SoreLoserUpperHalfPlayer();
            highBaller.Name = "Tiger Woods";



            List<Player> players = new List<Player>() {
                smackTalker, human, large, higherRoller, Kobe, drew, alwaysup, highBaller
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");


                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];

                try
                {
                    player1.Play(player2);
                }
                catch (Exception ex)
                {
                    if (ex.Message == "Get out of my face punk")
                    {
                        Console.WriteLine("No");
                        Console.WriteLine("I never lose");
                        continue;
                    }

                    if (ex.Message == "You had to be cheating, because I was!")
                    {
                        Console.WriteLine("You'll be hearing from my lawyer");
                        continue;
                    }
                }

            }
        }
    }
}