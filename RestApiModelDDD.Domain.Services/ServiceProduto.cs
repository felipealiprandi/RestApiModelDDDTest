using RestApiModelDDD.Domain.Entities;
using RestApiModelDDD.Domains.Core.Interfaces.Reporitories;
using RestApiModelDDD.Domains.Core.Interfaces.Services;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceProduto : ServiceBase<Produto>, IServiceProduto
    {
        private readonly IRepositoryProduto repositoryProduto;

        public ServiceProduto(IRepositoryProduto repositoryProduto) : base(repositoryProduto)
        {
            this.repositoryProduto = repositoryProduto;
        }
    }
}