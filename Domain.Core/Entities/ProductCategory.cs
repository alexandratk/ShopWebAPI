using Domain.Core.Entities.Base;

namespace Domain.Core.Entities
{
    public class ProductCategory : BaseEntity
    {
        private readonly List<Product> _products = new();

        private ProductCategory() { }

        public ProductCategory(string name, IEnumerable<Product> products = null)
        {
            Name = name;
            _products = products?.ToList() ?? new List<Product>();
        }

        public string Name { get; private set; }
        public ICollection<Product> Products => _products;
    }
}
