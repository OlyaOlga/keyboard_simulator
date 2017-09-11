using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace keyboard_simulator
{
    abstract class AbstractMode
    {
        protected void ReadFromFile()
        {
            string currentText = File.ReadAllText(dataFileName);
            symbolsQueue = new Queue<char>(currentText);
        }
        protected Queue<char> symbolsQueue;
        protected string dataFileName;
        public AbstractMode()
        {
        }
        public void Print()
        {
            foreach (var i in symbolsQueue)
            {
                Console.Write(i);
            }
        }
    }
}
