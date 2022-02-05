using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISystemFileService
    {
        IResult Add(SystemFile systemFile);
        IResult Delete(SystemFile systemFile);
        IResult Update(SystemFile systemFile);

        IListDataResult<SystemFile> GetAll();
        ISingleDataResult<SystemFile> GetById(int systemFileId);
    }
}
