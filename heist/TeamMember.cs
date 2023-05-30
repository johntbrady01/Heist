using System;
using System.Collections.Generic;

namespace heist
{
    public class TeamMember
    {
        public string Name { get; set; }

        public int SkillLevel { get; set; }

        public decimal Courage { get; set; }

        public TeamMember(string name, int skillLevel, decimal courage)
        {
            Name = name;
            SkillLevel = skillLevel;
            Courage = courage;
        }

        public void GetDescription()
        {

            Console.WriteLine($"Member:{Name} has a Skill Level:{SkillLevel} and a Courage Level:{Courage}");

        }
    }

}