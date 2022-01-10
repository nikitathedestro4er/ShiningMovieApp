using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Shining.Services.FileServices
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _env;

        private readonly IHttpContextAccessor _httpContext;

        public FileService(IWebHostEnvironment env, IHttpContextAccessor httpContext)
        {
            _env = env;
            _httpContext = httpContext;
        }

        public async Task Save(Stream file, string fileName)
        {
            var filePath = GetPhysicalFilePath(fileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }

        }

        public string CreateImageName(string name, string imageExtension)
        {
            return $"{name}--{Guid.NewGuid()}{imageExtension}";
        }

        public string GetFilePath(string fileName)
        {
            var request = _httpContext.HttpContext.Request;

            return $"{request.Scheme}://{request.Host}{request.PathBase}/{fileName}";
        }


        public Task Delete(string fileName)
        {
            var filePath = GetPhysicalFilePath(fileName);

            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            return Task.CompletedTask;

        }

        private string GetPhysicalFilePath(string fileName)
        {
            return Path.Combine(_env.WebRootPath, fileName);
        }
    }
}
