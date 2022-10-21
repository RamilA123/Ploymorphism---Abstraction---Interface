using Math;
using Polymorphism_Abstraction_Interface.Models;
using Service.Services;
using System;

namespace Polymorphism_Abstraction_Interface
{
   class Program
    {
        static void Main(string[] args)
        {

            #region Task2 - Practice

            //Car car1 = new Car();
            //Console.WriteLine(car1.name);

            //Factorial factorial1 = new Factorial();
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //factorial1.CalculateFactorial(num);

            //Cat cat = new Cat();
            //cat.Name = "rerere";
            //Console.WriteLine(cat.Name);

            //Bird bird = new Bird();
            //bird.Name = "dasdsadsad";

            //Cat cat = new Cat();
            //cat.GetSound();
            //Bird bird = new Bird();
            //bird.GetSound();
            //Animal animal = new Animal();
            //animal.GetSound();

            //cat.Eat();

            //    Student student = new Student
            //    {
            //        Name = "Resul",
            //        Surname = "Hasanov",
            //        Age = 14,
            //    };

            //    Console.WriteLine(GetStudent(student, 15)); 

            //}


            //public static Student GetStudent(Student student, int age)
            //{
            //    student.Age = age;
            //    return student;
            //}

            //Student student1 = new Student();
            //student1.Test2();

            //Employee emp1 = new Employee();
            //emp1.Test2();

            //Car car1 = new Car();
            #endregion

            // Task1 - Create layer, class and interface
            Console.Write("Enter a first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter an operator: ");
            string ope = Console.ReadLine();
            Console.Write("Enter a second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Calculation cal1 = new Calculation();
            cal1.Calculate(num1, ope, num2);
        }
    }
}
