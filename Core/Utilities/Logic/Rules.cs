using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Utilities.Logic
{
    public static class Rules
    {
        public static IResult Run(params IResult[] results)
        {
            foreach (var result in results)
            {
                if (result.Status == false)
                {
                    return result;
                }
            }
            return null;
        }
    }
}
