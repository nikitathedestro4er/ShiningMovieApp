using System.Collections.Generic;
using DTOs.Shared;


namespace DTOs.Genre
{
    public class GenreDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Shared.Movie> Movies { get; set; }
    }
}
