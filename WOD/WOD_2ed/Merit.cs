using System;
using System.Collections.Generic;
using System.Text;

namespace WOD_2ed
{
    public class Merit
    {
        public enum MeritType
        {
            FIGHTING,
            MENTAL,
            PHYSICAL,
            SUPERNATURAL
        }

        public string Name { get; set; }
        public MeritType Type { get; set; }
        public string Book { get; set; }
        public string Level { get; set; }
        public string Prerequisites { get; set; }
        public string Effect { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
        public string Level4 { get; set; }
        public string Level5 { get; set; }
        public string Drawback { get; set; }
        public string ExtendedDescription { get; set; }
    }
}
