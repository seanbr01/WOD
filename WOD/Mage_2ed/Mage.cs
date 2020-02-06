using System;
using System.Collections.Generic;
using System.Text;
using WOD_2ed;

namespace Mage_2ed
{
    public class Mage : BaseStats
    {
        public string ShadowName { get; set; }

        public MageEnums.Path Path { get; set; }

        private List<string> order = new List<string>() {
            "Adamantine Arrow",
            "Guardians of the Veil",
            "Mysterium",
            "Silver Ladder",
            "Free Council",
            "Seers of the Throne",
            "Hegemony",
            "Panopticon",
            "Paternoster",
            "Praetorian",
            "Apostate",
            "Nameless"
        };
        public List<string> Order
        {
            get { return order; }
        }

        public string Legacy { get; set; }

        public List<MageSkills> MageSkills { get; set; }

        public int Gnosis { get; set; }

        public int Mana { get; set; }

        public int Wisdom { get; set; }

        private List<string> conditions = new List<string>();
        public List<string> Conditions
        {
            get { return conditions; }
            set { conditions = value; }
        }

        private List<string> aspirations = new List<string>();
        public List<string> Aspirations
        {
            get { return aspirations; }
            set { aspirations = value; }
        }

        private List<string> obsessions = new List<string>();
        public List<string> Obsessions
        {
            get { return obsessions; }
            set { obsessions = value; }
        }

        private List<string> activeSpells = new List<string>();
        public List<string> ActiveSpells
        {
            get { return activeSpells; }
            set { activeSpells = value; }
        }

        private List<Yantra> yantras = new List<Yantra>();
        public List<Yantra> Yantras
        {
            get { return yantras; }
            set { yantras = value; }
        }

        private List<MagicalTool> magicalTools = new List<MagicalTool>();
        public List<MagicalTool> MagicalTools
        {
            get { return magicalTools; }
            set { magicalTools = value; }
        }

        private List<string> praxes = new List<string>();
        public List<string> Praxes
        {
            get { return praxes; }
            set { praxes = value; }
        }

        private List<string> inuredSpells;
        public List<string> InuredSpells
        {
            get { return inuredSpells; }
            set { inuredSpells = value; }
        }

        private List<EnchantedItem> enchantedItems = new List<EnchantedItem>();
        public List<EnchantedItem> EnchantedItems
        {
            get { return enchantedItems; }
            set { enchantedItems = value; }
        }

        private List<string> arcanaAttainments = new List<string>();
        public List<string> ArcanaAttainments
        {
            get { return arcanaAttainments; }
            set { arcanaAttainments = value; }
        }

        private List<LegacyAttainment> legacyAttainments = new List<LegacyAttainment>();
        public List<LegacyAttainment> LegacyAttainments
        {
            get { return legacyAttainments; }
            set { legacyAttainments = value; }
        }

        public Nimbus Nimbus { get; set; }

        public string MagicalStyle { get; set; }

        private List<string> persistentConditions = new List<string>();
        public List<string> PersistentConditions
        {
            get { return persistentConditions; }
            set { persistentConditions = value; }
        }

        private List<string> sanctum = new List<string>();
        public List<string> Sanctum
        {
            get { return sanctum; }
            set { sanctum = value; }
        }
        
        public Mage()
        {
            
        }
    }
}
