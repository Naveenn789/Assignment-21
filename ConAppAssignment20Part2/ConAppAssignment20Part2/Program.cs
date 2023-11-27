using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment20Part2
{
    public delegate T Operation<T>(T x,T y); 
    public class Program
    {
        static T Add<T>(T x, T y)=>(dynamic)x + y;
        static T Sub<T>(T x, T y) => (dynamic)x - y;
        static T Multi<T>(T x, T y) => (dynamic)x * y;
        static T Div<T>(T x, T y) => (dynamic)x / y;
        static void Main(string[] args)
        {
            Operation<double> Del1 = new Operation<double>(Add);
            Operation<double> Del2 = new Operation<double>(Sub);
            Operation<double> Del3 = new Operation<double>(Multi);
            Operation<double> Del4 = new Operation<double>(Div);
            Console.WriteLine("Enter First Number");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Choose which operation you want to perform on the Above numbers. \n1.Addition \n2.Subractionc\n3.Multiplication. \n4.Division");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"Addition of {num1} and {num2} is " + Del1(num1, num2));
                    break;
                case 2:
                    Console.WriteLine($"Subraction of {num1} and {num2} is " + Del2(num1, num2));
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of {num1} and {num2} is " + Del3(num1, num2));
                    break;
                case 4:
                    Console.WriteLine($"Division of {num1} and {num2} is " + Del4(num1, num2));
                    break;
                default:
                    Console.WriteLine("You chosse invalid operation !!!");
                    break;
            }
            Console.ReadKey();

        }
    }
}
