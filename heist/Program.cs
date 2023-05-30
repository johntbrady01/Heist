using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            Random rnd = new Random();
            int Luck = rnd.Next(-10, 10);

            int BanksDifficullty = 100;
            int TeamsSkill = 0;

            BanksDifficullty += Luck;

            int i = 0;

            List<TeamMember> TeamList = new List<TeamMember>() { };

            for (i = 0; i > -1; i++)
            {
                Console.Write("Enter a Team Member's name! ");
                string MembersName = Console.ReadLine();
                if (string.IsNullOrEmpty(MembersName))
                {
                    break;

                }
                Console.WriteLine(MembersName);

                Console.Write("Enter Skill Level! ");
                string StringMembersSkill = Console.ReadLine();
                int MembersSkill = int.Parse(StringMembersSkill);

                Console.Write("Enter Courage! ");
                string StringMembersCourage = Console.ReadLine();
                decimal MembersCourage = Decimal.Parse(StringMembersCourage);

                TeamMember NewMember = new TeamMember(MembersName, MembersSkill, MembersCourage);

                //NewMember.GetDescription();

                TeamList.Add(NewMember);


            }
            Console.WriteLine($"Awesome you have {i} team members!");
            /*Console.WriteLine("Members of the team:");
            foreach (TeamMember Member in TeamList)
            {
                Console.WriteLine($"{Member.Name}, Skill Level:{Member.SkillLevel},Courage Level:{Member.Courage} ");
            }
            */
            foreach (TeamMember Member in TeamList)
            {
                TeamsSkill += Member.SkillLevel;
            }

            Console.WriteLine($"Banks difficulty:{BanksDifficullty}");
            Console.WriteLine($"Teams overall skill:{TeamsSkill}");

            if (TeamsSkill >= BanksDifficullty)
            {
                Console.WriteLine("Success! Your team succeeded in your heist!");
            }
            else
            {
                Console.WriteLine("Failure! Your team was not skilled enough!");
            }

        }
    }
}
