using RestApiModelDDD.Domains.Core.Interfaces.Reporitories;
using RestApiModelDDD.Domains.Core.Interfaces.Services;
using System.Collections.Generic;

namespace RestApiModelDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            this.repository = repository;
        }

        public void Add(TEntity obj)
        {
            repository.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Remove(TEntity obj)
        {
            repository.Remove(obj);
        }

        public void uodate(TEntity obj)
        {
            repository.Update(obj);
        }
    }
}