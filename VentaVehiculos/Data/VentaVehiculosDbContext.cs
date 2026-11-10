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

        public DbSet<Rol> Roles { get; set; }

        public DbSet<Publicacion> Publicaciones { get; set; }

        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }

        public DbSet<Vehiculo> Vehiculos { get; set; }


        // metodo para aplicar fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder) //modelBuilder: objeto para configurar el modelo
        {
            base.OnModelCreating(modelBuilder);

            // configuracion de las propiedades de cada entidad
            // estructurados en bloques {} para mejor orden de las propiedades


            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(c => c.ClienteId);
                entity.HasOne(c => c.Rol).WithMany(r => r.Clientes).HasForeignKey(c => c.RolId);
                entity.Property(c => c.Nombre).HasMaxLength(20);
                entity.Property(c => c.Apellido1).HasMaxLength(20);
                entity.Property(c => c.Apellido2).HasMaxLength(20);
                entity.Property(c => c.Correo).HasMaxLength(100);
                entity.HasIndex(c => c.Correo).IsUnique();
                entity.Property(c => c.FechaRegistro).HasColumnType("datetime2");
                entity.Property(c => c.Estado).HasColumnType("bit");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.HasKey(m => m.MarcaId);
                entity.Property(m => m.Nombre).HasMaxLength(20);

            });

            modelBuilder.Entity<TipoVehiculo>(entity =>
            {
                entity.HasKey(t => t.TipoVehiculoId);
                entity.Property(t => t.Nombre).HasMaxLength(50);

            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(r => r.RolId);
                entity.Property(r => r.Descripcion).HasMaxLength(50);
                entity.HasIndex(r => r.Descripcion).IsUnique();
            });

            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.HasKey(v => v.VehiculoId);
                entity.HasOne(v => v.Marca).WithMany(m => m.Vehiculos).HasForeignKey(v => v.MarcaId);
                entity.HasOne(v => v.TipoVehiculo).WithMany(t => t.Vehiculos).HasForeignKey(v => v.TipoVehiculoId);
                entity.Property(v => v.Modelo).HasMaxLength(20);
                entity.Property(v => v.Anio).HasColumnType("smallint");
                entity.Property(v => v.Kilometraje).HasColumnType("int");
                entity.Property(v => v.Precio).HasColumnType("decimal(12,2)");
                entity.Property(v => v.Descripcion).HasMaxLength(300);

            });

            modelBuilder.Entity<Publicacion>(entity =>
            {
                entity.HasKey(p => p.PublicacionId);
                entity.HasOne(p => p.Cliente).WithMany(c => c.Publicaciones).HasForeignKey(p => p.ClienteId);
                entity.HasOne(p => p.Vehiculo).WithMany(v => v.Publicaciones).HasForeignKey(p => p.VehiculoId);
                entity.Property(p => p.FechaPublicacion).HasColumnType("datetime2");
                entity.Property(p => p.EstadoPublicacion).HasColumnType("bit");
                entity.Property(p => p.Titulo).HasMaxLength(50);




            });

            modelBuilder.Entity<Fotografia>(entity =>
            {
                entity.HasKey(f => f.FotografiaId);
                entity.HasOne(f => f.Publicacion).WithMany(p => p.Fotografias).HasForeignKey(f => f.PublicacionId);
                entity.Property(f => f.RutaFotografia).HasMaxLength(500);

            });



        }
    }
}
