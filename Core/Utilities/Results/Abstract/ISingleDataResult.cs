using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface ISingleDataResult<TEntity> : IResult
    {
        TEntity SingleData { get; }
    }
}
