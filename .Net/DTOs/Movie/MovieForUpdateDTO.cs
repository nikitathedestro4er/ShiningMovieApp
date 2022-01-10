using DTOs.File;
using DTOs.Shared;
using System;
using System.Collections.Generic;
using System.IO;

namespace DTOs.Movie
{
    public class MovieForUpdateDTO : IFileHolder
    {
        public int Id { get; set; }
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

        public DateTime ModifiedDate { get; set; }
    }
}
