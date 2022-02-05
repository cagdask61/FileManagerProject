using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SystemFile : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public string Description { get; set; }

        public string FileName { get; set; }
        public string FileDirectoryPath { get; set; }
        public string FullFileDirectoryPath { get; set; }

        public bool IsActive { get; set; }
    }
}
