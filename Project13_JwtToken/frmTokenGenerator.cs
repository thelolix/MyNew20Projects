using Project13_JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project13_JwtToken
{
    public partial class fmrTokenGenerator : Form
    {
        public fmrTokenGenerator()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateToken_Click(object sender, EventArgs e)
        {

            string Username = txtUserName.Text;
            string Email = txtEmail.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            TokenGenerator tokenGenerator = new TokenGenerator();
            string token = tokenGenerator.GenerateJwtToken(Username,Email,name,surname);
            richTextBox1.Text = token;



        }
    }
}
