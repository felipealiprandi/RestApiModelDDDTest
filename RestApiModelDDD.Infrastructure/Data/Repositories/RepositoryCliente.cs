using RestApiModelDDD.Domain.Entities;
using RestApiModelDDD.Domains.Core.Interfaces.Reporitories;

namespace RestApiModelDDD.Infrastructure.Data.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly SqlContext sqlContext;

        public RepositoryCliente(SqlContext sqlContext) : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}
