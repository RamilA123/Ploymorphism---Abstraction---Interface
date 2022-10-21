using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
   public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public void Test()
        {
            Console.WriteLine("Test");
        }

        public abstract void Test2();  
    }

   
}
