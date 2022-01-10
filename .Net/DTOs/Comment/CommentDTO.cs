using System;
using System.Collections.Generic;
using DTOs.Shared;

namespace DTOs.Comment
{
    public class CommentDTO
    {
        public int Id { get; set; }


        public string UserName { get; set; }
        
        public int CustomerId { get; set; }

        public int MovieId { get; set; }

        public ICollection<Shared.ReplyComment> Replies { get; set; }
        
        public string Content { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }

        public string Image { get; set; }
        
        public DateTime CreationTime { get; set ; } = DateTime.UtcNow;
        
        public DateTime ModifiedDate { get; set ; } = DateTime.UtcNow;
    }
}