namespace VentaVehiculos.Models
{
    public class Marca
    {

       public int MarcaId { get; set; }

       public string Nombre { get; set; } = null!;

       public List<Vehiculo> Vehiculos { get; set; }  = new();

    }
}
