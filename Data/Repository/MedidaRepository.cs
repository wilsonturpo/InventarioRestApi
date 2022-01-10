using GEN_InventarioRestApi.Interfaces;
using GEN_InventarioRestApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GEN_InventarioRestApi.Data.Repository
{
    public class MedidaRepository : IMedidaRepository
    {
        private DataContext context;

        public MedidaRepository(DataContext context)
        {
            this.context = context;
        }
        public void AddMedida(Medida medida)
        {
            context.Medidas.Add(medida);
        }

        public void DeleteMedida(int medidaId)
        {
            var medida = context.Medidas.Find(medidaId);
            context.Medidas.Remove(medida);
        }

        public async Task<Medida> FindMedida(int id)
        {
            return await context.Medidas.FindAsync(id);
        }

        public async Task<IEnumerable<Medida>> GetMedidasAsync()
        {
            return await context.Medidas.ToListAsync();
        }
    }
}
