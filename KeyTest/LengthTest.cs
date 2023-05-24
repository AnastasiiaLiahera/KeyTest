using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyTest
{
    public class LengthTest
    {
        public string Test(string s)
        {
            int series01 = 0;
            int series02 = 0;
            int series03 = 0;
            int series04 = 0;
            int series05 = 0;
            int series06 = 0;

            int series11 = 0;
            int series12 = 0;
            int series13 = 0;
            int series14 = 0;
            int series15 = 0;
            int series16 = 0;

            int char0 = 0;

            foreach (char c in s)
            {
                if (c == '0')
                {
                    char0++;
                }
                else
                {
                    if (char0 != 0)
                    {
                        if (char0 == 1)
                        {
                            series01++;
                            char0 = 0;
                        }
                        else if (char0 == 2)
                        {
                            series02++;
                            char0 = 0;
                        }
                        else if (char0 == 3)
                        {
                            series03++;
                            char0 = 0;
                        }
                        else if (char0 == 4)
                        {
                            series04++;
                            char0 = 0;
                        }
                        else if (char0 == 5)
                        {
                            series05++;
                            char0 = 0;
                        }
                        else if (char0 == 6)
                        {
                            series06++;
                            char0 = 0;
                        }
                    }
                }
            }
            foreach (char c in s)
            {
                if (c == '1')
                {
                    char0++;
                }
                else
                {
                    if (char0 != 0)
                    {
                        if (char0 == 1)
                        {
                            series11++;
                            char0 = 0;
                        }
                        else if (char0 == 2)
                        {
                            series12++;
                            char0 = 0;
                        }
                        else if (char0 == 3)
                        {
                            series13++;
                            char0 = 0;
                        }
                        else if (char0 == 4)
                        {
                            series14++;
                            char0 = 0;
                        }
                        else if (char0 == 5)
                        {
                            series15++;
                            char0 = 0;
                        }
                        else if (char0 == 6)
                        {
                            series16++;
                            char0 = 0;
                        }
                    }
                }
            }
            if ((series01 > 2267 && series01 < 2733) && (series02 > 1079 && series02 < 1421) && (series03 > 502 && series03 < 748) && (series04 > 223 && series04 < 402) && (series05 > 90 && series05 < 223) && (series06 > 90 && series06 < 223) && (series11 > 2267 && series11 < 2733) && (series12 > 1079 && series12 < 1421) && (series13 > 502 && series13 < 748) && (series14 > 223 && series14 < 402) && (series15 > 90 && series15 < 223) && (series16 > 90 && series16 < 223))
            {
                return "random";
            }
            return "not random";

        }
    }
}
