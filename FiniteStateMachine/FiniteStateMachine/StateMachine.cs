using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiniteStateMachine
{
    class StateMachine
    {
        public bool ContainsHi()
        {
            bool containsHi = false;
            int state = 1;
            string data = Console.ReadLine().ToLower();
            int counter = 0;

            while (counter < data.Length)
            {
                switch (state)
                {
                    case 1:
                        switch (data[counter])
                        {
                            case 'h':
                                state = 2;
                                counter++;
                                break;
                            case ' ':
                                state = 6;
                                counter++;
                                break;
                            default:
                                state = 5;
                                counter++;
                                break;
                        }
                        break;
                    case 2:
                        switch (data[counter])
                        {
                            case 'i':
                                state = 3;
                                counter++;
                                if (counter == data.Length)
                                {
                                    state = 4;
                                    counter = 0;
                                }
                                break;
                            default:
                                state = 5;
                                counter++;
                                break;
                        }
                        break;
                    case 3:
                        switch (data[counter])
                        {
                            case ' ':
                                state = 4;
                                counter++;
                                containsHi = true;
                                break;
                            default:
                                state = 5;
                                counter++;
                                break;
                        }
                        break;
                    case 4:
                        containsHi = true;
                        counter = data.Length;
                        break;
                    case 5:
                        switch (data[counter])
                        {
                            case ' ':
                                state = 6;
                                counter++;
                                break;
                            default:
                                state = 5;
                                counter++;
                                break;
                        }
                        break;
                    case 6:
                        switch (data[counter])
                        {
                            case 'h':
                                state = 7;
                                counter++;
                                break;
                            default:
                                state = 5;
                                counter++;
                                break;
                        }
                        break;
                    case 7:
                        switch (data[counter])
                        {
                            case 'i':
                                state = 8;
                                counter++;
                                if (counter == data.Length)
                                {
                                    state = 4;
                                    counter = 0;
                                }
                                break;
                            default:
                                state = 5;
                                counter++;
                                break;
                        }
                        break;
                    case 8:
                        switch (data[counter])
                        {
                            case ' ':
                                state = 4;
                                counter++;
                                containsHi = true;
                                break;
                            default:
                                state = 5;
                                counter++;
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Uhhhh....you broke the state somehow.....plz don't do that again :'( it's rude");
                        break;
                }
            }
            return containsHi;
        }
    }
}
