using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public class RPS
    {
        public string PlayerChoice;
        public string ComputerChoice;
        public List<string> VictoryConditions;
        public void SelectPlayerChoice(string other)
        {
            PlayerChoice = "Rock", "Paper";
        }
        public void SelectComputerChoice()
        {

        }

        public bool CheckForVictory()
        {
            return false;
        }

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
