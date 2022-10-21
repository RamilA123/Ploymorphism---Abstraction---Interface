using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_Abstraction_Interface
{
    public interface IUser
    {
        void Login(string usernam, string password);

        string SendEmail(string name);
    }
}
