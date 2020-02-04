

namespace WOD_2ed
{
    public class Attributes
    {
        public Attribute Intelligence { get; set; } = new Attribute { Name = "Intelligence", Use = AttributeUse.POWER, Type = AttributeType.MENTAL };
        public Attribute Wits { get; set; } = new Attribute { Name = "Wits", Use = AttributeUse.FINESSE, Type = AttributeType.MENTAL };
        public Attribute Resolve { get; set; } = new Attribute { Name = "Resolve", Use = AttributeUse.RESISTANCE, Type = AttributeType.MENTAL };
        public Attribute Strength { get; set; } = new Attribute { Name = "Strength", Use = AttributeUse.POWER, Type = AttributeType.PHYSICAL };
        public Attribute Dexterity { get; set; } = new Attribute { Name = "Dexterity", Use = AttributeUse.FINESSE, Type = AttributeType.PHYSICAL };
        public Attribute Stamina { get; set; } = new Attribute { Name = "Stamina", Use = AttributeUse.RESISTANCE, Type = AttributeType.PHYSICAL };
        public Attribute Presence { get; set; } = new Attribute { Name = "Presence", Use = AttributeUse.POWER, Type = AttributeType.SOCIAL };
        public Attribute Manipulation { get; set; } = new Attribute { Name = "Manipulation", Use = AttributeUse.FINESSE, Type = AttributeType.SOCIAL };
        public Attribute Composure { get; set; } = new Attribute { Name = "Composure", Use = AttributeUse.RESISTANCE, Type = AttributeType.SOCIAL };
    }
}
