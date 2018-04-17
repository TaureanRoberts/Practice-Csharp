using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface ILoggable
    {
        void Log();

        string Name
        {
            get;
            set;
        }

    }
    public class Animal : ILoggable
    {
        private string name;

        
        public string Name
        {
            //var a = new Animal();
            //string firstname = a.Name;
            get { return name; }


            //a.Name = "bob"
            set { name = value; }
        }

        public void Log()
        {
        }
    }

    public class Vehicle : ILoggable
    {
        private string name;

        public string Name
        {
            get { return name;}

            set { name = value; }
        }

        public void Log()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        void test()
        {

        }

        static void Main(string[] args)
        {

        }
    }
}
