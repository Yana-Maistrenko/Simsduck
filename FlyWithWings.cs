using System;
using System.Collections.Generic;
using System.Text;

namespace SimUDuck
{
    class FlyWithWings : FlyBehavior
    {
        private string fly;

        public string Fly { get => fly; set => fly = value; }

        void FlyBehavior.fly()
        {
            throw new NotImplementedException();
        }
    }
}