using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Comment : ITime
    {
        public int Id { get; set; }


        public string UserName { get; set; }
        
        public int CustomerId { get; set; }
        
        public int MovieId { get; set; }
        

        public virtual Movie Movie { get; set; }
        

        public virtual ICollection<ReplyComment> Replies { get; set; }
        
        public string Content { get; set; }

        public int Likes { get; set; }

        public int Dislikes { get; set; }
        
        
        public DateTime CreationTime { get; set ; } = DateTime.Now;
        
        
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}