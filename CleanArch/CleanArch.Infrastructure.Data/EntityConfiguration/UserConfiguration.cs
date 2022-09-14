using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Data.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Email).HasMaxLength(100).IsRequired();
            builder.Property(p => p.AccountType).IsRequired();
            builder.Property(p => p.Password).HasMaxLength(30).IsRequired();

            builder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "D'Artagnan",
                    LastName = "Lamarca",
                    Email = "dartagnan@email.com",
                    AccountType = 1,
                    Password = "123"
                }
                );

        }
    }
}
