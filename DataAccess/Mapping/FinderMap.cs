using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text;

namespace DataAccess.Mapping
{
    public class FinderMap : IEntityTypeConfiguration<Finder>
    {
        public void Configure(EntityTypeBuilder<Finder> builder)
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
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(11);
            builder.Property(x => x.Email).HasMaxLength(50);
            builder.Property(x => x.Tc).HasMaxLength(11);
            builder.Property(x => x.Tc).IsRequired();
            builder.HasIndex(x => x.Tc).IsUnique();
            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");     
            builder.Property(u => u.CreatedDate).IsRequired();
            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedDate).HasColumnType("datetime");
            builder.Property(u => u.DeletedDate).HasColumnType("datetime");
            builder.Property(u => u.VIP).IsRequired();
            builder.Property(u => u.Vote).IsRequired();
            builder.Property(u => u.Vote).HasColumnType("Decimal(3,1)");
            builder.Property(u => u.SuccessfulWork).IsRequired();
            builder.HasData(
                new Finder
                {
                    Id = Guid.Parse("2394F0D0-07D9-43B5-9095-30C4975F449D"),
                    FirstName = "samet",
                    LastName = "Kabadayı",
                    Phone = "5555555555",
                    Email = "kabadayiabdulsamet@gmail.com",
                    Tc = "44444444444",
                    PasswordHash = Encoding.ASCII.GetBytes("827ccb0eea8a706c4c34a16891f84e7b"),                   
                    CreatedDate = DateTime.Now,
                    CreatedByName = "Samet",
                    VIP = true,
                    IsActive = true,
                    ConfirmEmail = true,
                    ConfirmPerson = true,
                    RememberMe = false,
                    IsBanned = false,
                    Description = "Merhaba bana güvenebilrirsnizi...",
                    Vote = 9,
                    SuccessfulWork = 12,
                    CityId = Guid.Parse("CBE7752A-8EAF-4743-A487-4C6E62FB5658"),
                    RoleId = Guid.Parse("316DFA77-073D-4672-BBF6-5D615575696C"),
                },
                    new Finder
                    {
                        Id =Guid.Parse("D22C2E26-FC10-4FDC-8A2E-DDCDBDBFBA7F"),
                        FirstName = "ali",
                        LastName = "veli",
                        Phone = "6555555555",
                        Email = "sabadayiabdulsamet@gmail.com",
                        Tc = "54444444444",
                        PasswordHash = Encoding.ASCII.GetBytes("827ccb0eea8a706c4c34a16891f84e7b"),                       
                        CreatedDate = DateTime.Now,
                        CreatedByName= "Samet1",
                        VIP = false,
                        IsActive = true,
                        ConfirmEmail = false,
                        ConfirmPerson = false,
                        RememberMe = false,
                        IsBanned = false,
                        Description = "Merhaba bana güvenebilrirsnizi2...",
                        Vote = 9,
                        SuccessfulWork = 0,
                        CityId = Guid.Parse("EF7B23B3-39A0-448A-83ED-45EB6A1224DA"),
                        RoleId = Guid.Parse("316DFA77-073D-4672-BBF6-5D615575696C"),
                    }
                );
        }
    }
}
// şifre 12345