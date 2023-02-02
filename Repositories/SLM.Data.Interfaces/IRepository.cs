using SLM.Data.Models;
using System.Linq.Expressions;

namespace SLM.Data.Interfaces
{


    //Using generric parameter
    public interface IRepository <TEntity> where TEntity : BaseEntity
    {
        IList<TEntity> GetAll ();
        IQueryable<TEntity> Get (Expression <Func<TEntity,bool>> predicate);

        void Save (TEntity entity);

        void Delete (TEntity entity);



    }
}