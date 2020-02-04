using System;
using System.Collections.Generic;
using System.Text;
using WOD_2ed;

namespace Mage_2ed
{
    public class MageSkills : Skills_2ed
    {
        private bool isRoteSkill = false;

        public bool IsRoteSkill
        {
            get { return isRoteSkill = false; }
            set { isRoteSkill = value; }
        }

        public List<MageSkills> CreateMageSkills()
        {
            var skills = new List<MageSkills>();

            var mentals = new List<string>() { "Academics", "Computer", "Crafts", "Investigation", "Medicine", "Occult", "Politics", "Science" };
            var physicals = new List<string> { "Athletics", "Brawl", "Drive", "Firearms", "Larceny", "Stealth", "Survival", "Weaponry" };
            var socials = new List<string> { "AnimalKen", "Empathy", "Expression", "Intimidation", "Persuasion", "Socialize", "Streetwize", "Subterfuge" };

            for (int i = 0; i < mentals.Count; i++)
            {
                skills.Add(new MageSkills() { Name = mentals[i], Type = SkillType.MENTAL, IsRoteSkill = false });
                skills.Add(new MageSkills() { Name = physicals[i], Type = SkillType.PHYSICAL, IsRoteSkill = false });
                skills.Add(new MageSkills() { Name = socials[i], Type = SkillType.SOCIAL, IsRoteSkill = false });
            }

            return skills;
        }
    }
}
