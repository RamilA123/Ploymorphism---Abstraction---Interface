using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    class Employee : Person
    {
        public override void Test2()
        {
            Console.WriteLine("Employee Test");
        }
    }
}
