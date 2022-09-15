using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Write a method with 2 parameters(sorting type, sort data) and return the sorted data
    internal class Class8
    {
        static void Main(string[] args)
        {
            var nums = new List<int> { 2, 1, 8, 0, 4, 3, 5, 7, 9 };

            nums.Sort();
            Console.WriteLine(string.Join(",", nums));

            nums.Reverse();
            Console.WriteLine(string.Join(",", nums));
        }
    }
}
