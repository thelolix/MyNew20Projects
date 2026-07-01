using Project10_MongoDbOrder.Entities;
using Project10_MongoDbOrder.Servicees;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project10_MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        OrderOparestion oparestion = new OrderOparestion();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City=txtCity.Text,
                Distiric = txtDistrict.Text,
                CustomerName = txtCustomerName.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),

            };
            oparestion.AddOrder(order);
            MessageBox.Show("Başarıyla eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
