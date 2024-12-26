using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using TiendaInventarioController.Entidades;
namespace TiendaInventarioBACK.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Proveedores> Proveedores { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<DetalleOrden> DetalleOrden { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Tipo>().HasIndex(c => c.Name).IsUnique();
            modelBuilder.Entity<DetalleOrden>()
           .ToTable(tb => tb.UseSqlOutputClause(false));
        }

    }

}
