using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Rock
        {
            string quartz = RPS.Rock;
            Console.WriteLine(quartz);
            Console.ReadLine();
        }

        private void button2_Click(object sender, EventArgs e) //Paper
        {
            string parchment = RPS.Paper;
            Console.WriteLine(parchment);
            Console.ReadLine();
        }

        private void button3_Click(object sender, EventArgs e) //Scissor
        {
            string shears = RPS.Scissors;
            Console.WriteLine(shears);
            Console.ReadLine();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
