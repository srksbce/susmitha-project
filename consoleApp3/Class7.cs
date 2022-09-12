using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp3.Class7;

namespace ConsoleApp3
{
    internal class Class7
    {
        //method overloading=>it creates multiple methods in a class with same names with different parameters
       
            public int Sum(int x, int y)
            {
                return x + y;
            }
            public int Sum(int x, int y, int z)
            {
                return x + y + z;
            }
            public float Sum(float x, float y)
            {
                return x + y;
            }

        //method overriding=>same name with same parameters in base class and derived class
        //overriding method can be achieved by using inheritance, virtual/override keywords are used.
        public class Salary
        {
            public virtual int balance()
            {
                return 200;
            }
        }
        public class Amount : Salary
        {

            public override int balance()
            {
                return 500;
            }
        }
    }
    }