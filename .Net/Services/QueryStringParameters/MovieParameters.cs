using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.QueryStringParameters
{
    public class MovieParameters : QueryStringParameters
    {
        public string Search { get; set; }

        public int? GenreId { get; set; }

        public int? DirectorId { get; set; }

        public int? MinYear { get; set; }

        public int MaxYear { get; set; } = DateTime.Now.Year;

        public bool ValidYearRange => MinYear < MaxYear;
    }
}
