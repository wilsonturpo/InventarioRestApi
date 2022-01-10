using GEN_InventarioRestApi.Modelos;

namespace GEN_InventarioRestApi.Interfaces
{
    public interface IMedidaRepository
    {
        Task<IEnumerable<Medida>> GetMedidasAsync();
        void AddMedida(Medida medida);
        void DeleteMedida(int medidaId);
        Task<Medida> FindMedida(int id);
    }
}
