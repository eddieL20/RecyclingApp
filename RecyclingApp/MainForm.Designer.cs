namespace RecyclingApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            BtnMaterials = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point( 12 , 37 );
            button1.Name = "button1";
            button1.Size = new Size( 281 , 41 );
            button1.TabIndex = 0;
            button1.Text = "Docked Trailers";
            button1.UseVisualStyleBackColor = true;
            button1.Click +=  button1_Click ;
            // 
            // BtnMaterials
            // 
            BtnMaterials.Location = new Point( 12 , 99 );
            BtnMaterials.Name = "BtnMaterials";
            BtnMaterials.Size = new Size( 281 , 43 );
            BtnMaterials.TabIndex = 1;
            BtnMaterials.Text = "Materials";
            BtnMaterials.UseVisualStyleBackColor = true;
            BtnMaterials.Click +=  BtnMaterials_Click ;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point( 0 , 0 );
            panel1.Name = "panel1";
            panel1.Size = new Size( 1134 , 652 );
            panel1.TabIndex = 2;
            panel1.Paint +=  panel1_Paint ;
            // 
            // panel2
            // 
            panel2.Controls.Add( button1 );
            panel2.Controls.Add( BtnMaterials );
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point( 0 , 0 );
            panel2.Name = "panel2";
            panel2.Size = new Size( 335 , 652 );
            panel2.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF( 8F , 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 1134 , 652 );
            Controls.Add( panel2 );
            Controls.Add( panel1 );
            Name = "MainForm";
            Text = "Recycling App";
            panel2.ResumeLayout( false );
            ResumeLayout( false );
        }

        #endregion

        private Button button1;
        private Button BtnMaterials;
        private Panel panel1;
        private Panel panel2;
    }
}
