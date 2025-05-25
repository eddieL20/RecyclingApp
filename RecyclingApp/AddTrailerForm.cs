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
    public partial class AddTrailerForm : Form
    {

        public AddTrailerForm()
        {
            InitializeComponent();
        }

        private void btnSubmitTrailer_Click( object sender , EventArgs e )
        {
            var result = ValidateAddTrailerTxt();

            if ( result == null )
                return;

            // Assign values to local variables instead of readonly fields
            var (trailerId, totalWeight, fromLocation, dockNum, arrivalDate ) = result.Value;

            using ( var context = new RecycleContext() )
            {
                var newTrailer = new Trailer
                {
                    TrailerId = trailerId,
                    TotalWeight = totalWeight,
                    FromLocation = fromLocation,
                    DockNum = dockNum,
                    ArrivalDate = arrivalDate
                };
                context.Trailers.Add( newTrailer );
                context.SaveChanges();
            }
            this.Close();
        }

        private (int trailerId, decimal totalWeight, string fromLocation, int dockNum, DateTime arrivalDate)? ValidateAddTrailerTxt()
        {
            try
            {
                if ( string.IsNullOrEmpty( txtTrailerId.Text ) ||
                    string.IsNullOrEmpty( txtTotalWeight.Text ) ||
                    string.IsNullOrEmpty( txtFromLocation.Text ) ||
                    string.IsNullOrEmpty( txtDockNum.Text ) )
                {
                    throw new Exception( "All fields must be filled before submitting." );
                }
                if ( !int.TryParse( txtTrailerId.Text , out int trailerId ) )
                {
                    throw new Exception( "Trailer ID must be a valid integer." );
                }
                if ( !decimal.TryParse( txtTotalWeight.Text , out decimal totalWeight ) )
                {
                    throw new Exception( "Total Weight must be a valid decimal number." );
                }
                if ( txtFromLocation.Text.Trim().Length == 0 )
                {
                    throw new Exception( "From Location cannot be empty or whitespace." );
                }
                if ( !int.TryParse( txtDockNum.Text , out int dockNum ) )
                {
                    throw new Exception( "Dock # must be a valid integer." );
                }

                DateTime arrivalDate = dtArrivalDate.Value;

                MessageBox.Show(
                    "Validation successful!" ,
                    "Success" ,
                    MessageBoxButtons.OK ,
                    MessageBoxIcon.Information );
                return (trailerId, totalWeight, txtFromLocation.Text.Trim(), dockNum, arrivalDate);
            } catch ( Exception ex )
            {
                MessageBox.Show(
                    ex.Message ,
                    "Validation Error" ,
                    MessageBoxButtons.OK ,
                    MessageBoxIcon.Error );
                return null;
            }
        }

        private void btnCancelAddTrailerForm_Click( object sender , EventArgs e )
        {
            this.Close();
        }
    }
}
