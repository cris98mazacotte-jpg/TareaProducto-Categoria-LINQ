
using ApiProductosLINQ.Data;
using ApiProductosLINQ.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProductosLINQ.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly AppDbContext _context;

        public ProductoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<bool> ExisteCategoriaAsync(int categoriaId)
        {
            return await _context.Categorias
                .AnyAsync(c => c.Id == categoriaId);
        }

        public async Task<List<Producto>> ObtenerPorCategoriaAsync(int categoriaId)
        {
            return await _context.Productos
                .Include(p => p.Categoria)
                .Where(p => p.CategoriaId == categoriaId)
                .ToListAsync();
        }
    }
}
