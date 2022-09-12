using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class9
    {
        //Write a C# program to Remove Duplicate characters from a given String 
        static void Main(string[] args)
        {
            Console.WriteLine("enter string");
            string str = Console.ReadLine();
            string result = "";
            result = result + str[0];
            int i;
            for (i= 1;i < str.Length;i++)
                {
                if (str[i - 1] != str[i])
                    result = result + str[i];
            }
            Console.WriteLine(result);
        }

    }
}
