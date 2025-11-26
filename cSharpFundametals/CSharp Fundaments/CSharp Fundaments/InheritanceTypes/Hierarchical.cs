using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 
 *    A
     / \
    B   C

 */

namespace CSharp_Fundaments.InheritanceTypes
{
    class Animal
    {
        public void Eat() => Console.WriteLine("Eating");
    }

    class Dog: Animal
    {
        public void Bark() => Console.WriteLine("Dog is Barking");
    }

    class Cat: Animal
    {
        public void Meow() => Console.WriteLine("Cat's Meows");
    }
    internal class Hierarchical
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Dog tuffy = new Dog();
            Cat cat = new Cat();
            tuffy.Eat(); //Eating
            tuffy.Bark(); // Dog is Barking
            cat.Eat(); //Eating
            cat.Meow(); // Cat's Meows
            Console.WriteLine("C# doesn't allow Multiple Inheritance but allows iterface: ");
            Console.WriteLine("interface A { }\r\ninterface B { }\r\nclass C : A, B  (Correct if A and B are interfaces)\r\n");
        }
    }
}
