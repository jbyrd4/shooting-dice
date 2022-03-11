using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Player lowFiber = new Player();
            lowFiber.Name = "Men of Low Moral Fiber";

            Console.WriteLine("1. Smack Talking Player");
            Console.WriteLine("-----------------------");
            SmackTalkingPlayer elaine = new SmackTalkingPlayer();
            elaine.Name = "Elaine Marley";
            lowFiber.Play(elaine);
            Console.WriteLine("");

            Console.WriteLine("2. One Higher Player");
            Console.WriteLine("-----------------------");
            OneHigherPlayer leChuck = new OneHigherPlayer();
            leChuck.Name = "LeChuck";
            leChuck.Play(elaine);
            Console.WriteLine("");

            Console.WriteLine("3. Human Player");
            Console.WriteLine("-----------------------");
            HumanPlayer stan = new HumanPlayer();
            stan.Name = "Stan";
            elaine.Play(stan);

            Console.WriteLine("4. Creative Smack Talking Player");
            Console.WriteLine("-----------------------");
            CreativeSmackTalkingPlayer guybrush = new CreativeSmackTalkingPlayer();
            guybrush.Name = "Guybrush Threepwood";
            guybrush.Play(elaine);


            Console.WriteLine("-------------------");

            List<Player> players = new List<Player>() {
                elaine, guybrush, leChuck, stan
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
                player1.Play(player2);
            }
        }
    }
}