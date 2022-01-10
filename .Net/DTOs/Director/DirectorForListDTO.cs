using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Director
{
    public class DirectorForListDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public string Image { get; set; }

        public double Rating { get; set; }

        public ICollection<Shared.Movie> Movies { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
