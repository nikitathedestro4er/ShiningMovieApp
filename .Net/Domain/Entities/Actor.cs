using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Actor : ITime
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Image { get; set; }

        public double Rating { get; set; }

        public DateTime Birthday { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

        public DateTime CreationTime { get; set ; } = DateTime.UtcNow;

        public DateTime ModifiedDate { get ; set ; } = DateTime.UtcNow;
    }
}
