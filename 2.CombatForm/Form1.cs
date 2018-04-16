using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.CombatForm
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, Stat> Stats = new Dictionary<string, Stat>();
            Stats.Add("Strength", new Stat() { Name = "strength", Value = 6, Description = "How strong are you" });
            Stats.Add("Dexterity", new Stat() { Name = "dexterity", Value = 11, Description = "How agile are you" });
            Stats.Add("Constitution", new Stat() { Name = "constitution", Value = 5, Description = "Stats for health" });
            Stats.Add("Intelligence", new Stat() { Name = "intelligence", Value = 4, Description = "How smart are you" });
            Stats.Add("Wisdom", new Stat() { Name = "wisdom", Value = 9, Description = "Knowledgable" });
            Stats.Add("Charisma", new Stat() { Name = "charisma", Value = 10, Description = "How likable are you" }); //Displays one info of this Stat
            //Using the string as a key store the specified stat
            foreach (var info in Stats) // need a list to show the info for the stat.
            {
                string[] statList;
                richTextBox1.Text = info.Value.Name;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Scrub you are, hmmmm.");
            Console.WriteLine(); //Makes a space between info
        }
        
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
    public class Stat
    {
        public string Name;
        public int Value;
        public string Description;
    }
}
