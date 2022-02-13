using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.FileAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SystemFileManager>().As<ISystemFileService>();
            builder.RegisterType<EfSystemFileDal>().As<ISystemFileDal>();

            builder.RegisterType<FileUpload>().As<IFileUpload>();
        }
    }
}
