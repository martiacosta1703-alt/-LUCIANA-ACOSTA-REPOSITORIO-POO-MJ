using System;

namespace DemostracionSOLID
{
    public class DemostracionSOLIDInterfaceSegregation
    {
        // 1. Interfaces segregadas
        public interface IImprimible
        {
            void Imprimir(string documento);
        }

        public interface IEscanetable
        {
            void Escanear(string documento);
        }

        // 2. Implementación simple (solo implementa lo que necesita)
        public class ImpresoraBasica : IImprimible
        {
            public void Imprimir(string documento)
            {
                Console.WriteLine($"[ISP] Impresora básica imprimiendo: {documento}");
            }
        }

        // 3. Implementación multifuncional (implementa ambas)
        public class ImpresoraMultifuncional : IImprimible, IEscanetable
        {
            public void Imprimir(string documento)
            {
                Console.WriteLine($"[ISP] Multifuncional imprimiendo: {documento}");
            }

            public void Escanear(string documento)
            {
                Console.WriteLine($"[ISP] Multifuncional escaneando: {documento}");
            }
        }

        // Método de ejecución de la demostración
        public void Ejecutar()
        {
            IImprimible basica = new ImpresoraBasica();
            basica.Imprimir("Factura.pdf");

            ImpresoraMultifuncional multi = new ImpresoraMultifuncional();
            multi.Imprimir("Contrato.pdf");
            multi.Escanear("DocumentoIdentidad.pdf");
        }
    }
}