using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WOD_2ed
{
    public class BaseStats
    {
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public string ChronicleName { get; set; }
        public string Virture { get; set; }
        public string Vice { get; set; }
        public string Concept { get; set; }
        public Attribute Intelligence { get; set; } = new Attribute { Name = "Intelligence", Use = AttributeUse.POWER, Type = AttributeType.MENTAL };
        public Attribute Wits { get; set; } = new Attribute { Name = "Wits", Use = AttributeUse.FINESSE, Type = AttributeType.MENTAL };
        public Attribute Resolve { get; set; } = new Attribute { Name = "Resolve", Use = AttributeUse.RESISTANCE, Type = AttributeType.MENTAL };
        public Attribute Strength { get; set; } = new Attribute { Name = "Strength", Use = AttributeUse.POWER, Type = AttributeType.PHYSICAL };
        public Attribute Dexterity { get; set; } = new Attribute { Name = "Dexterity", Use = AttributeUse.FINESSE, Type = AttributeType.PHYSICAL };
        public Attribute Stamina { get; set; } = new Attribute { Name = "Stamina", Use = AttributeUse.RESISTANCE, Type = AttributeType.PHYSICAL };
        public Attribute Presence { get; set; } = new Attribute { Name = "Presence", Use = AttributeUse.POWER, Type = AttributeType.SOCIAL };
        public Attribute Manipulation { get; set; } = new Attribute { Name = "Manipulation", Use = AttributeUse.FINESSE, Type = AttributeType.SOCIAL };
        public Attribute Composure { get; set; } = new Attribute { Name = "Composure", Use = AttributeUse.RESISTANCE, Type = AttributeType.SOCIAL };
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
        public string Gender { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public string History { get; set; }
        public string Appearance { get; set; }
        public int Size { get; set; } = 5;
        public int Speed { get; set; }
        public int Defense { get; set; }
        public int ArmorGeneral { get; set; }
        public int ArmorBallistic { get; set; }
        public int InitiativeModifier { get; set; }
        public int Health { get; set; }
        public int BashingDamage { get; set; }
        public int LethalDamage { get; set; }
        public int AggravatedDamage { get; set; }

        private int willpower;
        public int Willpower
        {
            get { return willpower; }
            set { willpower = (value > 10) ? 10 : value; }
        }

        public int SpentWillpower { get; set; }
        public int ExperiencePoints { get; set; }
        public int SpentExperiencePoints { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Equipment> EquipmentList { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<string> Miscellaneneous { get; set; }
        public List<Residence> Residences { get; set; }
        public List<ExtendedMerit> ExtendedMerits { get; set; }
        public List<Merit> Merits { get; set; }
        public List<Flaw> Flaws { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Derangements { get; set; }

        public virtual void GetHealth()
        {
            Health = Stamina.Value + Size;
        }

        public virtual void GetWillPower()
        {
            Willpower = Resolve.Value + Computer.Value;
        }

        public virtual void GetDefense()
        {
            Defense = Math.Min(Dexterity.Value, Wits.Value);
        }

        public virtual void GetInitiativeModifier()
        {
            InitiativeModifier = Dexterity.Value + Composure.Value;
        }

        public virtual void GetSpeed()
        {
            Speed = Strength.Value + Dexterity.Value + 5;
        }
    }
}
