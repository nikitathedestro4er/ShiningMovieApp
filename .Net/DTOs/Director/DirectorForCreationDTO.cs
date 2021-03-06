using DTOs.File;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs.Director
{
    public class DirectorForCreationDTO : IFileHolder
    {
        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public double Rating { get; set; }

        public string Image { get; set; }

        public Stream File { get; set; }

        public string FileExtension { get; set; }

        public string Description { get; set; }
    }
}
