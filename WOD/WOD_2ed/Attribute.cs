

namespace WOD_2ed
{
    public class Attribute
    {
        public string Name { get; set; }
        public int Value { get; set; } = 1;
        public AttributeUse Use { get; set; }
        public AttributeType Type { get; set; }
    }

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
}
