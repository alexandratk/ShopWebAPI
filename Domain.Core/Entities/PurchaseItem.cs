using Domain.Core.Entities.Base;

namespace Domain.Core.Entities
{
    public class PurchaseItem : BaseEntity
    {
        private PurchaseItem() { }

        public PurchaseItem(int quantity, Guid productId, Guid purchaseId)
        {
            Quantity = quantity;
            ProductId = productId;
            PurchaseId = purchaseId;
        }

        public int Quantity { get; private set; }
        public Guid ProductId { get; private set; }
        public Guid PurchaseId { get; private set; }
        public Product Product { get; private set; }
        public Purchase Purchase { get; private set; }
    }
}
