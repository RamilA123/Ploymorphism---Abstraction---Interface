using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    class Bird : Animal
    {
        public override void GetSound()
        {
            Console.WriteLine("Bird sound");
        }
    }
}
