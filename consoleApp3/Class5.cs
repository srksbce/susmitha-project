using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    //Write a program to Print how many caps letters, small letters, words present in a given string 
    internal class Class5
    {
         static void Main(string[] args)
        {

            String str = "weLcome Snad";
            int upper = 0, lower = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch >= 'A' && ch <= 'Z')
                    upper++;
                else if (ch >= 'a' && ch <= 'z')
                    lower++;

            }
            Console.WriteLine("Uppercase count: " + upper);
            Console.WriteLine("Lowercase count : " + lower);

        }
    }
}

  
