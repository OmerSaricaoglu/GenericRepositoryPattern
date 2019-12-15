using OZamanDans.BLL.Abstract;
using OZamanDans.DAL.Abstract;
using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.BLL.Concrete
{
    public class ProductService : IProductService
    {
        IProductDAL _productDAL;
        public ProductService(IProductDAL product)
        {
            _productDAL = product;
        }
        public void Delete(Product entity)
        {
            _productDAL.Delete(entity);
        }

        public void DeleteByID(int id)
        {
            Product pro = _productDAL.Get(a => a.ProductID == id);
            _productDAL.Delete(pro);
        }

        public Product Get(int entityID)
        {
            return _productDAL.Get(a => a.ProductID == entityID);
        }

        public ICollection<Product> GetAll()
        {
            return _productDAL.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryID)
        {
            return _productDAL.GetAll(a => a.CategoryID == categoryID).ToList();
        }

        public void Insert(Product entity)
        {
            _productDAL.Add(entity);
        }

        public void Update(Product entity)
        {
            _productDAL.Update(entity);
        }
    }
}
