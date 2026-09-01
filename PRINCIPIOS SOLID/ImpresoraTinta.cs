using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace DemostracionSOLID // Liskov Substitution Principle (LSP)
{
    public class ImpresoraTinta : Impresora
    {
        public override void ImprimirDocumento(string documento)
        {
            Console.WriteLine($"[LSP] Impresora de tinta ({Modelo}) imprimiendo a color: {documento}");
        }
    }
}