using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.FileAccess
{
    public interface IFileUpload
    {
        IDataResult<UploadedFile> Upload(IFormFile file,string directoryPath);
    }
}
