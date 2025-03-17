using Domain.Core.Entities.Base;

namespace Domain.Core.Entities
{
    public class Customer : BaseEntity
    {
        private readonly List<Purchase> _purchases = new();

        private Customer() { }

        public Customer(string fullName, DateTime dateOfBirth, DateTime registrationDate, IEnumerable<Purchase> purchases = null)
        {
            FullName = fullName;
            DateOfBirth = dateOfBirth;
            RegistrationDate = registrationDate;
            _purchases = purchases?.ToList() ?? new List<Purchase>();
            Id = Guid.NewGuid();
        }

        public string FullName { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime RegistrationDate { get; private set; }
        public ICollection<Purchase> Purchases => _purchases;
    }
}
