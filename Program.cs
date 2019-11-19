using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Console.Write("Input a text:");
            string text;
            text = Console.ReadLine();
            SplitString splitString = new SplitString();
            splitString.StringSplit(text);
            Console.ReadKey();

        }
    }
}
