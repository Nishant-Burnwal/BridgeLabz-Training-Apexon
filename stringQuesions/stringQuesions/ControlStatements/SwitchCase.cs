using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringQuesions.ControlStatements
{
    internal class SwitchCase
    {
        static void Main(string[] args)
        {
            int num = 20;

            // Switch-case statement to check the value of num
            switch (num)
            {
                case 10:
                    Console.WriteLine("num is 10");
                    break;
                case 20:
                    Console.WriteLine("num is 20");
                    break;
                case 30:
                    Console.WriteLine("num is 30");
                    break;
                default:
                    Console.WriteLine("num is not present");
                    break;
            }
        }
    }
}
