using ChipChipApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Principal;

namespace ChipChipApi.Confurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).HasColumnName("id");
            builder.Property(a => a.firstName).HasColumnName("firstName").HasMaxLength(50).IsRequired();
            builder.Property(a => a.lastName).HasColumnName("lastName").HasMaxLength(50).IsRequired();
            builder.Property(a => a.email).HasColumnName("email").HasMaxLength(320).IsRequired();
            builder.Property(a => a.password).HasColumnName("password").HasMaxLength(60).IsRequired();
        }
    }
}
