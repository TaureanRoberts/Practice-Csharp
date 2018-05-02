using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackpackProject
{
    public interface IEquipable
    {
        int ItemScore { get; set; }
    }
    public interface IBackpackable
    {
        bool IsEquipped();
        
    }
    public interface IConsumable
    {
        int ItemCount { get; set; }
    }
    public class Backpack : IBackpackable
    {
        public string name;
        public bool IsEquipped()
        {
            throw new NotImplementedException();
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
