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
            StringSplitter stringSplitter = new StringSplitter();
            var splitedString = stringSplitter.SplitString(text);
            Console.Write("[");
            foreach (var item in splitedString)
            {
                Console.Write("\"{0}\" ", item);
            }
            Console.Write("]");

            Console.ReadKey();

        }
    }
}
