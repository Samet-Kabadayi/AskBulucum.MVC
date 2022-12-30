using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mapping
{
    public class SeekerMap : IEntityTypeConfiguration<Seeker>
    {
        public void Configure(EntityTypeBuilder<Seeker> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.FirstName).HasColumnType("NVARCHAR(20)");
            builder.Property(x => x.LastName).HasColumnType("NVARCHAR(20)");
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.HasIndex(x => x.Phone).IsUnique();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(11);
            builder.Property(x => x.Phone).HasMaxLength(25);
            builder.Property(x => x.Tc).HasMaxLength(11);
            builder.Property(x => x.Tc).IsRequired();
            builder.HasIndex(x => x.Tc).IsUnique();
            builder.Property(x => x.ConfirmPerson).IsRequired();
            builder.Property(u => u.CreatedDate).HasColumnType("datetime");
            builder.Property(u => u.DeletedDate).HasColumnType("datetime");
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");        
            builder.Property(u => u.VIP).IsRequired();
            builder.HasData(
     new Seeker
     {
         Id = Guid.Parse("5B244AFB-5101-430F-84F6-F48FAFC339D8"),
         FirstName = "ali",
         LastName = "mehmet",
         Phone = "1111111111",
         Tc = "12345678901",
         Email = "aliali@gmail",
         PasswordHash = Encoding.ASCII.GetBytes("be3a3bad50e703ccbcfafd74d70a0912"),
  
         CreatedDate = DateTime.Now,
         IsActive = true,
         ConfirmPerson = true,
         ConfirmEmail = true,
         RememberMe = false,
         IsBanned = false,
         VIP = true,
         CityId = Guid.Parse("01BBDE4D-9A2E-4F90-B05D-0A8F95126CAA"),
     },
     new Seeker
     {
         Id = Guid.Parse("5EB98805-DC12-45AE-B97D-C97A81A0F0E6"),
         FirstName = "veli",
         LastName = "ahmet",
         Phone = "2222222222",
         Tc = "22222222222",
         Email = "veliveli@gmail",
         PasswordHash = Encoding.ASCII.GetBytes("f8ab98cf4d67d7b5ed2b06eff515ad47"),
       
         CreatedDate = DateTime.Now,
         ConfirmEmail = false,
         ConfirmPerson = false,
         RememberMe = false,
         VIP = false,
         IsActive = true,
         IsBanned =false,
         CityId = Guid.Parse("4716B89D-3237-4DCF-9901-0318A803FF81"),
     }
     );
        }
    }
}
