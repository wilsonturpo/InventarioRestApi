using GEN_InventarioRestApi.Interfaces;
using GEN_InventarioRestApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GEN_InventarioRestApi.Data.Repository
{
    public class ProductoRepository : IProductoRepository
    {
        private DataContext context;

        public ProductoRepository(DataContext context)
        {
            this.context = context;
        }
        public void AddProducto(Producto producto)
        {
            context.Productos.Add(producto);
        }

        public void DeleteProducto(int productoId)
        {
            var producto = context.Productos.Find(productoId);
            context.Productos.Remove(producto);
        }

        public async Task<Producto> FindProducto(int id)
        {
            return await context.Productos.FindAsync(id);
        }

        public async Task<IEnumerable<Producto>> GetProductosAsync()
        {
            var productos = await context.Productos
                .Include(p=>p.Seccion)
                .Include(p=>p.Medida)
                .ToListAsync();
            return productos;
        }
    }
}
