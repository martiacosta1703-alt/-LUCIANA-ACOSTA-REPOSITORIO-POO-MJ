using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DemostracionSOLID // Interface Segregation Principle (ISP)
{
    public class Piloto : IConductorAuto, IPilotoAvion
    {
        public void ConducirAuto()
        {
            Console.WriteLine("[ISP] El piloto conduce al aeropuerto.");
        }

        public void VolarAvion()
        {
            Console.WriteLine("[ISP] El piloto despega el avión.");
        }
    }
}
