using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck(bool swim) : base(swim) { }

        public override void Display()
        {
            Console.WriteLine("I'm a real red head duck");
        }
    }
}

