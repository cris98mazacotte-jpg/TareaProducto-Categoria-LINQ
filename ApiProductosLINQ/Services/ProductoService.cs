
using ApiProductosLINQ.Models;
using ApiProductosLINQ.Repositories;
using ApiProductosLINQ.DTOs;

namespace ApiProductosLINQ.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;

        public ProductoService(IProductoRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<ProductoDto>?> ObtenerPorCategoriaAsync(int categoriaId)
        {
            bool existeCategoria = await _repository.ExisteCategoriaAsync(categoriaId);

            if (!existeCategoria)
            {
                return null;
            }

            var productos = await _repository.ObtenerPorCategoriaAsync(categoriaId);

            return productos.Select(p => new ProductoDto
            {
                Id = p.Id,
                Nombre = p.Nombre,
                Precio = p.Precio,
                Stock = p.Stock,
                CategoriaId = p.CategoriaId,
                CategoriaDescripcion = p.Categoria?.Descripcion
            }).ToList();
        }

    }
}
