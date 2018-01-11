using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample
{
    public partial class Car
    {
        public void Drive(int speed)
        {
            Console.WriteLine("Driving at speed "+ speed);
        }
    }

    public partial class Car
    {
        public void Break()
        {
            Console.WriteLine("Stopping car");
        }
    }
}
