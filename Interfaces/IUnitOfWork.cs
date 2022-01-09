namespace GEN_InventarioRestApi.Interfaces
{
    public interface IUnitOfWork
    {
        ISeccionRepository SeccionRepository { get; }
        Task<bool> SaveAsync();
    }
}
