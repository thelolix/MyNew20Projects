using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2_EnitityFrameworkDbFirstProdcut
{
    public partial class FrmProdcut : Form
    {
        public FrmProdcut()
        {
            InitializeComponent();
        }
        Db2Project20Entities db = new Db2Project20Entities();

        void ProductList()
        {
            var values = db.TblProdcut.ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmProdcut_Load(object sender, EventArgs e)
        {
            var categories = db.TblCategory.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = categories;

        }

        private void btnList_Click(object sender, EventArgs e)
        {
           ProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TblProdcut tblProdcut = new TblProdcut();
            tblProdcut.ProductName = txtProductName.Text;
            tblProdcut.ProductPrice= decimal.Parse(txtProductPrice.Text);
            tblProdcut.ProdcutStock = int.Parse(txtProdcutStock.Text);
            tblProdcut.CategoryId = int.Parse(cmbProductCategory.SelectedValue.ToString());
            db.TblProdcut.Add(tblProdcut);
            db.SaveChanges();
            ProductList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtProducId.Text);
            var value = db.TblProdcut.Find(id);
            db.TblProdcut.Remove(value);
            db.SaveChanges();
            ProductList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var value = db.TblProdcut.Find(int.Parse(txtProducId.Text));
            value.ProductPrice = decimal.Parse(txtProductPrice.Text);
            value.ProductName = txtProductName.Text;
            value.ProdcutStock = int.Parse(txtProdcutStock.Text);
            value.CategoryId = int.Parse (cmbProductCategory.SelectedValue.ToString());
            db.SaveChanges();
            ProductList();



        }

        private void btnProdcutListWhitCategory_Click(object sender, EventArgs e)
        {
            var values = db.TblProdcut
                .Join(db.TblCategory,
                Product => Product.ProductId,
                Category => Category.CategoryId,
                (Product,Category) => new
                {
                    ProductId = Product.ProductId,
                    ProductName = Product.ProductName,
                    ProductPrice = Product.ProductPrice,
                    ProductStok = Product.ProductPrice,
                    CategoryId = Category.CategoryId,
                    CategoryName = Category.CategoryName

                }).ToList();
                dataGridView1.DataSource = values;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            var values = db.TblProdcut.Where(x => x.ProductName == txtProductName.Text).ToList();
            dataGridView1.DataSource = values;
            
        }

    }
}
