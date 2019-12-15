using OZamanDans.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.BLL.Abstract
{
    public interface IBaseService<T>
        where T : IEntity
    {
        void Insert(T entity);
        void Delete(T entity);
        void DeleteByID(int id);
        void Update(T entity);
        T Get(int entityID);
        ICollection<T> GetAll();

    }
}
