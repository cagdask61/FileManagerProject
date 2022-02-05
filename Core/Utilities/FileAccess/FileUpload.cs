using Core.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Status;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace Core.Utilities.FileAccess
{
    public class FileUpload : IFileUpload
    {
        private string BaseDirectoryPath { get => Environment.CurrentDirectory + "\\wwwroot"; }

        public FileUpload(string directoryPath)
        {

        }

        public IDataResult<UploadedFile> Upload(IFormFile file, string directoryPath)
        {
            CheckDirectoryExists(directoryPath);
            var checkFileLength = CheckFileLength(file.Length);
            if (checkFileLength.Status == false)
            {
                return new ErrorDataResult<UploadedFile>(new UploadedFile(){ },checkFileLength.Message);
            }

            string fileType = GetFileType(file.FileName);
            string fileName = GetNewFileName();
            UploadedFile uploadedFile = new UploadedFile()
            {
                FileName = fileName,
                FileType = fileType,
                DirectoryPath = directoryPath + fileName,
                FullDirectoryPath = BaseDirectoryPath + directoryPath + fileName
            };
            UploadFile(uploadedFile.FullDirectoryPath, file);
            return new SuccessDataResult<UploadedFile>(uploadedFile);
        }

        private string GetNewFileName()
        {
            return Guid.NewGuid().ToString();
        }

        private string GetFileType(string fileName)
        {
            return Path.GetExtension(fileName);
        }

        private void CheckDirectoryExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        private IResult CheckFileLength(long fileLength)
        {
            long max = 300000000;
            long min = 0;
            if (fileLength <= min || fileLength >= max)
            {
                return new ErrorResult(Messages.FileLengthOutOfRange);
            }
            return new SuccessResult();
        }

        private void UploadFile(string directory, IFormFile file)
        {
            using (FileStream fileStream = File.Create(directory))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
        }

    }
}
