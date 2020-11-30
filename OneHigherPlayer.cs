using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls one higher than the other player
    public class OneHigherPlayer : Player
    {
        public override int Roll(int roll)
        {
            // Return a random number between 1 and DiceSize
            return roll + 1;
        }
        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int otherRoll = other.Roll(0);
            int myRoll = Roll(otherRoll);

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            Console.WriteLine($"{Name} Wins!");
        }
    }
}