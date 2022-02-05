using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Status
{
    public class SuccessListDataResult<TEntity> : ListDataResult<TEntity>
    {
        public SuccessListDataResult(List<TEntity> listData) : base(true, listData)
        {
        }

        public SuccessListDataResult(List<TEntity> listData,string message) : base(true, listData,message)
        {
        }

    }
}
