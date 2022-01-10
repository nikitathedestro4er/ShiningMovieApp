using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ReplyCommentConfiguration : IEntityTypeConfiguration<ReplyComment>
    {
        public void Configure(EntityTypeBuilder<ReplyComment> builder)
        {
            builder.ToTable(nameof(ReplyComment));

            builder.HasKey(replyComment => replyComment.Id);


            builder.Property(replyComment => replyComment.Id).ValueGeneratedOnAdd();


            builder.Property(replyComment => replyComment.CustomerId).IsRequired();


            builder.Property(comment => comment.UserName).IsRequired();


            builder.Property(replyComment => replyComment.CommentId).IsRequired();


            builder.HasOne(replyComment => replyComment.Comment).WithMany(comment => comment.Replies)
                .HasForeignKey(replyComment => replyComment.CommentId).OnDelete(DeleteBehavior.Cascade);

            
            builder.Property(replyComment => replyComment.Content).IsRequired().HasMaxLength(500);
            
            
            builder.Property(replyComment => replyComment.CreationTime).IsRequired();
        }
    }
}