using System;

namespace heistTwo
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} is picking the lock. Decreased security {SkillLevel} points");
            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has opened the safe.");
            }
        }

    }
}