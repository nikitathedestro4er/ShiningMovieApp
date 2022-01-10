using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IFileService
    {
        Task Save(Stream file, string fileName);

        string CreateImageName(string name, string imageExtension);

        string GetFilePath(string fileName);

        Task Delete(string fileName);

        
    }
}
