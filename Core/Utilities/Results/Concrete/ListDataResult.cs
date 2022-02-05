using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class ListDataResult<TEntity> : Result, IListDataResult<TEntity>
    {
        public ListDataResult(bool status, List<TEntity> listData) : base(status)
        {
            ListData = listData;
        }

        public ListDataResult(bool status, List<TEntity> listData, string message) : base(status, message)
        {
            ListData = listData;
        }

        public List<TEntity> ListData { get; }

        public int DataCount { get => ListData.Count; }
    }
}
