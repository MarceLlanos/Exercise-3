using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class SplitString
    {
        public string StringSplit(string text)
        {
            
            if (text.Length % 2 == 1)
            {
                text += "_";
            }
            for (int i = 0; i < text.Length; i += 2)
            {
                Console.Write("\"{0}{1}\" ", text[i], text[i + 1]);
            }
            return text;
        }
    }
}
