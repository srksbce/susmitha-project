using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class2
    {
        public static void Main()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("addition={2}", num1, num2, num1 + num2);
            Console.WriteLine("subtraction = {2}", num1, num2, num1 - num2);
            Console.WriteLine("multiplication = {2}", num1, num2, num1 * num2);
            Console.WriteLine("divison = {2}", num1, num2, num1 / num2);
            
        }
    }
}
