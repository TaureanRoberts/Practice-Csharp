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
            Stats.Add("Strength", new Stat() { Name = "strength", Value = 10, Description = "" });
            Stats.Add("Dexterity", new Stat() { Name = "dexterity", Value = 10, Description = "" });
            Stats.Add("Constitution", new Stat() { Name = "constitution", Value = 10, Description = "" });
            Stats.Add("Intelligence", new Stat() { Name = "intelligence", Value = 10, Description = "" });
            Stats.Add("Wisdom", new Stat() { Name = "wisdom", Value = 10, Description = "" });
            Stats.Add("Charisma", new Stat() { Name = "charisma", Value = 10, Description = "" });
            //Using the string as a key store the specified stat
            foreach (var info in Stats)
            {
                Console.WriteLine(info.Key);
                Console.WriteLine(info.Value.Value);
                Console.WriteLine(info.Value.Description);
            }
            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Scrub you are, hmmmm.");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
