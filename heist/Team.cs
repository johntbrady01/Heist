using System;
using System.Collections.Generic;

namespace heist
{
    public class Team
    {
        public List<TeamMember> Members { get; set; }

        public void ListMembers()
        {

            Console.WriteLine("Members of the team:");
            foreach (TeamMember Member in Members)
            {
                Console.WriteLine($"{Member.Name}, Skill Level:{Member.SkillLevel},Courage Level:{Member.Courage} ");
            }

        }
    }

}