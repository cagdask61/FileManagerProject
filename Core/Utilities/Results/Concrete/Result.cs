using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool status)
        {
            Status = status;
        }

        public Result(bool status, string message) : this(status)
        {
            Message = message;
        }

        public bool Status { get; }

        public string Message { get; }
    }
}
