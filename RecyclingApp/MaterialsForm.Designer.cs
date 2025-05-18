namespace RecyclingApp
{
    partial class MaterialsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnSelectMaterial = new Button();
            LstBoxMaterials = new ListBox();
            DataVGMaterials = new DataGridView();
            ( ( System.ComponentModel.ISupportInitialize ) DataVGMaterials ).BeginInit();
            SuspendLayout();
            // 
            // BtnSelectMaterial
            // 
            BtnSelectMaterial.Location = new Point( 217 , 34 );
            BtnSelectMaterial.Name = "BtnSelectMaterial";
            BtnSelectMaterial.Size = new Size( 217 , 44 );
            BtnSelectMaterial.TabIndex = 0;
            BtnSelectMaterial.Text = "Select";
            BtnSelectMaterial.UseVisualStyleBackColor = true;
            BtnSelectMaterial.Click +=  BtnSelectMaterial_Click ;
            // 
            // LstBoxMaterials
            // 
            LstBoxMaterials.FormattingEnabled = true;
            LstBoxMaterials.Location = new Point( 50 , 34 );
            LstBoxMaterials.Name = "LstBoxMaterials";
            LstBoxMaterials.ScrollAlwaysVisible = true;
            LstBoxMaterials.Size = new Size( 138 , 124 );
            LstBoxMaterials.TabIndex = 1;
            // 
            // DataVGMaterials
            // 
            DataVGMaterials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataVGMaterials.Location = new Point( 50 , 195 );
            DataVGMaterials.Name = "DataVGMaterials";
            DataVGMaterials.RowHeadersWidth = 51;
            DataVGMaterials.Size = new Size( 709 , 188 );
            DataVGMaterials.TabIndex = 2;
            // 
            // MaterialsForm
            // 
            AutoScaleDimensions = new SizeF( 8F , 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 800 , 450 );
            Controls.Add( DataVGMaterials );
            Controls.Add( LstBoxMaterials );
            Controls.Add( BtnSelectMaterial );
            Name = "MaterialsForm";
            Text = "Materials Form";
            ( ( System.ComponentModel.ISupportInitialize ) DataVGMaterials ).EndInit();
            ResumeLayout( false );
        }

        #endregion

        private Button BtnSelectMaterial;
        private ListBox LstBoxMaterials;
        private DataGridView DataVGMaterials;
    }
}