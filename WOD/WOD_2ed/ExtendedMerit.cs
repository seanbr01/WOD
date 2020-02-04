using System;
using System.Collections.Generic;
using System.Text;

namespace WOD_2ed
{
    public class ExtendedMerit : Merit
    {
        public List<Merit> ExtendedMerits { get; set; } = new List<Merit>();
    }
}
