using System;

namespace CSharp_Fundaments.OOPS
{
    public class Dog
    {
        // Instance Variables
        string name;
        string breed;
        int age;
        string color;

        public Dog(string name, string breed, int age, string color)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.color = color;
        }

        public string GetName()
        {
            return name;
        }

        public string GetBreed()
        {
            return breed;
        }

        public int GetAge()
        {
            return age;
        }

        public string GetColor()
        {
            return color;
        }

        public override string ToString()
        {
            return "My name is " + name +
                   "\nMy breed is " + breed +
                   "\nMy age is " + age +
                   "\nMy color is " + color +
                   "\nThese are the basic details.";
        }
    }

    internal class ClassAndObjectCreation
    {
        static void Main(string[] args)
        {
            Dog tuffy = new Dog("tuffy", "papillon", 5, "white");
            Console.WriteLine(tuffy.ToString());
            Console.WriteLine(tuffy.GetName() + " " + tuffy.GetAge());
        }
    }
}
