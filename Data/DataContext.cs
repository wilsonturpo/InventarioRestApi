using GEN_InventarioRestApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GEN_InventarioRestApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        public DbSet<Seccion> Secciones { get; set; }
        public DbSet<Medida> Medidas { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
