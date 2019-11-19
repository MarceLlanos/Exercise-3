using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class StringSplitter
    {
        public List<string> SplitString(string text)
        {
            var result = new List<string>();

            if (text.Length % 2 == 1)
            {
                text += "_";
            }
      
       
            for (int i = 0; i < text.Length; i += 2)
            {
               
                result.Add(string.Format("{0}{1}",text[i], text[i + 1]));
            }

            return result;
        }
    }
}
