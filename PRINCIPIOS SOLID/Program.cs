using System;
using System.Collections.Generic;


namespace DemostracionSOLID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== DEMOSTRACIÓN PRINCIPIOS SOLID ===\n");

            // --- 1. Liskov Substitution Principle (LSP) ---
            Console.WriteLine("--- 1. LSP (Sustitución de Liskov) ---");
            List<Impresora> impresoras = new List<Impresora>
            {
                new ImpresoraTinta { Modelo = "Epson EcoTank" },
                new ImpresoraLaser { Modelo = "HP LaserJet" }
            };

            foreach (var impresora in impresoras)
            {
                impresora.ImprimirDocumento("Tarea_POO.pdf");
            }

            Console.WriteLine();

            // --- 2. Interface Segregation Principle (ISP) ---
            Console.WriteLine("--- 2. ISP (Segregación de Interfaces) ---");
            Chofer chofer = new Chofer();
            chofer.ConducirAuto();

            Piloto piloto = new Piloto();
            piloto.ConducirAuto();
            piloto.VolarAvion();

            Console.WriteLine();

            // --- 3. Dependency Inversion Principle (DIP) ---
            Console.WriteLine("--- 3. DIP (Inversión de Dependencias) ---");
            Tienda tienda1 = new Tienda(new EnvioCorreo());
            tienda1.RealizarVenta("Libro");

            Tienda tienda2 = new Tienda(new EnvioDron());
            tienda2.RealizarVenta("Celular");

            Console.WriteLine("\n¡Ejecución completada con éxito!");
        }
    }
}
