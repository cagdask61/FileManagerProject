using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Status
{
    public class ErrorListDataResult<TEntity> : ListDataResult<TEntity>
    {
        public ErrorListDataResult(List<TEntity> listData) : base(false, listData)
        {
        }
        public ErrorListDataResult(List<TEntity> listData, string message) : base(false, listData, message)
        {
        }
    }
}
