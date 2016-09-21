using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_NDV
{
    public class Countutil
    {
        public static void count (Countable NumCount, int topNum)
        {
            for (int i =0; i < topNum; i++)
            {
                NumCount.incementCount();
                NumCount.getCount();

                Console.WriteLine(NumCount.getCountString());
            }
        } 
    }
}
