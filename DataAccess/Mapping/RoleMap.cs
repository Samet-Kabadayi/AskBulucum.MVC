using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mapping
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.Name).IsRequired();
            builder.Property(r => r.Name).HasMaxLength(25);
            builder.HasData(
                new Role
                {
                    Id = Guid.Parse("2B097D52-677D-4915-8BE0-1680B14A5010"),
                    Name = "Expert"
                },
                new Role
                {
                    Id = Guid.Parse("AB230D00-B037-4751-B727-DDDC7CD9BB5D"),
                    Name = "Fish"
                },
                new Role
                {
                    Id = Guid.Parse("C5D62390-65D4-44A3-A134-E1F2E63642DC"),
                    Name = "Mid"
                },
                new Role
                {
                    Id = Guid.Parse("664B6C0C-2CDF-46C3-BFFE-164B9C6DAE86"),
                    Name = "Admin"
                },
                new Role
                {
                    Id = Guid.Parse("316DFA77-073D-4672-BBF6-5D615575696C"),
                    Name = "Mod"
                }
                );
        }
    }
}
