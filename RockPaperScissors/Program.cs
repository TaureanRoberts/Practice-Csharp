﻿using System;
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
        public  const string Rock = "Rock", Paper = "Paper", Scissors = "Scissors";
        public void SelectPlayerChoice(string other)
        {

        }
        public void SelectComputerChoice()
        {
            switch (ComputerChoice)
            {
                case Rock:
                    ComputerChoice = Rock;
                    break;
                case Paper:
                    ComputerChoice = Paper;
                    break;
                case Scissors:
                    ComputerChoice = Scissors;
                    break;
            }
        }
        public bool CheckForVictory()
        {
            return false; //Place holder. Havent reached this part yet.
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
