using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.Strings
{
    internal class StringMethods
    {
        static void Main(string[] args)
        {
            StringBuilder mutableString = new StringBuilder("Hello World!");
            String convertedToString = mutableString.ToString();
            int indexOfWorld = convertedToString.IndexOf("World");
            Console.WriteLine(indexOfWorld);
            /* NB: StreamBuilder just have an advantage of mutability but don't have IndexOf() and and other methods
            so to use those methods we must convert it toString() */

            /* 1. Question Time: 
            * Create a simple String 'I am learning C#' and apply all the basic methods.
            */

            // Solution
            String txt = "I am learning C#";

            // Method: IndexOf
            int indexOfLearning = txt.IndexOf("learning");
            Console.WriteLine($"\n\nIndex of 'learning' in '{txt}': " + indexOfLearning);

            // Method: StartsWith and EndsWith
            bool startsWithText = txt.StartsWith("I am");
            bool endsWithText = txt.EndsWith("C#");
            Console.WriteLine($"\n\n{txt} Starts with 'I am': {startsWithText} and endsWith 'C#': {endsWithText}");

            // Method: Upper and Lower
            Console.WriteLine("\n\nToUpper: " + txt.ToUpper());
            Console.WriteLine("ToLower: " + txt.ToLower());

            // Method: Split returns Array
            Console.Write("\n\nSplit Method Returns Array:\n");
            String[] arrOfText = txt.Split(' ');
            Console.WriteLine(arrOfText); // Returns the fully Qualified Object not the array
            Console.WriteLine(arrOfText.Length);
            Console.WriteLine(arrOfText[0]);
            Console.WriteLine(arrOfText[1]);
            Console.WriteLine(arrOfText[2]);
            Console.WriteLine(arrOfText[3]);


            // Method: Join apply to 'array' and returns String
            Console.Write("\n\nJoined Method to array");
            String joinedArray = string.Join(" ", arrOfText);
            Console.WriteLine(joinedArray);

            // Method: 'Contains' takes array and returns boolean
            Console.WriteLine($"\n\n{txt} contains 'C#': " + txt.Contains("C#"));

            // Method: Pad Left & Pad Right
            Console.WriteLine($"Pad left equal to string size: " + txt.PadLeft(txt.Length, '*'));
            Console.WriteLine($"Pad right equal to string size: " + txt.PadRight(txt.Length, '*'));

            // Method: Remove
            String removedText = txt.Remove(5, 7);
            Console.WriteLine("\n\n" + removedText);

            // Method: Insert
            String insertText = txt.Insert(txt.Length - 1, "Sharp");
            Console.WriteLine("\n\n"+insertText);

            // Method: Trim
            String spacedWord = "    This is a Spaced Word!      ";
            Console.WriteLine("\n\nTrimmed Word: " + spacedWord.Trim());

            // Method: Replace
            Console.WriteLine("\n\nReplaced '#' with 'Sharp': " + txt.Replace("#", "Sharp"));
        }
    }
}
