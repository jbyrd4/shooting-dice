using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Please enter your roll (1-6):");
            int humanRoll = int.Parse(Console.ReadLine());
            while (humanRoll > 6 || humanRoll < 1)
            {
                Console.WriteLine("Please enter your roll (1-6):");
                humanRoll = int.Parse(Console.ReadLine());
            }
            return humanRoll;
        }
    }
}