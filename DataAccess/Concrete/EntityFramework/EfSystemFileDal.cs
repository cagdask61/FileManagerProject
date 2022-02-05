using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using DataAccess.DataBase;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSystemFileDal : EfEntityRepositoryBase<SystemFile, FileManagerDb>, ISystemFileDal
    {
    }
}
