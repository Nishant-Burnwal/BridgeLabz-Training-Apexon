using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConceptsOfLINQ.LINQInAHour
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class IntermediateOfLINQ
    {
        static void Main(string[] args)
        {
            var users = new List<User>()
            {
                new User {Id = 1, Name = "Nishant"},
                new User {Id = 5, Name = "Neha"},
                new User {Id = 10, Name = "Amit"}
            };

            // 5. Single /  SingleOrDefault
            //Used when only ONE element should exist.

            var user = users.Single(u => u.Id == 1);
            Console.WriteLine(user.Name); // Nishant
        }
    }
}
