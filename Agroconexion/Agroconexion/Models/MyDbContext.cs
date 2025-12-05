using Microsoft.EntityFrameworkCore;

namespace Agroconexion.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() { }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        // ====== TABLAS ======
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Cliente> Cliente { get; set; }

        // ====== VENTAS / COMPRAS ======
        public DbSet<Venta> Venta { get; set; }
        public DbSet<Detalle_venta> Detalle_Venta { get; set; }

        public DbSet<Compra> Compra { get; set; }
        public DbSet<Detalle_compra> Detalle_Compra { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ====== CLAVES PRIMARIAS ======
            modelBuilder.Entity<Usuario>().HasKey(e => e.idUsuario);
            modelBuilder.Entity<Rol>().HasKey(e => e.idRol);
            modelBuilder.Entity<Permiso>().HasKey(e => e.idPermiso);
            modelBuilder.Entity<Producto>().HasKey(e => e.idProducto);
            modelBuilder.Entity<Categoria>().HasKey(e => e.IdCategoria);
            modelBuilder.Entity<Proveedor>().HasKey(e => e.idProveedor);
            modelBuilder.Entity<Cliente>().HasKey(e => e.idCliente);

            modelBuilder.Entity<Venta>().HasKey(e => e.idVenta);
            modelBuilder.Entity<Detalle_venta>().HasKey(e => e.IdDetalle_Venta);

            modelBuilder.Entity<Compra>().HasKey(e => e.idCompra);
            modelBuilder.Entity<Detalle_compra>().HasKey(e => e.IdDetalle_Compra);

            // ====== RELACIONES ======

            // Venta → Detalle_Venta
            modelBuilder.Entity<Detalle_venta>()
                .HasOne(d => d.Venta)
                .WithMany()
                .HasForeignKey(d => d.idVenta);

            // Producto → Detalle_Venta
            modelBuilder.Entity<Detalle_venta>()
                .HasOne(d => d.Producto)
                .WithMany()
                .HasForeignKey(d => d.idProducto);

            // Compra → Detalle_Compra
            modelBuilder.Entity<Detalle_compra>()
                .HasOne(d => d.Compra)
                .WithMany()
                .HasForeignKey(d => d.idCompra);

            // Producto → Detalle_Compra
            modelBuilder.Entity<Detalle_compra>()
                .HasOne(d => d.Producto)
                .WithMany()
                .HasForeignKey(d => d.idProducto);
        }
    }
}
