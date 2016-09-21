using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_NDV
{
    public interface Countable
    {
        void incementCount();
        void resetCount();
        int getCount();
        String getCountString();
    }
}
