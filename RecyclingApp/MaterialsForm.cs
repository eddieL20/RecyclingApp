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
    public partial class MaterialsForm : Form
    {
        private readonly RecycleContext _context = new();
        public MaterialsForm()
        {
            InitializeComponent();
            LoadMaterials();
        }

        private void LoadMaterials()
        {
            var materials = _context.Materials;

            foreach ( var material in materials )
            {
                if ( !string.IsNullOrEmpty( material.MaterialName ) ) // Ensure MaterialName is not null or empty
                {
                    LstBoxMaterials.Items.Add( material.MaterialName );
                }
            }
        }

        private void BtnSelectMaterial_Click( object sender , EventArgs e )
        {
            // Check if a material is selected and handle null cases
            if ( LstBoxMaterials.SelectedItem != null )
            {
                var selectedMaterialName = LstBoxMaterials.SelectedItem.ToString();

                if ( !string.IsNullOrEmpty( selectedMaterialName ) )
                {
                    var binData = _context.Bins
                        .Where(b => b.Material != null && b.Material.MaterialName == selectedMaterialName)
                        .Select(b => new
                        {
                            TrailerId = b.TrailerId,
                            MaterialName = b.Material!.MaterialName, // Use null-forgiving operator (!) to suppress CS8602
                            GrossWeight = b.GrossWeight,
                            FinishedDate = b.Trailer != null ? b.Trailer.CompletionDate : null
                        })
                        .ToList();

                    DataVGMaterials.DataSource = binData;

                    DataVGMaterials.Columns [ "MaterialName" ].HeaderText = "Material";
                    DataVGMaterials.Columns [ "TrailerId" ].HeaderText = "Trailer";
                    DataVGMaterials.Columns [ "GrossWeight" ].HeaderText = "Gross Weight";
                    DataVGMaterials.Columns [ "FinishedDate" ].HeaderText = "Completion Date";
                }
            } else
            {
                MessageBox.Show( "Please select a material from the list." , "Selection Error" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
            }
        }
    }
}
