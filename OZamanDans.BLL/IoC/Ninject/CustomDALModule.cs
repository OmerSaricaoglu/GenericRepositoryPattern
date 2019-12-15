using Ninject.Modules;
using OZamanDans.DAL.Abstract;
using OZamanDans.DAL.Concrete.EntityFramework.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.BLL.IoC.Ninject
{
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryDAL>().To<CategoryDAL>();
            Bind<IProductDAL>().To<ProductDAL>();
        }
    }
}
