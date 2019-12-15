using OZamanDans.Core.DataAccess.EntityFramework;
using OZamanDans.DAL.Abstract;
using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.DAL.Concrete.EntityFramework.DAL
{
    public class ProductDAL:EFRepositoryBase<Product,OZamanDansDbContext>,IProductDAL
    {

    }
}
