using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Class4
    {
        //Write a program to convert first letter of each word into upper case and others into lower case from the given string 
       
            static void Main(string[] args)
            {

                string str = "hello welcome";

                if (str.Length == 0)
                    System.Console.WriteLine("null");
                else if (str.Length == 1)
                    System.Console.WriteLine(char.ToUpper(str[0]));
                else
                    System.Console.WriteLine(char.ToUpper(str[0]) + str.Substring(1));
            }
        }
    }


    
  
