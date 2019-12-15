using OZamanDans.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.Core.DataAccess
{
    //Generic repository'nin ilk kuralı generic bir repository interface'i oluşturmak.

    public interface IEntityRepository<TEntity>
        where TEntity:IEntity
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        TEntity Get(Expression<Func<TEntity, bool>> filter);
        //Func => birden fazla parametre alabilen ve geriye generic dönen metotlar taşır.
        //Predicate => geriye boolean dönen metotlar taşır.
        //Action => 

        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

        
    }
}
