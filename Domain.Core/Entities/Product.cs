using Domain.Core.Entities.Base;

namespace Domain.Core.Entities
{
    public class Product : BaseEntity
    {
        private readonly List<PurchaseItem> _purchaseItems = new();

        private Product() { }

        public Product(string name, Guid productCategoryId, string article, decimal price, IEnumerable<PurchaseItem> purchaseItems = null)
        {
            Name = name;
            ProductCategoryId = productCategoryId;
            Article = article;
            Price = price;
            _purchaseItems = purchaseItems?.ToList() ?? new List<PurchaseItem>();
            Id = Guid.NewGuid();
        }

        public string Name { get; private set; }
        public Guid ProductCategoryId { get; private set; }
        public string Article { get; private set; }
        public decimal Price { get; private set; }
        public ProductCategory ProductCategory { get; private set; }
        public ICollection<PurchaseItem> PurchaseItems => _purchaseItems;
    }
}
