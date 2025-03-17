using Domain.Core.Entities.Base;

namespace Domain.Core.Entities
{
    public class Purchase : BaseEntity
    {
        private readonly List<PurchaseItem> _purchaseItems = new();

        private Purchase() { }

        public Purchase(decimal totalAmount, Guid customerId, IEnumerable<PurchaseItem> purchaseItems = null)
        {
            TotalAmount = totalAmount;
            CustomerId = customerId;
            _purchaseItems = purchaseItems?.ToList() ?? new List<PurchaseItem>();
        }

        public decimal TotalAmount { get; private set; }
        public Guid CustomerId { get; private set; }
        public Customer Customer { get; private set; }
        public ICollection<PurchaseItem> PurchaseItems => _purchaseItems;

    }
}
