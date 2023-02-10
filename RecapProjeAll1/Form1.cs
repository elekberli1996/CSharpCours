using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProjeAll1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProduct();
            ListCatagory();

        }

        private void ListProduct()
        {
            using (NortwindContext nortwindContext = new NortwindContext())
            {
                dgwProducts.DataSource = nortwindContext.Products.ToList();
            }
        }

        private void ListCatagory()
        {
            using (NortwindContext nortwindContext = new NortwindContext())
            {
                cbxCatagory.DataSource = nortwindContext.Categories.ToList();
                cbxCatagory.DisplayMember = "CategoryName";
                cbxCatagory.ValueMember = "CategoryID";

            }
        }
        private void ListProductByCatagory(int id)
        {
            using (NortwindContext nortwindContext = new NortwindContext())
            {
                dgwProducts.DataSource = nortwindContext.Products.Where(p=>p.CategoryID==id).ToList();
            }
        }
        private void ListProductByProduct(string productName)
        {
            using (NortwindContext nortwindContext = new NortwindContext())
            {
                dgwProducts.DataSource = 
                    nortwindContext.Products.Where(p => p.ProductName.ToLower().Contains(productName.ToLower())).ToList();
            }
        }

        private void cbxCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

            var id=Convert.ToInt32( cbxCatagory.SelectedValue);
            ListProductByCatagory(id);
            }
            catch (Exception)
            {

                
            }

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            var key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
            {

                ListProduct();
            }
            else {  
                ListProductByProduct(key);}
           
        }
    }
}
