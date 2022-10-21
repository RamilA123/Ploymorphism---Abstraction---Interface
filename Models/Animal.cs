using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    class Animal
    {
        public string Name { get; set; }

        public virtual void GetSound()
        {
            Console.WriteLine("Animal sound");
        }

        public void Eat()
        {
            Console.WriteLine("Animal eating.");
        }

        public void Eat(string t)
        {
            Console.WriteLine(t);
        }
        public void Eat(string t, string v)
        {
            Console.WriteLine(t + " " + v);
        }
    }
}
