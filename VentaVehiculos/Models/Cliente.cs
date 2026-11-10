namespace VentaVehiculos.Models
{
    public class Cliente
    {

        public int ClienteId { get; set; }

        public int RollId { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido1 { get; set; } = null!;

        public string Apellido2 { get; set; } = null!;

        public string Correo { get; set; } = null!;

        public DateTime FechaRegistro { get; set; }

        public bool Estado { get; set; }

        public List<Publicacion> Publicaciones { get; set; } = new(); // propiedad de navegacion permite acceder a las publicaciones relacionadas con este cliente 


    }
}
