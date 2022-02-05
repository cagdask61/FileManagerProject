using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class UploadedFile : ISystemEntity
    {
        public string FileType { get; set; }
        public string FileName { get; set; }
        public string DirectoryPath { get; set; }
        public string FullDirectoryPath { get; set; }
    }
}
