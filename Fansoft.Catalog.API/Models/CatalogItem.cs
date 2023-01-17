
namespace Fansoft.Catalog.API.Models
{
    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

}