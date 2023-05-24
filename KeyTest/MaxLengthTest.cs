using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyTest
{
    public class MaxLengthTest
    {
        public string Test(string s) 
        { 
            int max0 = 0;
            int max00 = 0;
            int max1 = 0;
            int max11 = 0;

            foreach (char c in s)
            {
                if(c == '0')
                {
                    max0++;
                }
                else
                {
                    if(max0 != 0)
                    {
                        if(max0 > max00)
                        {
                            max00 = max0;
                            max0 = 0;
                        }
                    }
                }
            }
            foreach (char c in s)
            {
                if (c == '1')
                {
                    max1++;
                }
                else
                {
                    if (max1 != 0)
                    {
                        if (max1 > max11)
                        {
                            max11 = max1;
                            max1 = 0;
                        }
                    }
                }
            }
            if (max11 > 36 || max00 > 36)
            {
                return "not random";
            }
            return "random";
        }

    }
}
