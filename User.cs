using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface
{
    public class User : IUser
    {
        public void Login(string usernam, string password)
        {
            Console.WriteLine("Login oldu.");
        }

        public string SendEmail(string name)
        {
            return "Email gonderildi.";
        }
    }
}
