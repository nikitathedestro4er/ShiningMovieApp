using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    internal sealed class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable(nameof(Comment));

            builder.HasKey(comment => comment.Id);


            builder.Property(comment => comment.Id).ValueGeneratedOnAdd();


            builder.Property(comment => comment.CustomerId).IsRequired();


            builder.Property(comment => comment.UserName).IsRequired();


            builder.Property(comment => comment.MovieId).IsRequired();


            builder.HasOne(comment => comment.Movie).WithMany(movie => movie.Comments)
                .HasForeignKey(comment => comment.MovieId);

            
            builder.HasMany(comment => comment.Replies).WithOne(reply => reply.Comment)
                .HasForeignKey(comment => comment.CommentId);


            builder.Property(comment => comment.Content).IsRequired().HasMaxLength(500);
            
            
            builder.Property(comment => comment.Likes);


            builder.Property(comment => comment.Dislikes);
            
            
            builder.Property(comment => comment.CreationTime).IsRequired();
        }
    }
}