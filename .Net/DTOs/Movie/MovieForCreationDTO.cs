using System.Collections.Generic;
using System.IO;
using DTOs.File;
using DTOs.Shared;


namespace DTOs.Movie
{
    public class MovieForCreationDTO : IFileHolder
    {
        public string Name { get; set; }

        public int GenreId { get; set; }

        public int DirectorId { get; set; }

        public ICollection<Shared.Actor> Actors { get; set; }

        public string Image { get; set; }

        public Stream File { get; set; }

        public string FileExtension { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public string Description { get; set; }

    }
}
