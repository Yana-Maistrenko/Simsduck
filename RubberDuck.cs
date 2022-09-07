using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class RubberDuck : Duck
    {
        public RubberDuck(bool swim) : base(swim) { }

        public override void Display()
        {
            Console.WriteLine("I'm a real rubber duck");
        }
    }
}

