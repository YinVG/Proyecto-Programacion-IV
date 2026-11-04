namespace VentaVehiculos.Models
{
    public class Fotografia
    {

        public int FotografiaId { get; set; }

        // Relaciones individuales

        public Publicacion Publicacion { get; set; } = null!;
        
        // llave foranea
        public int PublicacionId { get; set; } // fk

        public string RutaFotografia { get; set; } = null!;


    }
}
