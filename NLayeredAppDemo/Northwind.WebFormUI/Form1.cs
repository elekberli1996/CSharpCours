using Northwind.DataAccess.Concrete.EntityFramework;
using Nortwind.Business.Abstract;
using Nortwind.Business.Concrete;
using Nortwind.DataAccess.Abstract;
using Nortwind.DataAccess.Concrete.EntityFramework;
using Nortwind.DataAccess.Concrete.Orcale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _catagoryService = new CatagoryManager(new EfCatagoryDal());

        }
        IProductService _productService;
        ICatagoryService _catagoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduct();
            LoadCatagory();
            //yanliz product manageri kullaniriq

            // D dependenci inversion bir katman diyer katmani newleye bilmez bagilmi olursun
            // Open close prinsipi bi ekleme yapiliginda koldlarda deyisiklik  yapmamalisin
        }
        private void LoadCatagory()
        {
            cbxKatagory.DataSource = _catagoryService.getAll();
            cbxKatagory.DisplayMember = "CatagoryName";
            cbxKatagory.ValueMember = "CatagoryID";
        }
        private void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetProducts();
        }
    }
}
