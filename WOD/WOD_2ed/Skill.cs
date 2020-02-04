using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WOD_2ed
{
    public class Skill
    {
        public string Name { get; set; }
        public int Value { get; set; } = 0;
        public SkillType Type { get; set; }
        public List<string> Specialties { get; set; } = new List<string>();
    }

    public enum SkillType
    {
        MENTAL,
        PHYSICAL,
        SOCIAL
    }
}
