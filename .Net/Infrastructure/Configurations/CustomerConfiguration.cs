using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal sealed class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable(nameof(Customer));


            builder.HasKey(customer => customer.Id);
            

            builder.Property(customer => customer.Id).ValueGeneratedOnAdd();


            builder.Property(customer => customer.UserId).IsRequired();


            builder.Property(customer => customer.Image).IsRequired();
            

            builder.Property(customer => customer.CreationTime).IsRequired();


            builder.Property(customer => customer.ModifiedDate).IsRequired();


            builder.HasData(
                new Customer
                {
                    Id = 1,
                    UserId = "20befc7a-f889-43f4-9db0-44af52b225ee",
                    Image = "Jack Nicholson--928401a8-56b7-4b88-beb6-90e19399789c.jpg"
                }
                );
        }
    }
}    