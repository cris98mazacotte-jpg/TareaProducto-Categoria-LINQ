
using ApiProductosLINQ.Models;
using ApiProductosLINQ.Repositories;

namespace ApiProductosLINQ.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Producto>?> ObtenerPorCategoriaAsync(int categoriaId)
        {
            bool existeCategoria = await _repository.ExisteCategoriaAsync(categoriaId);

            if (!existeCategoria)
            {
                return null;
            }

            return await _repository.ObtenerPorCategoriaAsync(categoriaId);
        }
    }
}
