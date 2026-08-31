using System;
using System.Collections.Generic;

namespace DemostracionSOLID
{
    public class DemostracionSOLIDLiskovSubstitution
    {
        // 1. Abstracción base
        public abstract class ElementoProcesable
        {
            public string Nombre { get; set; } = string.Empty;
            public abstract void Procesar();
        }

        // 2. Subclase 1
        public class ArchivoTexto : ElementoProcesable
        {
            public override void Procesar()
            {
                Console.WriteLine($"[LSP] Leyendo archivo de texto: {Nombre}");
            }
        }

        // 3. Subclase 2 (Sustituible sin romper la ejecución)
        public class ArchivoZip : ElementoProcesable
        {
            public override void Procesar()
            {
                Console.WriteLine($"[LSP] Descomprimiendo y procesando archivo ZIP: {Nombre}");
            }
        }

        // Método de ejecución de la demostración
        public void Ejecutar()
        {
            List<ElementoProcesable> elementos = new List<ElementoProcesable>
            {
                new ArchivoTexto { Nombre = "reporte.txt" },
                new ArchivoZip { Nombre = "backup.zip" }
            };

            foreach (var elemento in elementos)
            {
                elemento.Procesar();
            }
        }
    }
}