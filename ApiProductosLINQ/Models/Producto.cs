
namespace ApiProductosLINQ.Models
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        // Clave foránea
        public int? CategoriaId { get; set; }

        // Propiedad de navegación
        public Categoria? Categoria { get; set; }
    }
}
