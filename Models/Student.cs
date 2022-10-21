using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    public class Student : Person
    {
        public override void Test2()
        {
            Console.WriteLine("Test Student");
        }
    }
}
