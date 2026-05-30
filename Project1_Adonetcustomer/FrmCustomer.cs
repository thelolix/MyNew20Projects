using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_Adonetcustomer
{
    public partial class FrmCustomer : Form
    {
        SqlConnection sqlConnection = new SqlConnection("server=Talha\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");

        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("Select * from TblCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbmCity.ValueMember = "CityId";
            cbmCity.DisplayMember = "CityName";
            cbmCity.DataSource = dataTable;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            
            SqlCommand command = new SqlCommand("Select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer inner join TblCity on TblCity.CityId = TblCustomer.CustomerCity", sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Insert into TblCustomer (CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CustomerCity) values (@customerName,@customerSurname,@customerBalance,@customerStatus,@customerCity)", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
            command.Parameters.AddWithValue("@customerCity", cbmCity.SelectedValue);
            if (rdrActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }
            else
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarıyla Eklendi");
        }

        private void cbmCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete from TblCustomer where CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarıyla Silindi","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Update TblCustomer set CustomerName=@customerName, CustomerSurname=@customerSurname, CustomerBalance=@customerBalance, CustomerStatus=@customerStatus, CustomerCity=@customerCity where CustomerId=@customerId", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
            command.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
            command.Parameters.AddWithValue("@customerCity", cbmCity.SelectedValue);
            if (rdrActive.Checked)
            {
                command.Parameters.AddWithValue("@customerStatus", true);
            }
            else
            {
                command.Parameters.AddWithValue("@customerStatus", false);
            }
            command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Müşteri Başarıyla Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select customerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CustomerCity from TblCustomer inner join TblCity on TblCity.CityId = TblCustomer.CustomerCity where CustomerName=@customerName", sqlConnection);
            command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();

        }
    }
}
