using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.EntityConfiguration
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
