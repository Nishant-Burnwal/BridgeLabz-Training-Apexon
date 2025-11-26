using System;

namespace CSharp_Fundaments.OOPS_Concepts
{
    class Animal
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog Barks");
        }
    }

    class Cat : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Cat Meows");
        }
    }

    internal class PolymorphismRuntime
    {
        static void Main(string[] args)
        {
            Animal animal;
            animal = new Dog();
            animal.sound(); // Dog barks

            animal = new Cat();
            animal.sound(); // Cat meows



        }
    }
}
