// See https://aka.ms/new-console-template for more information
using System;

namespace simple_User_Calculator // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
           double num1, num2, ans;
           char Operator;
           Console.WriteLine("=====Simple user Calculator=====");

           Console.WriteLine("Enter your first number: ");
           num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Enter your second number: ");
           num2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("\t");

           Console.WriteLine("======Choose Arithmetic Operator=====");

           Console.WriteLine("A. Addition, S. Subtraction, D. Division, M. Multiplication, O. Modulo");

           Console.WriteLine("Enter your Operator: ");
           Operator = Console.ReadKey().KeyChar;  // Proper calling char variable.
 
           if(Operator == 'A'){     
           Console.WriteLine(" It's Addition");
           ans = num1 + num2;
           Console.WriteLine("Answer is: " + ans);

           } else if(Operator == 'S'){
           Console.WriteLine(" It's Subtraction");
           ans = num1 - num2;
           Console.WriteLine("Answer is: " + ans);

           } else if(Operator == 'D'){
           Console.WriteLine(" It's Division"); 
           ans = num1 / num2;
           Console.WriteLine("Answer is: " + ans);

           } else if(Operator == 'M'){
           Console.WriteLine(" It's Multiplication");
           ans = num1 * num2;
           Console.WriteLine("Answer is: " + ans);
           
           } else if(Operator == 'O'){
           Console.WriteLine(" It's Modulo");
           ans = num1 % num2;
           Console.WriteLine("Answer is: " + ans);
           } else {
            Console.WriteLine(" Invalid Operator");
           }
       
        }
    }
}
