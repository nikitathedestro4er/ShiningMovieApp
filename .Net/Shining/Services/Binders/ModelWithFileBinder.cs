using DTOs.File;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Shining.Services.Binders
{
    public class ModelWithFileBinder : IModelBinder
    {
        private IModelBinder _inner;

        public ModelWithFileBinder(IModelBinder inner)
        {
            _inner = inner;
        }

        public async Task BindModelAsync(ModelBindingContext bindingContext)
        {
            await _inner.BindModelAsync(bindingContext);


            var model = (IFileHolder) bindingContext.Model;

            var request = bindingContext.HttpContext.Request;

            if (!request.HasFormContentType)
            {
                return;
            }

            var form = await request.ReadFormAsync();

            

            var file = form.Files.GetFile(nameof(IFileHolder.File));

            if (file is null)
            {
                return;
            }

            var extension = file.ContentType;

            var memoryStream = new MemoryStream();

            await file.CopyToAsync(memoryStream);

            memoryStream.Position = 0;

            model.File = memoryStream;

            model.FileExtension = extension.Replace("image/",".");
        }
    }
}
