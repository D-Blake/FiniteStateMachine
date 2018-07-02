using System;

namespace FiniteStateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your sentence: ");
            Response();
        }
        public static void Response()
        {
            StateMachine machine = new StateMachine();
            if (machine.ContainsHi())
            {
                Random r = new Random();
                int randInt = r.Next(0, 3);
                switch (randInt)
                {
                    case 0:
                        Console.WriteLine("Why, hello there ^_^");
                        break;
                    case 1:
                        Console.WriteLine("Hey!");
                        break;
                    case 2:
                        Console.WriteLine("Hmmmm....hello, I guess >_>");
                        break;
                }
            }
            else
            {
                Random r = new Random();
                int randInt = r.Next(0, 2);
                switch (randInt)
                {
                    case 0:
                        Console.WriteLine("OwO");
                        break;
                    case 1:
                        Console.WriteLine("UwU");
                        break;
                }
            }
        }
    }
}
