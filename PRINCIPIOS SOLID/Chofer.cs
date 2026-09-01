using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DemostracionSOLID // Interface Segregation Principle (ISP)
{
    public class Chofer : IConductorAuto
    {
        public void ConducirAuto()
        {
            Console.WriteLine("[ISP] El chófer conduce el auto.");
        }
    }
}