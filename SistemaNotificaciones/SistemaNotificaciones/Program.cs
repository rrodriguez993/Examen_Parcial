using System;
using SistemaNotificaciones.Models;

namespace SistemaNotificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Notificacion correo = new CorreoElectronico(
                "Su estado de cuenta ha sido generado.",
                "cliente@correo.com"
            );

            Notificacion sms = new Sms(
                "Su codigo de verificacion es 1234.",
                "55554444"
            );

            correo.Enviar();

            Console.WriteLine();

            sms.Enviar();

            Console.WriteLine();
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}