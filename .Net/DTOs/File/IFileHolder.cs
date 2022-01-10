using System.IO;

namespace DTOs.File
{
    public interface IFileHolder
    {
        public Stream File { get; set; }

        public string FileExtension { get; set; }
    }
}
