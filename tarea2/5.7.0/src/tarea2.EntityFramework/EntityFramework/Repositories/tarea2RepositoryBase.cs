using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace tarea2.EntityFramework.Repositories
{
    public abstract class tarea2RepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<tarea2DbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected tarea2RepositoryBase(IDbContextProvider<tarea2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class tarea2RepositoryBase<TEntity> : tarea2RepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected tarea2RepositoryBase(IDbContextProvider<tarea2DbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
