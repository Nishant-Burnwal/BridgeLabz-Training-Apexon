using System;
using System.Collections.Generic;
using System.Linq;

namespace ConceptsOfLINQ.LINQInAHour
{
    internal class BasicOfLINQ
    {
        static void Main(string[] args)
        {
            // LINQ can query Collections, Databases, XML, Objects using uniform syntax.
            // Examples: x => x * x, (x, y) => x + y

            List<int> nums = new List<int>()
            {
                23, 25, 654, 656, 346, 7676, 676, 767, 43, 49
            };

            // 1. Where (Filter)
            var evens = nums.Where(n => n % 2 == 0);

            Console.WriteLine("Even Numbers:");
            foreach (var evennum in evens)
                Console.WriteLine(evennum);

            // 2. Select (Projection)
            var squares = nums.Select(x => x * x);

            Console.WriteLine("\nSquares of Numbers:");
            foreach (var square in squares)
                Console.WriteLine(square);

            // 3. OrderBy / OrderByDescending
            var sorted = nums.OrderBy(n => n);
            var sortedDesc = nums.OrderByDescending(n => n);

            Console.WriteLine("\nAscending Order:");
            foreach (var n in sorted)
                Console.WriteLine(n);

            Console.WriteLine("\nDescending Order:");
            foreach (var n in sortedDesc)
                Console.WriteLine(n);

            // 4. First / FirstOrDefault
            var first = nums.First(); // throws if empty
            Console.WriteLine($"\nFirst Element: {first}");

            var safe = nums.FirstOrDefault(); // safe even if empty
            Console.WriteLine($"FirstOrDefault: {safe}");

            /*
             * 5. Single / SingleOrDefault
             * Used when exactly ONE element should match the condition.
             * Example:
             * var user = users.Single(u => u.Id == 5);
             * please refer "IntermediateOfLINQ.cs"
             */

            // 6. Take / Skip -> Pagination
            var page5 = nums.Take(5);  // first 5 elements
            var skip5 = nums.Skip(5);  // remaining elements after skipping 5

            Console.WriteLine("\nFirst 5 Elements:");
            foreach (var x in page5)
                Console.WriteLine(x);

            Console.WriteLine("\nElements After Skipping 5:");
            foreach (var x in skip5)
                Console.WriteLine(x);

            // 7. Any / All
            bool hasEven = nums.Any(n => n % 2 == 0);
            bool allEven = nums.All(n => n % 2 == 0);

            Console.WriteLine($"\nHas Even Numbers? {hasEven}");
            Console.WriteLine($"Are All Even? {allEven}");

            // 8. Aggregate Functions: Count / Sum / Min / Max / Average
            int c = nums.Count();
            int s = nums.Sum();
            int minOfNums = nums.Min();
            int maxOfNums = nums.Max();
            double averageOfNums = nums.Average(); // must be double

            Console.WriteLine($"\nCount: {c}");
            Console.WriteLine($"Sum: {s}");
            Console.WriteLine($"Minimum: {minOfNums}");
            Console.WriteLine($"Maximum: {maxOfNums}");
            Console.WriteLine($"Average: {averageOfNums}");

            // 9. Distinct -> Unique Values
            Console.Write("\nUnique Values: ");
            Console.Write("\n");
            var unique = nums.Distinct();
            foreach (var x in unique)
                Console.WriteLine(x);

            // 10. GroupBy -> Most asked in interviews(V.V.I)
            // Please refer "GroupByDepartmentLIQ.cs"

            // 11. Join -> Very Important for interviews
            // Please refer "JoinLINQ.cs" 

            // 12. ToList(), ToArray()
            Console.WriteLine("\nNumbers Greater than 100: ");
            var listGreaterThan100 = nums.Where(n => n > 100).ToList();

            foreach (var x in listGreaterThan100)
                Console.WriteLine(x);
        }
    }
}