using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _1.Containers
{
    public class Stat
    {
        public string Name;
        public int Value;
        public string Description;
    }

    public class SavingThrows
    {
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Charisma;
    }

    public class Character
    {
        Dictionary<string, Stat> SavingThows = new Dictionary<string, Stat>();

        public int ExperiencePoints;
        public string CharacterName;
        public int level;

    }
    class Program
    {
        //Make a dictionary of <string, stat>
        static void Main(string[] args)
        {
            Dictionary<string, Stat> Stats = new Dictionary<string, Stat>();
            Stats.Add("Strength", new Stat());
            Stats.Add("Dexterity", new Stat());
            Stats.Add("Constitution", new Stat());
            Stats.Add("Intelligence", new Stat());
            Stats.Add("Wisdom", new Stat());
            Stats.Add("Charisma", new Stat());
            //Using the string as a key store the specified stat
        }
    }
}
