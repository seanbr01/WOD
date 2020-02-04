using System.Collections.Generic;

namespace WOD_2ed
{
    public class OtherTraits
    {
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

        private int morality;
        public int Morality
        {
            get { return morality; }
            set { morality = (morality > 10) ? 10 : value; }
        }

        public int ExperiencePoints { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<ExtendedMerit> ExtendedMerits { get; set; }
        public List<Merit> Merits { get; set; }
        public List<Flaw> Flaws { get; set; }
        public List<string> Languages { get; set; }
        public List<string> Derangements { get; set; }
    }
}
