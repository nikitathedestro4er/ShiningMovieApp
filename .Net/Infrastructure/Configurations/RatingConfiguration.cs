using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.ToTable(nameof(Rating));

            builder.HasKey(rating => rating.Id);


            builder.Property(rating => rating.Id).ValueGeneratedOnAdd();


            builder.Property(rating => rating.MovieId).IsRequired();
            
            
            builder.Property(rating => rating.CustomerId).IsRequired();


            builder.Property(rating => rating.Rate).IsRequired();




        }
    }
}