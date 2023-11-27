using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment21Part1
{
    public delegate int ArithmeticOperation(int num1, int num2);
    public class Program
    {
        public static int Add(int num1,int num2)
        {
            return num1+num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multi(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
        static void Main(string[] args)
        {
            ArithmeticOperation del1 = new ArithmeticOperation(Add);
            ArithmeticOperation del2 = new ArithmeticOperation(Sub);
            ArithmeticOperation del3 = new ArithmeticOperation(Multi);
            ArithmeticOperation del4 = new ArithmeticOperation(Div);

            Console.WriteLine("Enter First Number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose which operation you want to perform on the Above numbers. \n1.Addition \n2.Subractionc\n3.Multiplication. \n4.Division");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine($"Addition of {num1} and {num2} is "+del1(num1, num2));
                    break;
                case 2:
                    Console.WriteLine($"Subraction of {num1} and {num2} is "+ del2(num1, num2));
                    break;
                case 3:
                    Console.WriteLine($"Multiplication of {num1} and {num2} is "+ del3(num1, num2));
                    break;
                case 4:
                    Console.WriteLine($"Division of {num1} and {num2} is "+ del4(num1, num2));
                    break;
                default:
                    Console.WriteLine("You chosse invalid operation !!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
