using Autofac;
using RestApiModelDDD.Application;
using RestApiModelDDD.Application.Interfaces;
using RestApiModelDDD.Application.Interfaces.Mappers;
using RestApiModelDDD.Application.Mappers;
using RestApiModelDDD.Domain.Services;
using RestApiModelDDD.Domains.Core.Interfaces.Reporitories;
using RestApiModelDDD.Domains.Core.Interfaces.Services;
using RestApiModelDDD.Infrastructure.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModelDDD.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder) 
        {
            #region IOC
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();



            #endregion



        }


    }
}
