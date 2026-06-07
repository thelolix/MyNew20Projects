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
    public partial class frmMovie : Form
    {
        public frmMovie()
        {
            InitializeComponent();
        }
        MoveContext context = new MoveContext();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = context.Movies.ToList();
            dataGridView1.DataSource = values;
        }

        private void frmMovie_Load(object sender, EventArgs e)
        {
            var values = context.Categories.ToList();
            cmbMovieCategory.DisplayMember = "CategoryName";
            cmbMovieCategory.ValueMember = "CategoryId";
            cmbMovieCategory.DataSource= values;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle=txtMovieName.Text;
            movie.Description=txtMovieDetalis.Text;
            movie.CreatedDate = DateTime.Parse(mskMovieDate.Text);
            movie.CategoryId=int.Parse(cmbMovieCategory.SelectedValue.ToString());
            movie.Duration = int.Parse(txtMovieTime.Text);
            context.Movies.Add(movie);
            context.SaveChanges();
            btnUpdate2_Click(null, null);
            MessageBox.Show("Başarıyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var value = context.Movies.Find(id);
            context.Movies.Remove(value);
            context.SaveChanges() ;
            MessageBox.Show("Başarıyla Silindi");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values = context.Movies.Where(x=>x.MovieTitle==txtMovieName.Text).ToList();
            dataGridView1.DataSource= values;
            

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtMovieId.Text);
            var values = context.Movies.Find(id);
            values.Duration = int.Parse(txtMovieTime.Text);
            values.MovieTitle = txtMovieName.Text;
            values.Description = txtMovieDetalis.Text;
            values.CreatedDate = DateTime.Parse(mskMovieDate.Text);
            values.CategoryId = int.Parse(cmbMovieCategory.SelectedValue.ToString());

                context.SaveChanges();
                MessageBox.Show("Başarıyla Güncellendi", "Bilgi");
            
        }

        private void btnUpdate2_Click (object sender, EventArgs e)
        {
            var values = (from m in context.Movies
                          join c in context.Categories on m.CategoryId equals c.CategoryId
                          select new
                          {
                              FilmID = m.MovieId,
                              FilmAdi = m.MovieTitle,
                              Kategori = c.CategoryName, 
                              Süre = m.Duration,
                              Açıklama = m.Description
                          }).ToList();

            dataGridView1.DataSource = values;
        }
    }
}

