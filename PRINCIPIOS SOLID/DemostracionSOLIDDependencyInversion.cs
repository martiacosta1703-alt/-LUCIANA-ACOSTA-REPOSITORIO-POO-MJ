using System;

namespace DemostracionSOLID
{
    public class DemostracionSOLIDDependencyInversion
    {
        // 1. Abstracción del módulo de bajo nivel
        public interface INotificador
        {
            void EnviarMensaje(string mensaje);
        }

        // 2. Implementaciones concretas
        public class ServicioEmail : INotificador
        {
            public void EnviarMensaje(string mensaje)
            {
                Console.WriteLine($"[DIP] Enviando Email: {mensaje}");
            }
        }

        public class ServicioSMS : INotificador
        {
            public void EnviarMensaje(string mensaje)
            {
                Console.WriteLine($"[DIP] Enviando SMS: {mensaje}");
            }
        }

        // 3. Módulo de alto nivel que depende de la abstracción INotificador
        public class GestorNotificaciones
        {
            private readonly INotificador _notificador;

            public GestorNotificaciones(INotificador notificador)
            {
                _notificador = notificador;
            }

            public void NotificarUsuario(string mensaje)
            {
                _notificador.EnviarMensaje(mensaje);
            }
        }

        // Método de ejecución de la demostración
        public void Ejecutar()
        {
            INotificador servicioEmail = new ServicioEmail();
            GestorNotificaciones gestorEmail = new GestorNotificaciones(servicioEmail);
            gestorEmail.NotificarUsuario("Bienvenido a la plataforma.");

            INotificador servicioSms = new ServicioSMS();
            GestorNotificaciones gestorSms = new GestorNotificaciones(servicioSms);
            gestorSms.NotificarUsuario("Tu código de verificación es 1234.");
        }
    }
}