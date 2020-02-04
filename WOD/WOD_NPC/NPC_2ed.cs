using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOD_NPC
{
    public class NPC_2ed
    {
        public enum Description
        {
            Beginner = 1,
            Competent = 2,
            Veteran = 3,
            Expert = 4,
            Master = 5,
            Hero = 6,
            Epic = 7,
            Legend = 8,
            Avatar = 9,
            Demigod = 10,
            God = 11,
        }

        public enum Specialty
        {
            Mental,
            Physical,
            Social
        }

        public enum Template
        {
            Human = 0,
            Vampire = 1,
            Werewolf = 2,
            Mage = 3
        }

        public Template Race { get; set; }
        public Description Rank { get; set; }
        public int Competency { get; set; }
        public int Resistance { get; set; }
        public string Powers { get; set; }
        public int EnergyPerTurn { get; set; }
        public Specialty AttributeSpecialty { get; set; }
        public Specialty SkillSpecialty { get; set; }
        public int Initiative { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int Health { get; set; }
        public int Willpower { get; set; }
        public string Note { get; set; }

        private List<string> notes = new List<string>()
        {
            @"Just a Human.",
            @"Vampires can spend Vitae up to their energy-per-turn limit:
                •Healing: 2 bashing or 1 lethal per Vitae.
                •Physical Actions: +2 per Vitae.
                •Celerity: 1 Vitae per turn.
                •Other Disciplines: As appropriate.",
            @"Werewolves can spend Essence to heal, immediately shapeshift or use Gifts, up to their energy-per-turn limit. If they don't use Essence, shapeshifting takes a turn and a Competency + Rank roll. They get the following, simplified bonuses for non-human forms:
                •Physical Actions: +1/+3/+2/+0
                •Health: +2/+4/+3/+0
                •Speed: +1/+4/+7/+5
              The maximum time in Gauru form equals the NPC's Resistance, with a +1 bonus for Physical Specialty. You may assume the werewolf has Renown appropriate for her Gifts, unless you use the optional Renown rules above.",
            @"Mages get fewer Mana-per-turn than specified in the Gnosis rules. The excess is assumed to be spent mitigating Paradox, so that NPCs mages only suffer Paradox when the Storyteller feels it would be dramatic. 
              For Improvised Magic, NPC mages get a reduced dice pool of Rank + Arcana. They get full the Competency + Arcana dice pool for Rotes. You can decide which effects they cast as Rotes based on their general area of focus, or explicitly note them (see below). 
              You can assume any mage will have an active Mage Armor of Rank + 1 (maximum of 5)."
        };

        public List<string> Notes
        {
            get { return notes; }
        }

        public NPC_2ed(int rank)
        {
            Rank = (rank > 11) ? (Description)11 : (Description)rank;
            Rank = (rank < 1) ? (Description)1 : (Description)rank;
            createNpc();
        }

        public void createNpc()
        {
            Competency = 3 + (int)Rank;
            Resistance = (int)Math.Ceiling((decimal)(int)Rank / 2 + 1);
            
            int temp = (int)Rank;
            Powers = temp.ToString();
            do
            {
                temp--;
                if (temp > 0)
                {
                    Powers = Powers + $" / {temp}";
                }
            } while (temp > 0);
            
            EnergyPerTurn = (int)Math.Ceiling((decimal)(int)Rank / 3);

            Initiative = DeriveTrait(Competency, 1);

            Defense = Resistance;

            Speed = DeriveTrait(Competency + 5, 2);

            Health = DeriveTrait(Resistance + 5, 2);

            Willpower = Competency;
        }

        public int DeriveTrait(int bastStat, int bonus)
        {
            bastStat = (AttributeSpecialty == Specialty.Physical || AttributeSpecialty == Specialty.Social) ? bastStat : bastStat += bonus;
            bastStat = (SkillSpecialty == Specialty.Physical || AttributeSpecialty == Specialty.Social) ? bastStat : bastStat += bonus;

            return bastStat;
        }
        
        public void GetTemplateNotes()
        {
            Note = (Race != 0) ? Note = Notes[(int)Race] : Note = Notes[0];
        }
    }
}
