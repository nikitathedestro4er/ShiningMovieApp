using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal sealed class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable(nameof(Genre));

            builder.HasKey(genre => genre.Id);

            builder.Property(genre => genre.Id).ValueGeneratedOnAdd();

            builder.Property(genre => genre.Name).IsRequired().HasMaxLength(30);

            builder.Property(genre => genre.CreationTime).IsRequired();

            builder.Property(genre => genre.ModifiedDate).IsRequired();

            builder.HasMany(genre => genre.Movies).WithOne().HasForeignKey(movie => movie.GenreId);

            builder.HasData(
                new Genre { Id = 1, Name = "Horror" },
                new Genre { Id = 2, Name = "Thriller" },
                new Genre { Id = 3, Name = "Fantasy" },
                new Genre { Id = 4, Name = "Detective" },
                new Genre { Id = 5, Name = "Comedy" },
                new Genre { Id = 6, Name = "Western" },
                new Genre { Id = 7, Name = "Animation"},
                new Genre { Id = 8, Name = "Drama"},
                new Genre { Id = 9, Name = "History"},
                new Genre { Id = 10, Name = "Adventure"}
            );
        }
    }
}
