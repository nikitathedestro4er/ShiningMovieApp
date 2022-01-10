using System.IO;
using DTOs.File;

namespace DTOs.Customer
{
    public class CustomerForUpdateDTO : IFileHolder
    {
        public int Id { get; set; }
        
        public string UserId { get; set; }
        
        
        public string Image { get; set; }
        
        public Stream File { get; set; }

        public string FileExtension { get; set; }
    }
}