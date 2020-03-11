using System;
using System.Collections.Generic;
using System.Linq;

namespace heistTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank newBank = new Bank();
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
                SkillLevel = 65,
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
                        else if (newMemberSpecialty.ToLower() == "lock specialist")
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
            // foreach (var member in rolodex)
            // {
            //     Console.WriteLine(member.Name);
            // }
            Dictionary<string, int> bankScores = new Dictionary<string, int>();

            Random rand = new Random();
            var AlarmScore = rand.Next(0, 101);
            var VaultScore = rand.Next(0, 101);
            var SecurityGuardScore = rand.Next(0, 101);
            var CashOnHand = rand.Next(50000, 100000001);

            bankScores.Add("Alarm Score", AlarmScore);
            bankScores.Add("Vault Score", VaultScore);
            bankScores.Add("Security Guard Score", SecurityGuardScore);

            var orderedScores = bankScores.OrderBy(score => score.Value);

            var mostSecure = orderedScores.Last();
            var leastSecure = orderedScores.First();

            Console.WriteLine($"Most Secure: {mostSecure.Key} at {mostSecure.Value}");
            Console.WriteLine($"Least Secure: {leastSecure.Key} at {leastSecure.Value}");

            foreach (var member in rolodex)
            {
                Console.WriteLine($"{rolodex.IndexOf(member)} {member.ToString()}");
            }

            List<IRobber> crew = new List<IRobber>();

            while (true)
            {

                Console.WriteLine("Add Member to Crew?(Enter Number #)");

                var chosenMember = Console.ReadLine();
                if (chosenMember == "")
                {
                    break;
                }
                else
                {
                    foreach (var item in rolodex)
                    {
                        if (int.Parse(chosenMember) == rolodex.IndexOf(item))
                        {
                            crew.Add(item);
                            rolodex.Remove(item);
                            break;
                        }
                    }
                    foreach (var item in rolodex)
                    {
                        Console.WriteLine($"{rolodex.IndexOf(item)} {item.ToString()}");
                    }

                }

            }
            foreach (var person in crew)
            {
                Console.WriteLine($"{crew.IndexOf(person)} {person.ToString()}");
            }

        }
    }
}