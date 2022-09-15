using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class10
    {
        static void Main(string[] args) {
        }

        public  void ReverseString(string Input)
        {
            Console.Write("Enter string: ");
            char[] stringArray = Input.ToCharArray();

            string reverse = String.Empty;

            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                reverse += stringArray[i];
            }

            Console.WriteLine(reverse);

            Console.ReadLine();
        }
    }
}
