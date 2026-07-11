using Project10_MongoDbOrder.Entities;
using Project10_MongoDbOrder.Servicees;
using Project10_MongoDbOrder.Services;
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


        OrderOperation orderOperation = new  OrderOperation();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                City=txtCity.Text,
                District = txtDistrict.Text,
                CustomerName = txtCustomerName.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),

            };
            orderOperation.AddOrder(order);
            MessageBox.Show("Başarıyla eklendi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> list = orderOperation.GetAllOrders();
            dataGridView1.DataSource = list;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string  orderId = txtId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silme İşlemi Başarıyla Gercekleşti");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var updateOrder = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomerName.Text,
                District = txtDistrict.Text,
                TotalPrice = decimal.Parse(txtTotalPrice.Text),
                OrderId = id,

            };
            orderOperation.UpdateOrder(updateOrder);
            MessageBox.Show("Başarıyla Güncellendi");
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            String id = txtId.Text;
            Order orders  = orderOperation.GetOrderById(id);
            dataGridView1.DataSource = new List<Order> { orders };
        }
    }
}
