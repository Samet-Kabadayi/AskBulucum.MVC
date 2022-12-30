using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mapping
{
    public class ProclamationMap : IEntityTypeConfiguration<Proclamation>
    {
        public void Configure(EntityTypeBuilder<Proclamation> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Link).HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Link).IsRequired();
            builder.Property(x => x.CityId).IsRequired();
            builder.Property(x => x.BrandId).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200);
            builder.Property(x => x.VehiclePrize).IsRequired();
            builder.Property(u => u.DeletedDate).HasColumnType("date");
            builder.Property(u => u.CreatedDate).HasColumnType("date");
            builder.Property(x => x.VehiclePrize).HasColumnType("money");
            builder.Property(x => x.ProclamaionPrize).IsRequired();
            builder.Property(x => x.ProclamaionPrize).HasColumnType("money");
            builder.Property(x => x.CreatedDate).IsRequired();
            builder.HasData(new Proclamation
            {
                Id = Guid.Parse("D4121C85-EE78-41FD-AA7F-DABC74D1536A"),
                Link = "www.ask.com",
                Description = "araç yakın",
                ProclamaionPrize = 1000,
                VehiclePrize = 3000000,
                CreatedDate = DateTime.Now,
                CityId = Guid.Parse("CBE7752A-8EAF-4743-A487-4C6E62FB5658"),
                SeekerId = Guid.Parse("5B244AFB-5101-430F-84F6-F48FAFC339D8"),
                BrandId = Guid.Parse("8ECBBDB3-50AD-4B66-9BAA-1F27298695A7"),
            });
        }
    }
}
