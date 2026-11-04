namespace VentaVehiculos.Models
{
    public class TipoVehiculo
    {

        public int TipoVehiculoId { get; set; }

        public string Nombre { get; set; } = null!;

        public List<Vehiculo> Vehiculos { get; set; } = new();

    }
}

