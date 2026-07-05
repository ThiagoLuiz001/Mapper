using Mapper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Mapper.Infrastructure.Data.DboMapper.Map
{
    public class NotebookMap : IEntityTypeConfiguration<Notebook>
    {
        public void Configure(EntityTypeBuilder<Notebook> entity)
        {
            entity.HasKey(x=>x.Id);

            entity.HasOne(x=>x.Equipament)
                .WithOne()
                .HasForeignKey(p=> p.);
                
        }
    }
}
