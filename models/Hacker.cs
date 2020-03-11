using System;

namespace heistTwo
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} is hacking the alarm system. Decreased security {SkillLevel} points");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system.");
            }
        }
        public override string ToString()
        {
            return $"{Name} is a Hacker and has a skill level of {SkillLevel} and wants {PercentageCut}% cut.";
        }
    }
}