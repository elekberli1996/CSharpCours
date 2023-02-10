using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            // urunleri listelemk isicn soyle yaziriq
            //etrade bellek icin pahali nesne
            // metod bitdiyi zaman bellekten atar garbec kollektorla yapar
            //using bitdiyi zaman bellekden zorla atar
            datagoster();

        }

        private void datagoster()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void SearchData(string key)
        {
            // kolleksiyon uzerinde arama yapiyoruz baza ile hic alakamiz yok
            //dgwProducts.DataSource = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            var resut=_productDal.SearchData(key);
            dgwProducts.DataSource = resut;
            // baza uzerinde filtir zaman boyuk cicik harf farki yok
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxName.Text.ToString(),
                StockAmount=Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice=Convert.ToDecimal(tbxStockAmount.Text)
            });
            datagoster();
        }

        private void dgwProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            txtStockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
            txtUnitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id= Convert.ToInt32(  dgwProducts.CurrentRow.Cells[0].Value),
            Name = txtNameUpdate.Text,
                StockAmount= Convert.ToInt32(  txtStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(txtUnitPriceUpdate.Text)
            });
            datagoster();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
              
            });
            datagoster();

        }

        private void txbSearch_TextChanged(object sender, EventArgs e)
        {

            SearchData(txbSearch.Text);

        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            _productDal.GetAllId(1);
        }
    }
}
