namespace GEN_InventarioRestApi.Interfaces
{
    public interface IUnitOfWork
    {
        ISeccionRepository SeccionRepository { get; }
        IMedidaRepository MedidaRepository { get; }
        IProductoRepository ProductoRepository { get; }
        Task<bool> SaveAsync();
    }
}
