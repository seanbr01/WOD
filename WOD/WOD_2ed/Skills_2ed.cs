using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WOD_2ed
{
    public class Skills_2ed
    {
        [Obsolete]
        public enum SkillType
        {
            MENTAL,
            PHYSICAL,
            SOCIAL
        }

        public SkillType Type { get; set; }
        public string Name { get; set; }

        private int skillValue = 0;
        public int Value
        {
            get { return skillValue; }
            set { skillValue = value; }
        }

        private List<string> specialties = new List<string>();

        public List<string> Specialties
        {
            get { return specialties; }
            set { specialties = value; }
        }


        public virtual List<Skills_2ed> CreateSkills()
        {
            var skills = new List<Skills_2ed>();

            var mentals = new List<string>() { "Academics", "Computer", "Crafts", "Investigation", "Medicine", "Occult", "Politics", "Science" };
            var physicals = new List<string> { "Athletics", "Brawl", "Drive", "Firearms", "Larceny", "Stealth", "Survival", "Weaponry" };
            var socials = new List<string> { "AnimalKen", "Empathy", "Expression", "Intimidation", "Persuasion", "Socialize", "Streetwize", "Subterfuge" };

            for (int i = 0; i < mentals.Count -1; i++)
            {
                skills.Add(new Skills_2ed() { Name = mentals[i], Type = SkillType.MENTAL });
                skills.Add(new Skills_2ed() { Name = physicals[i], Type = SkillType.PHYSICAL });
                skills.Add(new Skills_2ed() { Name = socials[i], Type = SkillType.SOCIAL });
            }

            return skills;
        }
    }
}
