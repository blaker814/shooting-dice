using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll(int roll)
        {
            while (true)
            {
                Console.Write($"Enter a roll for {Name}: ");
                try
                {
                    roll = int.Parse(Console.ReadLine());
                    if (roll > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            return roll;
        }
    }
}