using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemostracionSOLID
{
    public abstract class Impresora // Liskov Substitution Principle (LSP)
    {
        public string Modelo { get; set; } = string.Empty;
        public abstract void ImprimirDocumento(string documento);
    }
}