using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetYeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dgwProducts.DataSource = _productDal.GetAll();
        }
ProductDal _productDal = new ProductDal();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text,
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });

         
            dgwProducts.DataSource = _productDal.GetAll();


        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id= Convert.ToInt32(  dgwProducts.CurrentRow.Cells[0].Value.ToString()),
            Name = txtNameUpdate.Text,
            UnitPrice=Convert.ToDecimal( txtUnitPriceUpdate.Text),
            StockAmount=Convert.ToInt32(txtStockAmountUpdate.Text)
             });
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
              int  id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value.ToString());
            _productDal.Delete(id);
            dgwProducts.DataSource = _productDal.GetAll();
        }
    }
}
