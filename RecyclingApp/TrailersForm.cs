using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecyclingApp.Models.DataLayer;

namespace RecyclingApp
{
    public partial class TrailersForm : Form
    {
        public TrailersForm()
        {
            InitializeComponent();
        }

        private void btnInProgressTrailers_Click(object sender, EventArgs e)
        {
            using (var context = new RecycleContext())
            {
                dataGVTrailers.DataSource= context.Trailers
                    .Where(t => t.CompletionDate == null)
                    .ToList();
            }
        }

        private void btnRemoveTrailer_Click(object sender, EventArgs e)
        {
            if (dataGVTrailers.SelectedRows.Count > 0)
            {
                using (var context = new RecycleContext())
                {
                    foreach (DataGridViewRow row in dataGVTrailers.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["TrailerId"].Value);
                        var trailer = context.Trailers.SingleOrDefault(t => t.TrailerId == id);
                        if (trailer != null)
                        {
                            context.Trailers.Remove(trailer);
                            context.SaveChanges();
                            
                        }
                    }
                }
            }
        }

        private void btnUpdateTrailer_Click(object sender, EventArgs e)
        {
            // Add logic to handle the "Update Trailer" button click event.  
            MessageBox.Show("Update Trailer button clicked!");
        }

        private void btnCompletedTrailers_Click(object sender, EventArgs e)
        {
            using ( var context = new RecycleContext())
            {
                dataGVTrailers.DataSource = context.Trailers
                    .Where(t => t.CompletionDate != null)
                    .ToList();
            }
        }

        private void TrailersForm_Load(object sender, EventArgs e)
        {
            // Add logic to handle the form load event.  
            //MessageBox.Show("TrailersForm loaded!");
        }

        private void btnAddTrailer_Click(object sender, EventArgs e)
        {
            AddTrailerForm addTrailerForm = new AddTrailerForm();
            addTrailerForm.ShowDialog();
        }
    }
}
