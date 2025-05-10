using System.Diagnostics;
using RecyclingApp.Models.DataLayer;

namespace RecyclingApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //RecycleContext _context = new RecycleContext();
            //var trailers = _context.Trailers.ToList();

            //dataGridView1.DataSource = trailers;

            TrailersForm trailersForm = new TrailersForm();

            trailersForm.ShowDialog();

            
        }
    }
}
