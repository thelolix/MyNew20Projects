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
    public partial class FrmCity : Form
    {
        
        SqlConnection SqlConnection = new SqlConnection("server=Talha\\SQLEXPRESS;Initial Catalog=CustomerDB;Integrated Security=True");

        public FrmCity()
        {
            InitializeComponent();
        }

        private void FrmCity_Load(object sender, EventArgs e)
        {
            // Form yüklenirken yapılacak işlemler gerekirse buraya yazılır.
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand command = new SqlCommand("Update tblCity Set CityName=@cityName, Citycountry=@cityCountry where CityId=@cityId", SqlConnection);

            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            command.Parameters.AddWithValue("@cityId", Convert.ToInt32(txtCityId.Text));

            int etkilenenSatir = command.ExecuteNonQuery();
            SqlConnection.Close();

            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Şehir Başarıyla Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Girdiğiniz ID numarasına ait bir şehir bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCity", SqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            SqlConnection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand command = new SqlCommand("Insert into TblCity (CityName,CityCountry) values (@cityName,@cityCountry)", SqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
            command.ExecuteNonQuery();
            SqlConnection.Close();
            MessageBox.Show("Şehir Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand command = new SqlCommand("Delete from TblCity where CityId=@cityId", SqlConnection);

            // DÜZELTME: Silme işleminde de ID'yi int tipine çeviriyoruz ve eksik olan '@' işaretini parametreye ekledik.
            command.Parameters.AddWithValue("@cityId", Convert.ToInt32(txtCityId.Text));

            int etkilenenSatir = command.ExecuteNonQuery();
            SqlConnection.Close();

            if (etkilenenSatir > 0)
            {
                MessageBox.Show("Şehir Başarıyla Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silinmek istenen ID bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCity where CityName=@cityName", SqlConnection);
            command.Parameters.AddWithValue("@cityName", txtCityName.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            SqlConnection.Close();
        }
    }
}