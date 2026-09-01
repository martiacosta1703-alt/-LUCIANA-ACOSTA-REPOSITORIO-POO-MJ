using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DemostracionSOLID // Dependency Inversion Principle (DIP)
{
    public class EnvioCorreo : IServicioEnvio
    {
        public void EnviarPaquete(string paquete)
        {
            Console.WriteLine($"[DIP] Enviando '{paquete}' por correo postal.");
        }
    }
}