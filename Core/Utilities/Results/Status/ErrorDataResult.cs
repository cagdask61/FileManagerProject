using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Status
{
    public class ErrorDataResult<TEntity> : DataResult<TEntity>
    {
        public ErrorDataResult(TEntity data) : base(false,data)
        {
        }

        public ErrorDataResult(TEntity data,string message) : base(false, data,message)
        {
        }

    }
}
