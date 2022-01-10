using System;

namespace DTOs.Shared
{
    public class ReplyComment
    {

        public int Id { get; set; }

        public string UserName { get; set; }
        
        public int CustomerId { get; set; }

        public int CommentId { get; set; }
        
        public string Content { get; set; }
        
        public DateTime CreationTime { get; set ; } 

        public DateTime ModifiedDate { get; set ; } 
    }
}