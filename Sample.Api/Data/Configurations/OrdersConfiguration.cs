using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sample.Api.Domain;
using System;

namespace Sample.Api.Data.Configurations
{
    public class OrdersConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1, 1);

            builder.Property(o => o.CreatedOn)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasMany(o => o.Items)
                .WithMany(oi => oi.Orders)
                .UsingEntity<OrderItem>(
                    j => j.HasOne(oi => oi.Item).WithMany(oi => oi.OrderItems).HasForeignKey(oi => oi.ItemId),
                    j => j.HasOne(oi => oi.Order).WithMany(oi => oi.OrderItems).HasForeignKey(oi => oi.OrderId),
                    j=>
                    {
                        j.HasKey(t => new { t.OrderId, t.ItemId });
                    }
                );
                
        }
    }
}
