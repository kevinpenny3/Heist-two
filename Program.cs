using System;
using System.Collections.Generic;

namespace heistTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var rolodex = new List<IRobber>();

            var Garrett = new Muscle()
            {
                Name = "GFresh",
                SkillLevel = 50,
                PercentageCut = 20,
            };

            var James = new Muscle()
            {
                Name = "Mr. Handclap",
                SkillLevel = 75,
                PercentageCut = 30,
            };

            var Namita = new Hacker()
            {
                Name = "Ms. Missmewiththatshit",
                SkillLevel = 650,
                PercentageCut = 0,
            };

            var Holden = new LockSpecialist()
            {
                Name = "Upinsmoke",
                SkillLevel = 95,
                PercentageCut = 95,
            };

            var Audrey = new Hacker()
            {
                Name = "HackNSlash",
                SkillLevel = 75,
                PercentageCut = 35,
            };

            rolodex.Add(Garrett);
            rolodex.Add(Namita);
            rolodex.Add(James);
            rolodex.Add(Audrey);
            rolodex.Add(Holden);

            Console.WriteLine($" Your Crew has {rolodex.Count} members");

            while (true)
            {
                Console.Write("Please enter a new member name: ");
                var newMemberName = Console.ReadLine();
                if (newMemberName == "")
                {
                    break;
                }
                else
                {
                    while (true)
                    {
                        Console.WriteLine("What is their specialty?: Hacker (Disables alarms), Muscle (Disarms guards), Lock Specialist (cracks vault)");
                        var newMemberSpecialty = Console.ReadLine();
                        if (newMemberSpecialty.ToLower() == "muscle")
                        {
                            Muscle newMuscle = new Muscle()
                            {
                            Name = newMemberName
                            };

                            Console.Write("Please enter Skill Level (1-100): ");
                            var newMemberSkillLevel = Console.ReadLine();
                            newMuscle.SkillLevel = int.Parse(newMemberSkillLevel);
                            Console.Write("Please enter Percentage Cut (1-100): ");
                            var newMemberPercentageCut = Console.ReadLine();
                            newMuscle.PercentageCut = int.Parse(newMemberPercentageCut);
                            rolodex.Add(newMuscle);

                        }
                        else if (newMemberSpecialty.ToLower() == "hacker")
                        {
                            Hacker newHacker = new Hacker()
                            {
                            Name = newMemberName
                            };

                            Console.Write("Please enter Skill Level (1-100): ");
                            var newMemberSkillLevel = Console.ReadLine();
                            newHacker.SkillLevel = int.Parse(newMemberSkillLevel);
                            Console.Write("Please enter Percentage Cut (1-100): ");
                            var newMemberPercentageCut = Console.ReadLine();
                            newHacker.PercentageCut = int.Parse(newMemberPercentageCut);
                            rolodex.Add(newHacker);
                        }
                        else if (newMemberSpecialty.ToLower() == "lockspecialist")
                        {
                            LockSpecialist newLockSpecialist = new LockSpecialist()
                            {
                            Name = newMemberName
                            };

                            Console.Write("Please enter Skill Level (1-100): ");
                            var newMemberSkillLevel = Console.ReadLine();
                            newLockSpecialist.SkillLevel = int.Parse(newMemberSkillLevel);

                            Console.Write("Please enter Percentage Cut (1-100): ");
                            var newMemberPercentageCut = Console.ReadLine();
                            newLockSpecialist.PercentageCut = int.Parse(newMemberPercentageCut);
                            rolodex.Add(newLockSpecialist);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please enter a valid speciality");
                        }
                        break;
                    }
                }
            }
            Console.WriteLine($" Your Crew has {rolodex.Count} members");
        }
    }
}