using Microsoft.EntityFrameworkCore;
using VentaVehiculos.Models;

namespace VentaVehiculos.Data
{
    // herencia nuestra clase hereda las funcionalidades de DbContext de net 10
    public class VentaVehiculosDbContext : DbContext
    {
        // constructor recibe las opciones de configuración del contexto
        public VentaVehiculosDbContext(DbContextOptions<VentaVehiculosDbContext> options) : base(options)
        {
            
            // propiedades futuras del constructor
        }

        // DbSet para representa las entidades que administra EF Core.

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Fotografia> Fotografias { get; set; }

        public DbSet<Marca> Marcas { get; set; }

        public DbSet<Publicacion> Publicaciones { get; set; }

        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }

    }
}