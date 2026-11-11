
using ApiProductosLINQ.Models;

namespace ApiProductosLINQ.Repositories
{
    public interface IProductoRepository
    {
        Task<bool> ExisteCategoriaAsync(int categoriaId);

        Task<List<Producto>> ObtenerPorCategoriaAsync(int categoriaId);
    }
}
