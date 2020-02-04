using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mage_2ed
{
    public class Cabal
    {
        public string Name { get; set; }
        public string Sigil { get; set; }

        private List<string> rites = new List<string>();
        public List<string> Rites
        {
            get { return rites; }
            set { rites = value; }
        }

        private List<CabalMember> members = new List<CabalMember>();
        public List<CabalMember> Members
        {
            get { return members; }
            set { members = value; }
        }

    }
}
