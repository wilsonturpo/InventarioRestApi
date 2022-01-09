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
    }
}
