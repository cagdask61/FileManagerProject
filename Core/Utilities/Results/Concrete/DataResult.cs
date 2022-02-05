using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<TEntity> : Result, IDataResult<TEntity>
    {
        public DataResult(bool status, TEntity data) : base(status)
        {
            Data = data;
        }

        public DataResult(bool status, TEntity data, string message) : base(status,message)
        {
            Data = data;
        }

        public TEntity Data { get; }

    }
}
