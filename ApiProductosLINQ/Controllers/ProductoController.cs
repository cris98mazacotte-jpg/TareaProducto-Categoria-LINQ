
using ApiProductosLINQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiProductosLINQ.Controllers
{
    [Route("api/producto")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductoController(IProductoService service)
        {
            _service = service;
        }

        [HttpGet("categoria/{categoriaId}")]
        public async Task<IActionResult> ObtenerPorCategoria(int categoriaId)
        {
            var productos = await _service.ObtenerPorCategoriaAsync(categoriaId);

            if (productos == null)
            {
                return NotFound(new
                {
                    mensaje = "La categoría solicitada no existe."
                });
            }

            return Ok(productos);
        }
    }
}
