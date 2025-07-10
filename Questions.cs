using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardipzapadiya_23SOECE11020
{
    internal class Questions
    {
        public static void printtable(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " *  " + j + " : " + i * j);
                }
                Console.WriteLine();
            }

        }
    }
}
