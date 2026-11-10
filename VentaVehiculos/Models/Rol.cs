namespace VentaVehiculos.Models
{
    public class Rol
    {
        public int RolId { get; set; }

        public Rol Roles { get; set; } = null!; // Relacion individual

        public string Descripcion { get; set; } = null!;

        public List<Cliente> Clientes { get; set; } = new();
    }
}