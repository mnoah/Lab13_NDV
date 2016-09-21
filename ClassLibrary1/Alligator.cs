using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_NDV
{
    public class Alligator: Countable
    {
        private int Counting;

        
        public void incementCount()
        {
            Counting++;
        }
      

        public void resetCount()
        {
            Counting = 0;
        }

        public int getCount()
        {
            return Counting;
        }

        public String getCountString()
        {
            return Counting + "" + " Alligator";
        }
    }
}
