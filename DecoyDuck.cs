using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class DecoyDuck : Duck
    {
        public DecoyDuck(bool swim) : base(swim) { }

        public override void Display()
        {
            Console.WriteLine("I'm a real decoy duck");
        }
    }
}
