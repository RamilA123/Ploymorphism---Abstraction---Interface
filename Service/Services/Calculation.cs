using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{

    public class Calculation : ICalculation
    {
        public void Calculate(double num1, string ope, double num2)
        {
          
                switch (ope)
                {
                    case "+":
                        Console.WriteLine("Additon = " + (num1 + num2));
                        break;
                    case "-":
                        Console.WriteLine("Subtraction = " + (num1 - num2));
                        break;
                    case "*":
                        Console.WriteLine("Multiplication = " + (num1 * num2));
                        break;
                    case "/":
                        Console.WriteLine("Division = " + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Enter a correct operator.");
                        break;
                }
        }
    }
}
