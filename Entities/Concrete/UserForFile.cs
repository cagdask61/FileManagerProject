using Core.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserForFile : IModel
    {
        public int UserId { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public string Directory { get; set; }

        public IFormFile File { get; set; }
    }
}
