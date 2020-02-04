using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOD_2ed
{
    public class Skills
    {
        public Skill Academics { get; set; } = new Skill { Name = "Academics", Type = SkillType.MENTAL };
        public Skill Computer { get; set; } = new Skill { Name = "Computer", Type = SkillType.MENTAL };
        public Skill Crafts { get; set; } = new Skill { Name = "Crafts", Type = SkillType.MENTAL };
        public Skill Investigation { get; set; } = new Skill { Name = "Investigation", Type = SkillType.MENTAL };
        public Skill Medicine { get; set; } = new Skill { Name = "Medicine", Type = SkillType.MENTAL };
        public Skill Occult { get; set; } = new Skill { Name = "Occult", Type = SkillType.MENTAL };
        public Skill Politics { get; set; } = new Skill { Name = "Politics", Type = SkillType.MENTAL };
        public Skill Science { get; set; } = new Skill { Name = "Science", Type = SkillType.MENTAL };
        public Skill Athletics { get; set; } = new Skill { Name = "Athletics", Type = SkillType.PHYSICAL };
        public Skill Brawl { get; set; } = new Skill { Name = "Brawl", Type = SkillType.PHYSICAL };
        public Skill Drive { get; set; } = new Skill { Name = "Drive", Type = SkillType.PHYSICAL };
        public Skill Firearms { get; set; } = new Skill { Name = "Firearms", Type = SkillType.PHYSICAL };
        public Skill Larceny { get; set; } = new Skill { Name = "Larceny", Type = SkillType.PHYSICAL };
        public Skill Stealth { get; set; } = new Skill { Name = "Stealth", Type = SkillType.PHYSICAL };
        public Skill Survival { get; set; } = new Skill { Name = "Survival", Type = SkillType.PHYSICAL };
        public Skill Weaponry { get; set; } = new Skill { Name = "Weaponry", Type = SkillType.PHYSICAL };
        public Skill AnimalKen { get; set; } = new Skill { Name = "AnimalKen", Type = SkillType.SOCIAL };
        public Skill Empathy { get; set; } = new Skill { Name = "Empathy", Type = SkillType.SOCIAL };
        public Skill Expression { get; set; } = new Skill { Name = "Expression", Type = SkillType.SOCIAL };
        public Skill Intimidation { get; set; } = new Skill { Name = "Intimidation", Type = SkillType.SOCIAL };
        public Skill Persuasion { get; set; } = new Skill { Name = "Persuasion", Type = SkillType.SOCIAL };
        public Skill Socialize { get; set; } = new Skill { Name = "Socialize", Type = SkillType.SOCIAL };
        public Skill Streetwize { get; set; } = new Skill { Name = "Streetwize", Type = SkillType.SOCIAL };
        public Skill Subterfuge { get; set; } = new Skill { Name = "Subterfuge", Type = SkillType.SOCIAL };
    }
}
