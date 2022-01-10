using GEN_InventarioRestApi.Modelos;

namespace GEN_InventarioRestApi.Interfaces
{
    public interface ISeccionRepository
    {
        Task<IEnumerable<Seccion>> GetSeccionesAsync();
        void AddSeccion(Seccion seccion);
        void DeleteSeccion(int seccionId);
        Task<Seccion> FindSeccion(int id);
    }
}
