using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class MallardDuck : Duck
    {
        public MallardDuck(bool swim) : base(swim)
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real mallard duck");
        }
    }
}

