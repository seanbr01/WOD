using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mage_2ed;
using WOD_NPC;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC_2ed nPC_2Ed = new NPC_2ed(5);
            nPC_2Ed.Race = NPC_2ed.Template.Mage;
            nPC_2Ed.AttributeSpecialty = NPC_2ed.Specialty.Physical;
            nPC_2Ed.SkillSpecialty = NPC_2ed.Specialty.Physical;

            Console.WriteLine($"Race: {nPC_2Ed.Race.ToString()}");
            Console.WriteLine($"Cometency: {nPC_2Ed.Competency}");
            Console.WriteLine($"Resistance: {nPC_2Ed.Resistance}");
            Console.WriteLine($"Powers: {nPC_2Ed.Powers}");
            Console.WriteLine($"Iniitiative: {nPC_2Ed.Initiative}");
            Console.WriteLine($"Defense: {nPC_2Ed.Defense}");
            Console.WriteLine($"Speed: {nPC_2Ed.Speed}");
            Console.WriteLine($"Health: {nPC_2Ed.Health}");
            Console.WriteLine($"Willpower: {nPC_2Ed.Willpower}");
            nPC_2Ed.GetTemplateNotes();
            Console.WriteLine($"Note: {nPC_2Ed.Note}");

            Console.ReadLine();
        }
    }
}
