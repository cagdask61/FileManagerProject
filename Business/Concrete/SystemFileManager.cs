using Business.Abstract;
using Core.Constants;
using Core.Utilities.FileAccess;
using Core.Utilities.Logic;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Status;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SystemFileManager : ISystemFileService
    {
        private readonly ISystemFileDal _systemFileDal;
        private readonly IFileUpload _fileUpload;
        public SystemFileManager(ISystemFileDal systemFileDal,IFileUpload fileUpload)
        {
            _systemFileDal = systemFileDal;
            _fileUpload = fileUpload;
        }



        public IResult Upload(UserForFile userForFile)
        {
            string directory = "\\files\\" + userForFile.UserId.ToString() + "\\" + userForFile.Directory + "\\";
            var fileUploadResult = _fileUpload.Upload(userForFile.File, directory);
            var result = Rules.Run(fileUploadResult);
            if (result != null)
            {
                return result;
            }

            SystemFile systemFile = new SystemFile()
            {
                Id = 0,
                UserId = userForFile.UserId,
                Description = userForFile.Description,
                IsActive = userForFile.IsActive,
                FileName = fileUploadResult.Data.FileName,
                FileDirectoryPath = fileUploadResult.Data.DirectoryPath.Replace('\\','/'),
                FullFileDirectoryPath = fileUploadResult.Data.FullDirectoryPath.Replace('\\', '/'),
                FileType = fileUploadResult.Data.FileType
            };
            _systemFileDal.Add(systemFile);
            return new SuccessResult(fileUploadResult.Message);
        }

        public IResult Delete(SystemFile systemFile)
        {
            _systemFileDal.Delete(systemFile);
            return new SuccessResult(Messages.SuccessFileDelete);
        }

        public IResult Update(SystemFile systemFile)
        {
            _systemFileDal.Update(systemFile);
            return new SuccessResult(Messages.SuccessFileUpdate);
        }

        public IListDataResult<SystemFile> GetAll()
        {
            return new SuccessListDataResult<SystemFile>(_systemFileDal.GetAll());
        }

        public ISingleDataResult<SystemFile> GetBySystemFileId(int systemFileId)
        {
            return new SuccessSingleDataResult<SystemFile>(_systemFileDal.Get((systemFile) => systemFile.Id == 1));
        }

        public IResult CreateFolder(SystemFolder systemFolder)
        {
            _fileUpload.CreateDirectory(systemFolder.UserId.ToString() + "\\" + systemFolder.Name);
            return new SuccessResult("Klasör başarıyla oluşturuldu");
        }
    }
}
