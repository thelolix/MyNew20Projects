using Project4_EntityFrameworkCodeFirstMove.DAL.Context;
using Project4_EntityFrameworkCodeFirstMove.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        MoveContext context = new MoveContext();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CategoryName=txtCategoryName.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show("Başarıyla eklendi");
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
            int ıd = int.Parse(txtCategoryId.Text);
            var value = context.Categories.Find(ıd);
            value.CategoryName = txtCategoryName.Text;
            context.SaveChanges();
            MessageBox.Show("Başarıyla Güncellendi", "Bilgi");
            
        
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int ıd = int.Parse(txtCategoryId.Text);
            var value = context.Categories.Find(ıd);
            context.Categories.Remove(value);
            context.SaveChanges();
            MessageBox.Show("Başarıyla Silindi", "Bilgi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = context.Categories.Where(x=>x.CategoryName==txtCategoryName.Text).ToList();
            dataGridView1.DataSource = values;
            context.SaveChanges();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
