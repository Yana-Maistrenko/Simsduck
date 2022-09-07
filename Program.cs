using System;

namespace SimUDuck
{
    class Program
    {
        static void Main(string[] args)
        {
            int selection;
            

                
                Console.WriteLine("      Menu      \n" +
                                  "1. Show ducks          \n" +
                                  "To complete the work, press \" Esc \"  or write something        ");
                Console.WriteLine("Enter your choise: ");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        {
                            Duck.ShowList();
                            break;
                        }
                }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}