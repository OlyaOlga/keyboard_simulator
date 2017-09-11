using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyboardSimulator sim = new KeyboardSimulator();
            sim.currentMode = new EnglishMode();
            sim.currentMode.Print();
            Console.ReadKey();
        }
    }
}
