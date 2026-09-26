namespace SistemaNotificaciones.Models
{
    public abstract class Notificacion
    {
        public string Mensaje { get; set; }

        public Notificacion(string mensaje)
        {
            Mensaje = mensaje;
        }

        public abstract void Enviar();
    }
}