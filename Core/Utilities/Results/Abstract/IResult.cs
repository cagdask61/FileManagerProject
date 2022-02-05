using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Abstract
{
    public interface IResult
    {
        bool Status { get; }
        string Message { get;}
    }
}
