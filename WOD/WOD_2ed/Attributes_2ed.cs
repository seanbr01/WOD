using System;
using System.Collections.Generic;
using System.Text;

namespace WOD_2ed
{
    [Obsolete]
    public class Attribute_2ed
    {
        public enum AttributeUse
        {
            POWER,
            FINESSE,
            RESISTANCE
        }

        public enum AttributeType
        {
            MENTAL,
            PHYSICAL,
            SOCIAL
        }

        public AttributeUse Use { get; set; }
        public AttributeType Type { get; set; }
        public string Name { get; set; }
        public int Value { get; set; } = 1;

        public static List<Attribute_2ed> CreateAttributes()
        {
            return new List<Attribute_2ed>()
            {
                new Attribute_2ed() { Name = "Intelligence", Use = AttributeUse.POWER, Type = AttributeType.MENTAL },
                new Attribute_2ed() { Name = "Wits", Use = AttributeUse.FINESSE, Type = AttributeType.MENTAL },
                new Attribute_2ed() { Name = "Resolve", Use = AttributeUse.RESISTANCE, Type = AttributeType.MENTAL },
                new Attribute_2ed() { Name = "Strength", Use = AttributeUse.POWER, Type = AttributeType.PHYSICAL },
                new Attribute_2ed() { Name = "Dexterity", Use = AttributeUse.FINESSE, Type = AttributeType.PHYSICAL },
                new Attribute_2ed() { Name = "Stamina", Use = AttributeUse.RESISTANCE, Type = AttributeType.PHYSICAL },
                new Attribute_2ed() { Name = "Presence", Use = AttributeUse.POWER, Type = AttributeType.SOCIAL },
                new Attribute_2ed() { Name = "Manipulation", Use = AttributeUse.FINESSE, Type = AttributeType.SOCIAL },
                new Attribute_2ed() { Name = "Composure", Use = AttributeUse.RESISTANCE, Type = AttributeType.SOCIAL }
            };
        }
    }
}
