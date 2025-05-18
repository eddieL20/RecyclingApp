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
                    var bins = _context.Bins
                        .Where( b => b.Material != null && b.Material.MaterialName == selectedMaterialName )
                        .ToList();

                    DataVGMaterials.DataSource = bins;
                }
            } else
            {
                MessageBox.Show( "Please select a material from the list." , "Selection Error" , MessageBoxButtons.OK , MessageBoxIcon.Warning );
                // Your code is mostly correct, but there are a few potential issues and improvements:

                //1. **Duplicate Property in Material Class**:
                //   In the `Material` the `Bins` property is declared twice. This will cause a compilation error. You should remove the duplicate declaration:
                //2. **Null Check for DataVGMaterials**:
                //   In the `BtnSelectMaterial_Click` method, you are directly assigning `bins` to `DataVGMaterials.DataSource`. If `DataVGMaterials` is null or improperly initialized, this will throw a `NullReferenceException`. Add a null check:
                //3. **MaterialName Null Check in LINQ Query**:
                //   In the LINQ query, you are already checking `b.Material != null`, but you should also check `b.Material.MaterialName != null` to avoid potential null reference issues:
                //4. **Dispose of DbContext**:
                //   The `_context` field is not being disposed of.Since `RecycleContext` inherits from `DbContext`, it implements `IDisposable`. You should dispose of it properly, either by overriding the `Dispose` method in the form or using a `using` statement.

                //   Example:
                //5. **UI Thread Safety**:
                //   If `LoadMaterials` or `BtnSelectMaterial_Click` is called from a non-UI thread, it may cause cross-thread operation exceptions. Ensure these methods are executed on the UI thread using `Invoke` if necessary.

                //6. **Error Handling for Database Operations**:
                //   Database operations like `LoadMaterials` and `BtnSelectMaterial_Click` should include error handling to catch potential exceptions( e.g., database connection issues ).

                //   Example:
                //By addressing these points, your code will be more robust and less prone to runtime errors.
            }
        }
    }
}
