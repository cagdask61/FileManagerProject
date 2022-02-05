using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Status
{
    public class ErrorSingleDataResult<TEntity> : SingleDataResult<TEntity>
    {
        public ErrorSingleDataResult(TEntity singleData):base(false,singleData)
        {
        }

        public ErrorSingleDataResult(TEntity singleData,string message) : base(false, singleData,message)
        {
        }

    }
}
