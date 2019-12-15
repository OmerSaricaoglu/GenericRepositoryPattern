using Ninject.Modules;
using OZamanDans.BLL.Abstract;
using OZamanDans.BLL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OZamanDans.UI.WinForm.Ninject
{
    class CustomServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICategoryService>().To<CategoryService>();
            Bind<IProductService>().To<ProductService>();
        }
    }
}
