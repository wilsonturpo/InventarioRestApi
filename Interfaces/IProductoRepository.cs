using GEN_InventarioRestApi.Modelos;

namespace GEN_InventarioRestApi.Interfaces
{
    public interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetProductosAsync();
        void AddProducto(Producto producto);
        void DeleteProducto(int productoId);
        Task<Producto> FindProducto(int id);
    }
}
