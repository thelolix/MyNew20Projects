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

namespace Project13_JwtToken
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("server=Talha\\SQLEXPRESS;Initial Catalog=Db13Project20;Integrated Security=True");

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * from TblUser where UserName=@username and Password=@password",sqlConnection);
            command.Parameters.AddWithValue("@username",txtUserName.Text);
            command.Parameters.AddWithValue("@password", txtPassword.Text);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                frmEmployee frm = new frmEmployee();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Girilen kullanıcı adı veya şifre hatalıdır");
                txtPassword.Clear();
                txtUserName.Clear();
                txtUserName.Focus();
            }
            sqlConnection.Close();
        
        }
    }
}
