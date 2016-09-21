using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13_NDV
{
    class CountTestApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting alligators..." + "\n");
            Countable Gator = new Alligator();
            Countutil.count(Gator, 3);


            Console.WriteLine( );
            Console.WriteLine("Counting the sheep...." + "\n");

            Countable sheep = new Sheep();
            Sheep sheep1 = new Sheep();

            sheep1.resetCount();
            sheep1.SheepsName("Blackie");
            Countutil.count(sheep1, 2);

            Console.WriteLine();


            Sheep sheep2 = (Sheep) sheep1.Clone();
            sheep2.resetCount();
            sheep2.SheepsName("Dolly");
            Countutil.count(sheep2, 3);


            Console.WriteLine();

            sheep1.resetCount();
            sheep1.SheepsName("Blankie");
            Countutil.count(sheep1, 1);




            




           
        }
    }
}
