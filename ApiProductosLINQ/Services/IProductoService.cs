
using ApiProductosLINQ.DTOs;

namespace ApiProductosLINQ.Services
{
    public interface IProductoService
    {
        Task<List<ProductoDto>?> ObtenerPorCategoriaAsync(int categoriaId);
    }
}
