using System;

namespace DemostracionSOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("         DEMOSTRACIÓN DE PRINCIPIOS SOLID         ");
            Console.WriteLine("==================================================\n");

            // 1. Liskov Substitution Principle
            Console.WriteLine("--- 1. Liskov Substitution Principle (LSP) ---");
            var demoLsp = new DemostracionSOLIDLiskovSubstitution();
            demoLsp.Ejecutar();

            Console.WriteLine();

            // 2. Interface Segregation Principle
            Console.WriteLine("--- 2. Interface Segregation Principle (ISP) ---");
            var demoIsp = new DemostracionSOLIDInterfaceSegregation();
            demoIsp.Ejecutar();

            Console.WriteLine();

            // 3. Dependency Inversion Principle
            Console.WriteLine("--- 3. Dependency Inversion Principle (DIP) ---");
            var demoDip = new DemostracionSOLIDDependencyInversion();
            demoDip.Ejecutar();

            Console.WriteLine("\n==================================================");
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}