namespace VentaVehiculos.Models
{
    public class Vehiculo
    {
        public int VehiculoId { get; set; }

        // Relaciones individuales
        public Marca Marca { get; set; } = null!;

        public TipoVehiculo TipoVehiculo { get; set; } = null!;

        // Llaves foraneas 
        public int MarcaId { get; set; } // fk

        public int TipoVehiculoId { get; set; } // fk


        public string Modelo { get; set; } = null!;

        public short Anio { get; set; } // tipo de dato short es el equivalente a smallint de sql

        public int Kilometraje { get; set; }

        public decimal Precio { get; set; }

        public string Descripcion { get; set; } = null!;

        public List<Publicacion> Publicaciones { get; set; } = new();

    }
}
