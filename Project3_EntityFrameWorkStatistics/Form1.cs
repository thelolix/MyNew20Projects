using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3_EntityFrameWorkStatistics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Db3Project20Entities db = new Db3Project20Entities();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Toplam Kategori Sayısı
            int CategoryCount = db.TblCategory.Count();
            lblCategoryCount.Text = CategoryCount.ToString();

            //Toplam Ürün Sayısı
            int ProductCount = db.TblProduct.Count();
            lblProductCount.Text = ProductCount.ToString();

            //Toplam Müşteri Sayısı
            int CustomerCount = db.TblCustomer.Count();
            lblCustomerCount.Text = CustomerCount.ToString();

            //Toplam Sipariş Sayısı
            int OrderCount = db.TblOrder.Count();
            lblOrderCount.Text = OrderCount.ToString();

            //Toplam Stok Sayısı
            var TotalCount = db.TblProduct.Sum(x => x.ProductStock);
            lblTotalStock.Text = TotalCount.ToString();

            //Ortalama Ürün Fiyatı
            var AvgProductPrice = db.TblProduct.Average(x => x.ProductPrice);
            lblProductAvaregePrice.Text = AvgProductPrice.ToString() + "₺";

            //Toplam Meyve Stoğu Sayısı
            var TotalProdcutCountFruit = db.TblProduct.Where(x=>x.CategoryId == 1).Sum(y=>y.ProductStock);
            lblFruitStockCount.Text = TotalProdcutCountFruit.ToString();

            //Gazoz İceccegin İşlem Hacimi
            var TotalPriceByProductNameGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductStock).FirstOrDefault();
            var TotalPriceByProductNameGazozPrice = db.TblProduct.Where(x=>x.ProductName == "Gazoz").Select(y=>y.ProductPrice).FirstOrDefault();
            var TotalPriceByProductNameGazoz = TotalPriceByProductNameGazozGetStock * TotalPriceByProductNameGazozPrice;
            lblTotalPriceByProductNameİsGazoz.Text = TotalPriceByProductNameGazoz.ToString();


            //Stok sayısı 100'den düşük ürünler
            var porductCountByStockCountSmallerThen100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
            lblProductStockSmallerThen100.Text = porductCountByStockCountSmallerThen100.ToString();

            //Kategorisi Sebze ve Durumu Aktif(True) Olan Stok Toplamı
            var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where(x=>x.CategoryId == 2 && x.ProductStatus == true).Sum(y=> y.ProductStock);
            lblProdcutCountSebzeAndStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();

            //Türkiyeden Yapılan Siparişler
            int customerId = db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye").Select(y => y.CustomerId).FirstOrDefault();
            lblOrderCountFromTurkıye.Text = customerId.ToString();

            //Siparişler içinde kategorisi meyve olan ürünlerin fiyatı SQL
            var OrderCategoryMeyvePriceSql = db.Database.SqlQuery<Decimal>("Select sum(o.totalPrice) as ToplamMeyvePrice From TblOrder o join TblProduct p on o.ProdcutId=p.ProdcutId join TblCategory c on p.CategoryId=c.CategoryId where c.CategoryName = 'Meyve'").FirstOrDefault();
            lblOrderTotalPriceByCategoryİsMeyveSql.Text= OrderCategoryMeyvePriceSql.ToString() + "₺";

            //iparişler içinde kategorisi meyve olan ürünlerin fiyatı EF
            var OrderCategoryMeyvePrice = db.TblOrder.Where(x=>x.ProdcutId == 1 || x.ProdcutId == 2 || x.ProdcutId == 3 || x.ProdcutId == 10).Sum(y=>y.TotalPrice).ToString();
            lblOrderTotalPriceByCategoryİsMeyve.Text = OrderCategoryMeyvePrice + "₺";

            //Son eklenen ürün adı
            var lastProdcutName = db.TblProduct.OrderByDescending(x=>x.ProdcutId).Select(y=>y.ProductName).FirstOrDefault();
            lblLastProductName.Text = lastProdcutName.ToString();

            //Son eklenen Ürünün category adı
            var lastAddCategoryıd = db.TblProduct.OrderByDescending(x => x.ProdcutId).Select(y => y.CategoryId).FirstOrDefault();
            var lastAddCategoryName = db.TblCategory.Where(x=>x.CategoryId == lastAddCategoryıd).Select(y=>y.CategoryName).FirstOrDefault();
            lblLastAddCategory.Text = lastAddCategoryName.ToString();

            //Active ürün sayısı
            var activeProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
            lblActiveProductCount.Text = activeProductCount.ToString();

            //Toplam Koal Stok Satışlarından Kazanılan Para
            var kolaTotal = db.TblProduct.Where(x => x.ProductName == "Kola").Sum(y => (y.ProductStock * y.ProductPrice)); 
            lblTotalWhitCola.Text = kolaTotal.ToString() + " ₺";

            //sisteme son eklene müşteri adı
            var lastCustomertName = db.TblCustomer.OrderByDescending(x => x.CustomerId).Select(y => y.CustomerName).FirstOrDefault();
           lblLastCustomerName.Text = lastCustomertName.ToString();

            //Ülke ÇEşitliligi
            var countryDifferenCount = db.TblCustomer.Select(x=>x.CustomerCountry).Distinct().Count();
            lblCountry.Text = countryDifferenCount.ToString();




        }
        
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblProductStockSmallerThen100_Click(object sender, EventArgs e)
        {

        }

        private void lblProdcutCountSebzeAndStatusTrue_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }
    }
}
