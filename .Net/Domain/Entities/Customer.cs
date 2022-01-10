using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Customer : ITime
    {
        public int Id { get; set; }
        
        public string UserId { get; set; }

        public string Image { get; set; }
        
        
        public virtual ICollection<Comment> Comments { get; set; }
        
        public DateTime CreationTime { get; set; }
        
        public DateTime ModifiedDate { get; set; }
    }
}