using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : SmackTalkingPlayer
    {
        public List<string> Taunts = new List<string>()
        {
            "Is that all you've got",
            "You're terrible",
            "I eat breakfast that tastes like you",
            "Your Mom is amazing and you're not"
        };
        public override int Roll(int roll)
        {
            int index = new Random().Next(Taunts.Count);
            Console.WriteLine(Taunts[index]);
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}