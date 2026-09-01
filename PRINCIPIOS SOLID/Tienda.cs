using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemostracionSOLID // Dependency Inversion Principle (DIP)
{
    public class Tienda
    {
        private readonly IServicioEnvio _envio;

        public Tienda(IServicioEnvio envio)
        {
            _envio = envio;
        }

        public void RealizarVenta(string producto)
        {
            _envio.EnviarPaquete(producto);
        }
    }
}
