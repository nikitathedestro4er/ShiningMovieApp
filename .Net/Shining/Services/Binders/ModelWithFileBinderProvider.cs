using DTOs.File;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shining.Services.Binders
{
    public class ModelWithFileBinderProvider : IModelBinderProvider
    {
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if(typeof(IFileHolder).IsAssignableFrom(context.Metadata.ModelType))
            {
                return new ModelWithFileBinder(new ComplexObjectModelBinderProvider().GetBinder(context));
            }

            return null;
        }
    }
}
