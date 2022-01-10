using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Movie : ITime 
    {

        public int Id { get; set; }

        public string Name { get; set; }
        
        public int GenreId { get; set; }
        
        public virtual Genre Genre { get; set; }

        public int DirectorId { get; set; }

        public virtual Director Director { get; set; }

        public virtual ICollection<Actor> Actors { get; set; }

        
        public virtual ICollection<Comment> Comments { get; set; }
        
        public string Image { get; set; }
        
        public int Year { get; set; }
        
        public double Rating { get; set; }

        public TimeSpan Length { get; set; }

        public string Description { get; set; }


        public DateTime CreationTime { get; set; } = DateTime.UtcNow; 

        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;
    } 
}
