using System;

namespace heistTwo
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardSore -= SkillLevel;
            Console.WriteLine($"{Name} is punching guards in the face. Decreased security {SkillLevel} points");
            if (bank.SecurityGuardSore <= 0)
            {
                Console.WriteLine($"{Name} has beaten all the guards.");
            }
        }
        public override string ToString()
        {
            return $"{Name} is the Muscle, and has a skill level of {SkillLevel} and wants {PercentageCut}% cut.";
        }

    }
}