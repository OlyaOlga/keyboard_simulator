using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard_simulator
{
    class Complexity
    {
        private AbstractMode mode;
        public bool UseUpperCase { get; set; }
        Complexity()
        { }

        void ChangeComplexity(bool complex, ref string text)
        {
            if (complex == false)
            {
                text = text.ToLower();
            }
        }
    }
}
