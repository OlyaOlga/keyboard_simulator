using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_simulator
{
    class EnglishMode:
        AbstractMode
    {
        public EnglishMode()
        {
            symbolsQueue = new Queue<char>();
            dataFileName = "eng.txt";
            ReadFromFile();
        }

      
    }
}
