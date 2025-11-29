using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundaments.Strings
{
    internal class StringArray
    {
      public static void Calculate(int a,int b)
        {
            Console.WriteLine( a + b);
        }
     
      public static void Main(string[] args) 
        {
            String[] str_arr = new string[3];

            str_arr[0] = "C#";
            str_arr[1] = "String";
            str_arr[2] = "Array";

            for(int i = 0; i < str_arr.Length; i++)
            {
                Console.WriteLine("Value at Index position: " + i + " is " + str_arr[i]);
            }
        }
    }
}
