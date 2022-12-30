using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mapping
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.HasData(
                new Brand
                {
                    Id = Guid.Parse("8ECBBDB3-50AD-4B66-9BAA-1F27298695A7"),
                    Name = "BMW"
                },
                new Brand
                {
                     Id = Guid.Parse("8EFB1D22-30FC-4180-BF39-26FFB23A2428"),
                     Name = "Mercedes"
                },
                new Brand
                {
                     Id = Guid.Parse("8A5E1005-0744-45D9-8DAD-E02F2110A27D"),
                     Name = "Audi"
                }, new Brand
                {
                    Id = Guid.Parse("71BD378A-854F-41A0-B565-2021BDAF1BFB"),
                    Name = "Porsche"
                }
            );

        }
    }
}
