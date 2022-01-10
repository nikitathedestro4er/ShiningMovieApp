using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ReplyComment : ITime
    {
        public int Id { get; set; }


        public string UserName { get; set; }
        
        public int CustomerId { get; set; }
        
        public int CommentId { get; set; }
        
        public virtual Comment Comment{ get; set; }
        
        
        public string Content { get; set; }
        
        public DateTime CreationTime { get; set; } = DateTime.Now;
        
        
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}