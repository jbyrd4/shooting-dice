using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public override int Roll()
        {
            int rndmTaunt = new Random().Next(0, 5);
            List<string> taunts = new List<string>();
            taunts.Add("You fight like a dairy Farmer!");
            taunts.Add("Soon you'll be wearing my sword like a shish kebab!");
            taunts.Add("I once owned a dog that was smarter than you.");
            taunts.Add("There are no words for how disgusting you are.");
            taunts.Add("I'm not going to take your insolence sitting down!");
            Console.WriteLine($"{Name} Says, '{taunts[rndmTaunt]}'");
            return base.Roll();
        }
    }
}