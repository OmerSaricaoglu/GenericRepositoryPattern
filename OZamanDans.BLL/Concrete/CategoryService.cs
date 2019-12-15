using OZamanDans.BLL.Abstract;
using OZamanDans.DAL.Abstract;
using OZamanDans.DAL.Concrete.EntityFramework.DAL;
using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.BLL.Concrete
{
    public class CategoryService : ICategoryService
    {

        ICategoryDAL _categoryDAL;
        public CategoryService(ICategoryDAL category)
        {
            _categoryDAL = category;
        }
        public void Delete(Category entity)
        {
            _categoryDAL.Delete(entity);            
        }

        public void DeleteByID(int id)
        {
            Category cat = _categoryDAL.Get(a => a.CategoryID == id);
            _categoryDAL.Delete(cat);
        }

        public Category Get(int entityID)
        {
            return _categoryDAL.Get(a => a.CategoryID == entityID);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public void Insert(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}
