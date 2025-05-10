namespace RecyclingApp
{
    partial class AddTrailerForm
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
            dtArrivalDate = new DateTimePicker();
            txtTrailerId = new TextBox();
            lbTrailerId = new Label();
            label1 = new Label();
            txtTotalWeight = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtFromLocation = new TextBox();
            label4 = new Label();
            txtDockNum = new TextBox();
            btnSubmitTrailer = new Button();
            btnExitAddTrailerForm = new Button();
            SuspendLayout();
            // 
            // dtArrivalDate
            // 
            dtArrivalDate.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            dtArrivalDate.Format = DateTimePickerFormat.Custom;
            dtArrivalDate.Location = new Point(161, 156);
            dtArrivalDate.Name = "dtArrivalDate";
            dtArrivalDate.Size = new Size(250, 27);
            dtArrivalDate.TabIndex = 0;
            // 
            // txtTrailerId
            // 
            txtTrailerId.Location = new Point(161, 54);
            txtTrailerId.Name = "txtTrailerId";
            txtTrailerId.Size = new Size(204, 27);
            txtTrailerId.TabIndex = 1;
            // 
            // lbTrailerId
            // 
            lbTrailerId.AutoSize = true;
            lbTrailerId.Location = new Point(80, 54);
            lbTrailerId.Name = "lbTrailerId";
            lbTrailerId.Size = new Size(70, 20);
            lbTrailerId.TabIndex = 2;
            lbTrailerId.Text = "Trailer Id:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 108);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 3;
            label1.Text = "Total Weight:";
            // 
            // txtTotalWeight
            // 
            txtTotalWeight.Location = new Point(161, 105);
            txtTotalWeight.Name = "txtTotalWeight";
            txtTotalWeight.Size = new Size(204, 27);
            txtTotalWeight.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 156);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 5;
            label2.Text = "Arrival Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 216);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 6;
            label3.Text = "From:";
            // 
            // txtFromLocation
            // 
            txtFromLocation.Location = new Point(161, 213);
            txtFromLocation.Name = "txtFromLocation";
            txtFromLocation.Size = new Size(125, 27);
            txtFromLocation.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 265);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "Dock #:";
            // 
            // txtDockNum
            // 
            txtDockNum.Location = new Point(161, 265);
            txtDockNum.Name = "txtDockNum";
            txtDockNum.Size = new Size(125, 27);
            txtDockNum.TabIndex = 9;
            // 
            // btnSubmitTrailer
            // 
            btnSubmitTrailer.Location = new Point(161, 330);
            btnSubmitTrailer.Name = "btnSubmitTrailer";
            btnSubmitTrailer.Size = new Size(94, 29);
            btnSubmitTrailer.TabIndex = 10;
            btnSubmitTrailer.Text = "Submit";
            btnSubmitTrailer.UseVisualStyleBackColor = true;
            btnSubmitTrailer.Click += btnSubmitTrailer_Click;
            // 
            // btnExitAddTrailerForm
            // 
            btnExitAddTrailerForm.Location = new Point(288, 330);
            btnExitAddTrailerForm.Name = "btnExitAddTrailerForm";
            btnExitAddTrailerForm.Size = new Size(94, 29);
            btnExitAddTrailerForm.TabIndex = 11;
            btnExitAddTrailerForm.Text = "Exit";
            btnExitAddTrailerForm.UseVisualStyleBackColor = true;
            // 
            // AddTrailerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 450);
            Controls.Add(btnExitAddTrailerForm);
            Controls.Add(btnSubmitTrailer);
            Controls.Add(txtDockNum);
            Controls.Add(label4);
            Controls.Add(txtFromLocation);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTotalWeight);
            Controls.Add(label1);
            Controls.Add(lbTrailerId);
            Controls.Add(txtTrailerId);
            Controls.Add(dtArrivalDate);
            Name = "AddTrailerForm";
            Text = "AddTrailerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtArrivalDate;
        private TextBox txtTrailerId;
        private Label lbTrailerId;
        private Label label1;
        private TextBox txtTotalWeight;
        private Label label2;
        private Label label3;
        private TextBox txtFromLocation;
        private Label label4;
        private TextBox txtDockNum;
        private Button btnSubmitTrailer;
        private Button btnExitAddTrailerForm;
    }
}