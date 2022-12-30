using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mapping
{
    public class VehicleTypeMap : IEntityTypeConfiguration<VehicleType>
    {
        public void Configure(EntityTypeBuilder<VehicleType> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).IsRequired();
            builder.Property(b => b.Name).IsRequired();
            builder.Property(b => b.Name).HasMaxLength(20);
            builder.HasData(
                new VehicleType
                {
                    Id = Guid.Parse("23CF33D2-4F95-4A36-973A-B0F6E69CE29D"),
                    Name = "Otomobil",

                },
                new VehicleType
                {
                     Id = Guid.Parse("D20902D0-022C-4918-8C53-53E267EC4885"),
                     Name = "Deniz Aracı",

                },
                new VehicleType
                {
                    Id = Guid.Parse("974DBDB9-2993-44EF-B57A-1240EB1FB597"),
                    Name = "Motorsiklet",
                     
                }
                );
        }
    }
}
