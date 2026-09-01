using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemostracionSOLID // Dependency Inversion Principle (DIP)
{
    public interface IServicioEnvio
    {
        void EnviarPaquete(string paquete);
    }
}