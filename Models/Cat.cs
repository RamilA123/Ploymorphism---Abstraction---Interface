using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface.Models
{
    class Cat : Animal
    {

        public override void GetSound()
        {
            Console.WriteLine("Cat sound");
        }


    }
}
