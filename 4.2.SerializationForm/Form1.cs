using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2.SerializationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            

        }
        private void button1_Click(object sender, EventArgs e) //Take cares of the experience gained.
        {
            Dictionary<int, Player> playerlvl = new Dictionary<int, Player>();
        }
        private void button2_Click(object sender, EventArgs e) //Handles the saving feature
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) //Displays the text of the exp level
        {

        }
    }
    public class Player : Form1
    {
        public int Experience= 0;
        public int Level= 0;

    }
}
