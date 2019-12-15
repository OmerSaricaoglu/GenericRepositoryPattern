using OZamanDans.BLL.Abstract;
using OZamanDans.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OZamanDans.UI.WinForm
{
    public partial class Form1 : Form
    {
        public Form1(ICategoryService categoryService, IProductService productService)
        {
            InitializeComponent();
            _categoryService = categoryService;
            _productService = productService;

        }
        ICategoryService _categoryService;
        IProductService _productService;
        private void LoadCategories()
        {
            List<Category> categoryList = _categoryService.GetAll().ToList();
            lstCategories.DisplayMember = "CategoryName";
            lstCategories.ValueMember = "CategoryID";
            lstCategories.DataSource = categoryList;
        }
        private void LoadProducts(int catID)
        {
            if (catID == 0)
            {
                dgvProducts.DataSource = _productService.GetAll();
            }
            else
            {
                dgvProducts.DataSource = _productService.GetProductByCategory(catID);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadProducts(0);
        }
    }
}
