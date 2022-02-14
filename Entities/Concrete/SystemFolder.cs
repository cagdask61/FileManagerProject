using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SystemFolder : IModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
