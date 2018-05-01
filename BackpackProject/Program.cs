using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackpackProject
{
    public interface IInventoryItems
    {
        string name();
        int HealthAffected { get; set; }
    }
    public class StatusChange : IInventoryItems
    {
        public int HealthAffected
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string name()
        {
            throw new NotImplementedException();
        }
    }
    public class Weapon : IInventoryItems
    {
        public int HealthAffected
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string name()
        {
            throw new NotImplementedException();
        }
    }
    public class Protection : IInventoryItems
    {
        public int HealthAffected
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string name()
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
