using RestApiModelDDD.Domain.Entities;
using RestApiModelDDD.Domains.Core.Interfaces.Reporitories;
using RestApiModelDDD.Domains.Core.Interfaces.Services;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente repositoryCliente;

        public ServiceCliente(IRepositoryCliente repositoryCliente) : base(repositoryCliente)
        {
            this.repositoryCliente = repositoryCliente;
        }
    }
}