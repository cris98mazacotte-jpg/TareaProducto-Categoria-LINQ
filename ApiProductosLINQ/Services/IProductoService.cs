
using ApiProductosLINQ.Models;

namespace ApiProductosLINQ.Services
{
    public interface IProductoService
    {
        Task<List<Producto>?> ObtenerPorCategoriaAsync(int categoriaId);
    }
}
