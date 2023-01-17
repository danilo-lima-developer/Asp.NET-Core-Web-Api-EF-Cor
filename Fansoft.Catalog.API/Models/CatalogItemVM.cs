using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fansoft.Catalog.API.Models
{
    public class CatalogItemVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}