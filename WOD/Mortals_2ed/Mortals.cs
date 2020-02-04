using System;
using System.Collections.Generic;
using WOD_2ed;

namespace Mortals_2ed
{
    public class Mortals : BaseStats
    {
        public string Faction { get; set; }
        private int morality;
        public int Morality
        {
            get { return morality; }
            set { morality = (morality > 10) ? 10 : value; }
        }
        private int trueFaith;
        public int TrueFaith
        {
            get { return trueFaith; }
            set { trueFaith = (trueFaith > 10) ? 10 : value; }
        }
        public int SpentTrueFaith { get; set; }
        public List<Numina> Numinas { get; set; }

        public Mortals()
        {
            
        }
    }
}
