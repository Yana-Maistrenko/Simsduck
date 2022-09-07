using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimUDuck
{
    abstract class Duck
    {
        public bool c_swim;

        public static Duck duck1 = new MallardDuck(true);
        public static Duck duck2 = new DecoyDuck(false);
        public static Duck duck3 = new RedHeadDuck(true);
        public static Duck[] ducks = { duck1, duck2, duck3 };
        public Duck(bool swim)
        {
            c_swim = swim;
           
        }


        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public static void AddNewDuck(ref Duck item)
        {

            
            Console.WriteLine("Your duck added!");
        }

        public static void ShowList()
        {
            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(i + ". " + ducks[i]);
            }
        }

        public abstract void Display();

    }
}