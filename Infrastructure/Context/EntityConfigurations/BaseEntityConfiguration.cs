using Domain.Core.Entities.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.EntityConfigurations
{
    internal class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : class, IEntity
    {
        protected virtual void ConfigureEntity(EntityTypeBuilder<TEntity> builder) { }
        public void Configure(EntityTypeBuilder<TEntity> builder)
        {
            if (typeof(TEntity).BaseType == typeof(BaseEntity))
            {
                builder.HasKey(o => (o as BaseEntity).Id);
                builder.Property("Id").ValueGeneratedOnAdd();
            }

            ConfigureEntity(builder);
        }
    }
}
