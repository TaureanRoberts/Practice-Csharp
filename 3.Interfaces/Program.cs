﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface ILoggable
    {
        void Log();
        string Name();

    }
    public class Animal
    {
        private string Name;
    }

    public class Vehicle
    {
        private string Name;
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
