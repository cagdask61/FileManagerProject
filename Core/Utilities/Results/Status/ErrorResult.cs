using Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Status
{
    public class ErrorResult : Result
    {
        public ErrorResult():base(false)
        {
        }

        public ErrorResult(string message) : base(false,message)
        {
        }
    }
}
