using GEN_InventarioRestApi.Interfaces;
using GEN_InventarioRestApi.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GEN_InventarioRestApi.Data.Repository
{
    public class SeccionRepository : ISeccionRepository
    {
        private DataContext context;

        public SeccionRepository(DataContext context)
        {
            this.context = context;
        }
        public void AddSeccion(Seccion seccion)
        {
            context.Secciones.Add(seccion);
        }

        public void DeleteSeccion(int seccionId)
        {
            var seccion = context.Secciones.Find(seccionId);
            context.Secciones.Remove(seccion);
        }

        public async Task<Seccion> FindSeccion(int id)
        {
            return await context.Secciones.FindAsync(id);
        }

        public async Task<IEnumerable<Seccion>> GetSeccionesAsync()
        {
            return await context.Secciones.ToListAsync();
        }
    }
}
