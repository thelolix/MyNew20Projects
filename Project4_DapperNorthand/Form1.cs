using Dapper;
using Project4_DapperNorthand.dtos.CategoryDtos;
using Project4_DapperNorthand.dtos.ProductDtos;
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

namespace Project4_DapperNorthand
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("server=Talha\\SQLEXPRESS;Initial Catalog=Db5Project20;Integrated Security=True");

        private async void btnCategoryList_Click(object sender, EventArgs e)
        {
            string query = "Select * from Categories";
            var values = await connection.QueryAsync<ResultCategoryDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into Categories (CategoryName,Description) values (@p1,@p2)";
            var parameteres = new DynamicParameters();
            parameteres.Add("@p1", txtCategoryName.Text);
            parameteres.Add("@p2", txtCategoryDescripson.Text); 
            await connection.ExecuteAsync(sql, parameteres);
            MessageBox.Show("Kategori başarıyla eklendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from Categories where CategoryId=@categoryId";
            var parameteres = new DynamicParameters();
            parameteres.Add("categoryId", txtCategoryId.Text);
            await connection.ExecuteAsync(query, parameteres);
            MessageBox.Show("Kategori başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void btnCategoryUpade_Click(object sender, EventArgs e)
        {
            
            string query = "Update Categories Set CategoryName=@categoryName, Description=@description Where CategoryId=@categoryId";

            var parameteres = new DynamicParameters();
            parameteres.Add("@categoryName", txtCategoryName.Text);
            parameteres.Add("@description", txtCategoryDescripson.Text);
            parameteres.Add("@categoryId", txtCategoryId.Text);
            await connection.ExecuteAsync(query, parameteres);

            MessageBox.Show("Kategori başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}