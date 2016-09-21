using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_NDV
{
    public class Sheep: Countable, ICloneable
    {
        private int allSheep = 0;
        private String sheeps;


        public void SheepsName(String Sheep)
        {
            sheeps = Sheep;
        
        }

        public String getSheepsName()
        {
            return sheeps;
        }

        public Object Clone()
        {
            resetCount();
            Sheep clone = new Sheep();
            return clone;


        }
        



        public void incementCount()
        {
            allSheep = allSheep + 1;
        }

        public void resetCount()
        {
            allSheep = 0;
        }

        public int getCount()
        {
            return allSheep;
        }

        public String getCountString()
        {
            return getCount() + " " + getSheepsName();
        }

       
    }
}
