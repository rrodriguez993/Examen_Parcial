using System;

namespace SistemaNotificaciones.Models
{
    public class Sms : Notificacion
    {
        public string NumeroTelefono { get; set; }

        public Sms(string mensaje, string numeroTelefono)
            : base(mensaje)
        {
            NumeroTelefono = numeroTelefono;
        }

        public override void Enviar()
        {
            Console.WriteLine("===== SMS =====");
            Console.WriteLine("Numero: " + NumeroTelefono);
            Console.WriteLine("Mensaje: " + Mensaje);
        }
    }
}