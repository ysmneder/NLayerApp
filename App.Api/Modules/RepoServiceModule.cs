using System;
using Autofac;
using System.Reflection;
using App.Service.Mapping;
using App.Repository;
using App.Core.Repositories;
using App.Core.UnitOfWork;
using App.Repository.UnitOfWork;
using App.Core.Services;
using App.Repository.Repositories;
using App.Service.Services;
using Module = Autofac.Module;

namespace App.Api.Modules
{
    public class RepoServiceModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As(typeof(IUnitOfWork)).InstancePerLifetimeScope();

            var apiAssembly = Assembly.GetExecutingAssembly();

            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository"
                )).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service"
                )).AsImplementedInterfaces().InstancePerLifetimeScope();






            base.Load(builder);
        }
    }
}

