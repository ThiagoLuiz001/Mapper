using Mapper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Mapper.Infrastructure.Data.DboMapper.Map
{
    public class EquipamentMap : IEntityTypeConfiguration<Equipament>
    {
        public void Configure(EntityTypeBuilder<Equipament> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x=> x.Code)
                .HasMaxLength(30)
                .IsRequired();
            builder.Property(x => x.CreateAt).IsRequired();
            builder.Property(x => x.UpdateAt).IsRequired();
            builder.Property(x=> x.Active).IsRequired();

            builder.HasIndex(x=> x.Code).IsUnique();
            builder.HasIndex(x => x.Type);

            
        }
    }
}
