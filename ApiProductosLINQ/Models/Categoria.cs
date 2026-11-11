
namespace ApiProductosLINQ.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        // Propiedad de navegación
        public ICollection<Producto> Productos { get; set; }
            = new List<Producto>();
    }
}
