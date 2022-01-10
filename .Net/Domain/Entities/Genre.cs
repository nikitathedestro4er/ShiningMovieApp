using Domain.Entities;
using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public class Genre : ITime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.UtcNow;

        public DateTime ModifiedDate { get; set; } = DateTime.UtcNow;

    }
}
