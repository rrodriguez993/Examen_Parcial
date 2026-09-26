using System;

namespace SistemaNotificaciones.Models
{
    public class CorreoElectronico : Notificacion
    {
        public string DireccionCorreo { get; set; }

        public CorreoElectronico(string mensaje, string direccionCorreo)
            : base(mensaje)
        {
            DireccionCorreo = direccionCorreo;
        }

        public override void Enviar()
        {
            Console.WriteLine("===== CORREO ELECTRONICO =====");
            Console.WriteLine("Destinatario: " + DireccionCorreo);
            Console.WriteLine("Mensaje: " + Mensaje);
        }
    }
}