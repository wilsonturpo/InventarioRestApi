using GEN_InventarioRestApi.Data.Repository;
using GEN_InventarioRestApi.Interfaces;

namespace GEN_InventarioRestApi.Data
{
    public class UnitOfWork :IUnitOfWork
    {
        private DataContext context;

        public UnitOfWork(DataContext context)
        {
            this.context = context;
        }

        public ISeccionRepository SeccionRepository => new SeccionRepository(context);

        public IMedidaRepository MedidaRepository => new MedidaRepository(context);

        public IProductoRepository ProductoRepository => new ProductoRepository(context);

        public async Task<bool> SaveAsync()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}
