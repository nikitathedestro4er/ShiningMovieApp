using DTOs.Shared;
using System.Collections.Generic;


namespace DTOs.Movie
{
    public class MovieDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string GenreId { get; set; }

        public Shared.Genre Genre { get; set; }

        public string DirectorId { get; set; }

        public Shared.Director Director { get; set; }

        public ICollection<Shared.Actor> Actors { get; set; }


        public string Image { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

        public ICollection<Shared.Movie> RelatedMovies { get; set; }
    }
}
