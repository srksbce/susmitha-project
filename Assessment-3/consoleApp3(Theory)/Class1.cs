using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    // call by value a copy of variable is passed
    class Sample
    {
        
        public void add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("addition of Values are :{0}\t{1}", x, y);
        }

        //call by reference a varaiable itself is passed,a ref keyword is used to pass the value
        public void add1(ref int x, ref int y)
        {
           int z1=x + y;
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Sample sample = new Sample();
            sample.add(a, b);
            sample.add1(ref a, ref b);
            Console.WriteLine(" addition of Values are :{0}\t{1}", a, b);
        }
    }
}

