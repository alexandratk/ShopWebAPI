namespace Domain.Core.Entities.Base
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
