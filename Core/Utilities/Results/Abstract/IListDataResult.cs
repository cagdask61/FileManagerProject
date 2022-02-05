using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IListDataResult<TEntity> : IResult
    {
        List<TEntity> ListData { get; }
        int DataCount { get;}
    }
}
