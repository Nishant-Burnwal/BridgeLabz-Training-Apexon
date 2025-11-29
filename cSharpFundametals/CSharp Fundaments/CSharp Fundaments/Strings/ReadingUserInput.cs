using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.Strings
{
    internal class ReadingUserInput
    {   static void Main(string[] args)
        {
            Console.WriteLine("Enter the String: ");
            String read_user = Console.ReadLine(); // UserInput -> Highlights
            // Display the user input
            Console.WriteLine("User Entered: " + read_user);
        }
    }
}
