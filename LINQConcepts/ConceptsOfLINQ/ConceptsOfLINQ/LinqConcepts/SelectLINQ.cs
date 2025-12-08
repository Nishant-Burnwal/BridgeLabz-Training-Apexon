using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsOfLINQ.LinqConcepts
{
    internal class SelectLINQ
    {
        static void Main(string[] args)
        {
            /*
            Select() is used to transform each item in a
            collection into a new form.
            */

            List<int> nums = new List<int>() { 1, 2, 3};
            var result = nums.Select(x  => x * 8);
            //Example 1: Multiply Each Number by 8
            foreach (var r in result)
                Console.WriteLine(r);

            // Convert to UpperCase(ToUpper)
            List<String> names = new List<String>() {
                "nishant",
                "amit",
                "neha"
            };

            var upperCaseNames = names.Select(name => name.ToUpper());
            foreach(var n in upperCaseNames)
                Console.WriteLine(n);
        }
    }
}
