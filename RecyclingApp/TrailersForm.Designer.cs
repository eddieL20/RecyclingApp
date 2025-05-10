namespace RecyclingApp
{
    partial class TrailersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInProgressTrailers = new Button();
            btnAddTrailer = new Button();
            btnRemoveTrailer = new Button();
            btnUpdateTrailer = new Button();
            dataGVTrailers = new DataGridView();
            btnCompletedTrailers = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGVTrailers).BeginInit();
            SuspendLayout();
            // 
            // btnInProgressTrailers
            // 
            btnInProgressTrailers.Location = new Point(42, 50);
            btnInProgressTrailers.Name = "btnInProgressTrailers";
            btnInProgressTrailers.Size = new Size(200, 50);
            btnInProgressTrailers.TabIndex = 0;
            btnInProgressTrailers.Text = "In-Progress Trailers";
            btnInProgressTrailers.UseVisualStyleBackColor = true;
            btnInProgressTrailers.Click += btnInProgressTrailers_Click;
            // 
            // btnAddTrailer
            // 
            btnAddTrailer.Location = new Point(42, 190);
            btnAddTrailer.Name = "btnAddTrailer";
            btnAddTrailer.Size = new Size(200, 50);
            btnAddTrailer.TabIndex = 1;
            btnAddTrailer.Text = "Add Trailer";
            btnAddTrailer.UseVisualStyleBackColor = true;
            btnAddTrailer.Click += btnAddTrailer_Click;
            // 
            // btnRemoveTrailer
            // 
            btnRemoveTrailer.Location = new Point(365, 431);
            btnRemoveTrailer.MaximumSize = new Size(200, 100);
            btnRemoveTrailer.Name = "btnRemoveTrailer";
            btnRemoveTrailer.Size = new Size(200, 50);
            btnRemoveTrailer.TabIndex = 2;
            btnRemoveTrailer.Text = "Remove Trailer";
            btnRemoveTrailer.UseVisualStyleBackColor = true;
            btnRemoveTrailer.Click += btnRemoveTrailer_Click;
            // 
            // btnUpdateTrailer
            // 
            btnUpdateTrailer.Location = new Point(598, 431);
            btnUpdateTrailer.MaximumSize = new Size(200, 100);
            btnUpdateTrailer.Name = "btnUpdateTrailer";
            btnUpdateTrailer.Size = new Size(200, 50);
            btnUpdateTrailer.TabIndex = 3;
            btnUpdateTrailer.Text = "Update Trailer";
            btnUpdateTrailer.UseVisualStyleBackColor = true;
            btnUpdateTrailer.Click += btnUpdateTrailer_Click;
            // 
            // dataGVTrailers
            // 
            dataGVTrailers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVTrailers.Location = new Point(365, 50);
            dataGVTrailers.Name = "dataGVTrailers";
            dataGVTrailers.RowHeadersWidth = 51;
            dataGVTrailers.Size = new Size(623, 351);
            dataGVTrailers.TabIndex = 4;
            // 
            // btnCompletedTrailers
            // 
            btnCompletedTrailers.Location = new Point(42, 125);
            btnCompletedTrailers.Name = "btnCompletedTrailers";
            btnCompletedTrailers.Size = new Size(200, 50);
            btnCompletedTrailers.TabIndex = 5;
            btnCompletedTrailers.Text = "Completed Trailers";
            btnCompletedTrailers.UseVisualStyleBackColor = true;
            btnCompletedTrailers.Click += btnCompletedTrailers_Click;
            // 
            // TrailersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 533);
            Controls.Add(btnCompletedTrailers);
            Controls.Add(dataGVTrailers);
            Controls.Add(btnUpdateTrailer);
            Controls.Add(btnRemoveTrailer);
            Controls.Add(btnAddTrailer);
            Controls.Add(btnInProgressTrailers);
            Name = "TrailersForm";
            Text = "Trailers";
            Load += TrailersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGVTrailers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInProgressTrailers;
        private Button btnAddTrailer;
        private Button btnRemoveTrailer;
        private Button btnUpdateTrailer;
        private DataGridView dataGVTrailers;
        private Button btnCompletedTrailers;
    }
}