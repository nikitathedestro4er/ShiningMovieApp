using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Movie
{
    public class MovieForListDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string GenreId { get; set; }

        public Shared.Genre Genre { get; set; }

        public string DirectorId { get; set; }

        public Shared.Director Director { get; set; }

        public string Image { get; set; }

        public int Year { get; set; }

        public double Rating { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
