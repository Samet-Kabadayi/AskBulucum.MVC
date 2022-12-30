using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class BrandVehicleTypeMap : IEntityTypeConfiguration<BrandVehicleType>
    {
        public void Configure(EntityTypeBuilder<BrandVehicleType> builder)
        {
            builder.HasKey(bv => new { bv.BrandId, bv.VehicleTypeId });
            builder.HasOne(bv => bv.VehicleType).
                    WithMany(v => v.Brands).
                    HasForeignKey(bv=>bv.VehicleTypeId);
            builder.HasOne(bv => bv.Brand).
                    WithMany(b => b.VehicleTypes).
                    HasForeignKey(bv=>bv.BrandId);
            builder.HasData(
                new BrandVehicleType
                {
                    BrandId = Guid.Parse("8ECBBDB3-50AD-4B66-9BAA-1F27298695A7"),
                    VehicleTypeId = Guid.Parse("23CF33D2-4F95-4A36-973A-B0F6E69CE29D"),
                },
                new BrandVehicleType
                {
                    BrandId = Guid.Parse("8ECBBDB3-50AD-4B66-9BAA-1F27298695A7"),
                    VehicleTypeId = Guid.Parse("974DBDB9-2993-44EF-B57A-1240EB1FB597"),
                },
                new BrandVehicleType
                {
                    BrandId = Guid.Parse("8EFB1D22-30FC-4180-BF39-26FFB23A2428"),
                    VehicleTypeId = Guid.Parse("D20902D0-022C-4918-8C53-53E267EC4885"),
                },
                new BrandVehicleType
                {
                    BrandId = Guid.Parse("71BD378A-854F-41A0-B565-2021BDAF1BFB"),
                    VehicleTypeId = Guid.Parse("D20902D0-022C-4918-8C53-53E267EC4885"),
                }
            );

        }
    }
}
