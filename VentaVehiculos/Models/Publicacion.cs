namespace VentaVehiculos.Models
{
    public class Publicacion
    {

        public int PublicacionId { get; set; }

        // Relaciones individuales
        public Cliente ClienteId { get; set; } = null!; // recuerden que usuario apunta a cliente id en SQL

        public Vehiculo Vehiculo { get; set; } = null!;

        // Llaves foraneas
        public int UsuarioId { get; set; } // fk

        public int VehiculoId { get; set; } // fk

        public DateTime FechaPublicacion {  get; set; }

        public bool EstadoPublicacion { get; set; }

        public string Titulo { get; set; } = null!;

        public List<Fotografia> Fotografias { get; set; } = new();

    }
}
