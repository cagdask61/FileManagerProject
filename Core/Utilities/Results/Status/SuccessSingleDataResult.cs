using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Status
{
    public class SuccessSingleDataResult<TEntity> : SingleDataResult<TEntity>
    {
        public SuccessSingleDataResult(TEntity singleData) : base(true, singleData)
        {
        }

        public SuccessSingleDataResult(TEntity singleData,string message) : base(true, singleData,message)
        {
        }

    }
}
