using RecyclingApp.Models.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecyclingApp
{
    public partial class UpdateTrailerForm : Form
    {
        private readonly int _trailerId;
        private readonly RecycleContext _context = new();
        public UpdateTrailerForm( int trailerId )
        {
            InitializeComponent();
            _trailerId = trailerId;
            LoadTrailerData();

        }

        private void LoadTrailerData()
        {
            var trailer = _context.Trailers.FirstOrDefault(t => t.TrailerId == _trailerId);

            if ( trailer != null )
            {
                txtTrailerId.Text = trailer.TrailerId.ToString();
                txtTotalWeight.Text = trailer.TotalWeight?.ToString();
                dateTimePickerArrival.Value = trailer.ArrivalDate ?? DateTime.Now; // Fix: Use null-coalescing operator to handle nullable DateTime
                dateTimePickerCompletion.Value = trailer.CompletionDate ?? DateTime.Now;
                txtFrom.Text = trailer.FromLocation ?? "";
                txtDockNum.Text = trailer.DockNum?.ToString() ?? ""; // Fix: Ensure DockNum is nullable-safe

                if ( chkBoxSetCompletionDate.Checked )
                {
                    trailer.CompletionDate = dateTimePickerCompletion.Value;
                } else
                {
                    trailer.CompletionDate = null;
                }
            }
        }

        private void BtnTrailerUpdateSubmit_Click( object sender , EventArgs e )
        {
            try
            {
                if( !int.TryParse( txtTrailerId.Text, out var trailerId ) )
                {

                }
            } catch( Exception ex )
            {

            }
        }
    }
}
