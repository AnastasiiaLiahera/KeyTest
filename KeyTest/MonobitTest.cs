using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyTest
{
    public class MonobitTest
    {
        public string Test (string s) 
        {
            int zero = 0;
            int one = 0;
            foreach (char c in s)
            {
                if(c == '0')
                {
                    zero++;
                }
                else
                {
                    one++;
                }
            }
            if (zero > 9654 || one < 10346)
            {
                return "random"; 
            }
            return "not random";
        }
    }
}
