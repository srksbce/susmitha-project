using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Nth highest or lowest number in a given series of numbers 
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] i = new int[] { 2,7,10,5,17,12};
            Array.Sort(i);
            Console.WriteLine("Highest number :" + i[i.Length - 1]);
            Console.WriteLine("Lowest number :" + i[i.Length - i.Length]);

        }
    }
}
