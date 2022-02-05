using Business.Abstract;
using Core.Utilities.FileAccess;
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
        private ISystemFileDal _systemFileDal;
        private IFileUpload _fileUpload;
        public SystemFileManager(ISystemFileDal systemFileDal,IFileUpload fileUpload)
        {
            _systemFileDal = systemFileDal;
            _fileUpload = fileUpload;
        }

        public IResult Add(SystemFile systemFile)
        {
            // Parametreler düzeltilecek
           // _systemFileDal.Add(systemFile);
            return new SuccessResult();
        }

        public IResult Delete(SystemFile systemFile)
        {
            _systemFileDal.Delete(systemFile);
            return new SuccessResult();
        }

        public IResult Update(SystemFile systemFile)
        {
            _systemFileDal.Update(systemFile);
            return new SuccessResult();
        }

        public IListDataResult<SystemFile> GetAll()
        {
            return new SuccessListDataResult<SystemFile>(_systemFileDal.GetAll());
        }

        public ISingleDataResult<SystemFile> GetById(int systemFileId)
        {
            return new SuccessSingleDataResult<SystemFile>(_systemFileDal.Get((systemFile) => systemFile.Id == 1));
        }

      
    }
}
