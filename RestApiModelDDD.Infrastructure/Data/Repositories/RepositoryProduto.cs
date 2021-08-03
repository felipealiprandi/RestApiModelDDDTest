using RestApiModelDDD.Domain.Entities;
using RestApiModelDDD.Domains.Core.Interfaces.Reporitories;

namespace RestApiModelDDD.Infrastructure.Data.Repositories
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly SqlContext sqlContext;

        public RepositoryProduto(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}