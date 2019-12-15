
using Ninject;
using OZamanDans.BLL.Abstract;
using OZamanDans.BLL.IoC.Ninject;
using OZamanDans.UI.WinForm.Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZamanDans.UI.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ninject çalışabilsin diye var
            CustomServiceModule module = new CustomServiceModule();
            IKernel kernel = new StandardKernel(module);
            kernel.Load<CustomDALModule>();
            //instance alınabilsin diye var
            IProductService productService = kernel.Get<IProductService>();
            ICategoryService categoryService = kernel.Get<ICategoryService>();
            Application.Run(new Form1(categoryService,productService));
        }
    }
}
