using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mapping
{
    public class CityMap : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(20);
            builder.HasIndex(x => x.Name).IsUnique();
            builder.HasData(new City
            {
                Id = Guid.Parse("EF7B23B3-39A0-448A-83ED-45EB6A1224DA"),
                Name = "Adana",
            },
            new City
            {
                Id = Guid.Parse("01BBDE4D-9A2E-4F90-B05D-0A8F95126CAA"),
                Name = "Adıyaman"
            },
            new City
            {
                Id = Guid.Parse("7679F24A-7D29-472C-B674-6431A9AB05F1"),
                Name = "Afyon"
            },
            new City
            {
                Id = Guid.Parse("3D8F80B5-0053-4F9F-9567-D04932548E6E"),
                Name = "Ağrı"
            }, new City
            {
                Id = Guid.Parse("4716B89D-3237-4DCF-9901-0318A803FF81"),
                Name = "Amasya"
            },
            new City
            {
                Id = Guid.Parse("CBE7752A-8EAF-4743-A487-4C6E62FB5658"),
                Name = "Ankara"
            });
        }
    }
}
