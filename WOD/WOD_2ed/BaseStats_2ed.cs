using System;
using System.Collections.Generic;

namespace WOD_2ed
{
    [Obsolete]
    public class BaseStats_2ed
    {
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public string ChronicleName { get; set; }
        public string Virture { get; set; }
        public string Vice { get; set; }
        public string Concept { get; set; }
        public string Gender { get; set; }
        public List<Attribute_2ed> Attributes { get; set; }
        public List<Skills_2ed> Skills { get; set; }
        public int Size { get; set; }
        public int Speed { get; set; }
        public int Defense { get; set; }
        public int ArmorGeneral { get; set; }
        public int ArmorBallistic { get; set; }
        public int InitiativeModifier { get; set; }
        public int Health { get; set; }

        private int willpower;
        public int Willpower
        {
            get { return willpower; }
            set { willpower = (willpower > 10) ? 10 : value; }
        }

        public List<Merit> Merits { get; set; }
        public List<Flaw> Flaws { get; set; }
        public int ExperiencePoints { get; set; }
        public int Age { get; set; }
        public string DateOfBirth { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Race { get; set; }
        public string Nationality { get; set; }
        public string Height { get; set; }
        public int Weight { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<ExtendedMerit> ExtendedMerits { get; set; }
        public string History { get; set; }
    }
}
