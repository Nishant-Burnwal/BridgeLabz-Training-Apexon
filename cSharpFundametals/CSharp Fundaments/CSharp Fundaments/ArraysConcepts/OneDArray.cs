using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.ArraysConcepts
{
    internal class OneDArray
    {
        static void Main(string[] args)
        {
            // Declaring String Type Array
            String[] weekDays = { "Mon", "Tue", "Wed", "Thru", "Fri", "Sat", "Sun" };

            foreach(String day in weekDays)
            { 
                Console.WriteLine($"Day is {day}");
                if (day == "Sun")
                {
                    Console.WriteLine("Enjoy the Weekend");
                }
            }
        }
    }
}
