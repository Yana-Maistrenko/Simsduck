using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class Quack : QuackBehavior
    {
        public string Quacks { get; set; }

        void QuackBehavior.quack()
        {
            throw new NotImplementedException();
        }
    }
}
