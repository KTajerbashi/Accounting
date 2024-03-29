﻿using Account.Domain.Library.Entities.BUS;
using Account.Domain.Library.Entities.CNT;
using Account.Domain.Library.Entities.WEB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Account.Application.Library.ApplicationContext.Configurations
{
    #region BUS
    public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.HasIndex(x => x.BankName).IsUnique();

            builder.HasMany(x => x.Carts)
                .WithOne(x => x.Bank)
                .HasForeignKey(x => x.BankID)
                .IsRequired();
        }
    }

    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasIndex(x => new
            {
                x.FullName,
            }).IsUnique();
            builder.HasMany(x => x.Carts)
                .WithOne(x => x.Customer);
        }
    }

    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasIndex(x => new
            {
                x.BankID,
                x.AccountNumber,
            }).IsUnique();

            builder.HasOne(x => x.Bank)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.BankID)
                .IsRequired();

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Carts)
                .HasForeignKey(x => x.CustomerID)
                .IsRequired();

            builder.HasMany(x => x.Blances)
                .WithOne(y => y.Cart)
                .HasForeignKey(z => z.CartID);


        }
    }
    public class BlanceConfiguration : IEntityTypeConfiguration<Blance>
    {
        public void Configure(EntityTypeBuilder<Blance> builder)
        {
            builder.HasOne(x => x.Cart)
                .WithMany(y => y.Blances)
                .HasForeignKey(z => z.CartID);
        }
    }

    public class SettlemantConfiguration : IEntityTypeConfiguration<Settlemant>
    {
        public void Configure(EntityTypeBuilder<Settlemant> builder)
        {
            builder.HasOne(x => x.Cart)
                 .WithMany(x => x.Settlemants)
                 .HasForeignKey(x => x.CartID);
        }
    }

    #endregion

    #region SEC
    #endregion

    #region LOG
    #endregion

    #region RPT
    #endregion

    #region WEB
    public class WebServiceConfiguration : IEntityTypeConfiguration<WebService>
    {
        public void Configure(EntityTypeBuilder<WebService> builder)
        {
        }
    }
    #endregion

    #region CNT
    public class ConstVariableConfiguration : IEntityTypeConfiguration<ConstVariable>
    {
        public void Configure(EntityTypeBuilder<ConstVariable> builder)
        {
        }
    }
    #endregion

}
