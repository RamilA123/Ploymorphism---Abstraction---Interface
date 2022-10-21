using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services.Interfaces
{
    public interface ICalculation
    {
        void Calculate(double num1, string ope, double num2);
    }
}
