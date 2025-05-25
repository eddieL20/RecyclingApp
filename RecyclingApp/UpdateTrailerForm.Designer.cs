namespace RecyclingApp
{
    partial class UpdateTrailerForm
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
            txtTrailerId = new TextBox();
            txtTotalWeight = new TextBox();
            txtFrom = new TextBox();
            txtDockNum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            BtnTrailerUpdateSubmit = new Button();
            BtnUpdateTrailerCancel = new Button();
            dateTimePickerArrival = new DateTimePicker();
            dateTimePickerCompletion = new DateTimePicker();
            chkBoxSetCompletionDate = new CheckBox();
            SuspendLayout();
            // 
            // txtTrailerId
            // 
            txtTrailerId.Location = new Point( 180 , 45 );
            txtTrailerId.Name = "txtTrailerId";
            txtTrailerId.Size = new Size( 113 , 27 );
            txtTrailerId.TabIndex = 0;
            // 
            // txtTotalWeight
            // 
            txtTotalWeight.Location = new Point( 180 , 78 );
            txtTotalWeight.Name = "txtTotalWeight";
            txtTotalWeight.Size = new Size( 80 , 27 );
            txtTotalWeight.TabIndex = 1;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point( 178 , 210 );
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size( 168 , 27 );
            txtFrom.TabIndex = 4;
            // 
            // txtDockNum
            // 
            txtDockNum.Location = new Point( 180 , 241 );
            txtDockNum.Name = "txtDockNum";
            txtDockNum.Size = new Size( 64 , 27 );
            txtDockNum.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point( 104 , 48 );
            label1.Name = "label1";
            label1.Size = new Size( 70 , 20 );
            label1.TabIndex = 6;
            label1.Text = "Trailer Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point( 78 , 81 );
            label2.Name = "label2";
            label2.Size = new Size( 96 , 20 );
            label2.TabIndex = 7;
            label2.Text = "Total Weight:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point( 83 , 114 );
            label3.Name = "label3";
            label3.Size = new Size( 91 , 20 );
            label3.TabIndex = 8;
            label3.Text = "Arrival Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point( 48 , 147 );
            label4.Name = "label4";
            label4.Size = new Size( 126 , 20 );
            label4.TabIndex = 9;
            label4.Text = "Completion Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point( 126 , 213 );
            label5.Name = "label5";
            label5.Size = new Size( 46 , 20 );
            label5.TabIndex = 10;
            label5.Text = "From:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point( 115 , 244 );
            label6.Name = "label6";
            label6.Size = new Size( 59 , 20 );
            label6.TabIndex = 11;
            label6.Text = "Dock #:";
            // 
            // BtnTrailerUpdateSubmit
            // 
            BtnTrailerUpdateSubmit.Location = new Point( 211 , 303 );
            BtnTrailerUpdateSubmit.Name = "BtnTrailerUpdateSubmit";
            BtnTrailerUpdateSubmit.Size = new Size( 137 , 29 );
            BtnTrailerUpdateSubmit.TabIndex = 12;
            BtnTrailerUpdateSubmit.Text = "Submit";
            BtnTrailerUpdateSubmit.UseVisualStyleBackColor = true;
            BtnTrailerUpdateSubmit.Click +=  BtnTrailerUpdateSubmit_Click ;
            // 
            // BtnUpdateTrailerCancel
            // 
            BtnUpdateTrailerCancel.Location = new Point( 78 , 303 );
            BtnUpdateTrailerCancel.Name = "BtnUpdateTrailerCancel";
            BtnUpdateTrailerCancel.Size = new Size( 94 , 29 );
            BtnUpdateTrailerCancel.TabIndex = 13;
            BtnUpdateTrailerCancel.Text = "Cancel";
            BtnUpdateTrailerCancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerArrival
            // 
            dateTimePickerArrival.Location = new Point( 180 , 114 );
            dateTimePickerArrival.Name = "dateTimePickerArrival";
            dateTimePickerArrival.Size = new Size( 250 , 27 );
            dateTimePickerArrival.TabIndex = 14;
            // 
            // dateTimePickerCompletion
            // 
            dateTimePickerCompletion.Location = new Point( 180 , 147 );
            dateTimePickerCompletion.Name = "dateTimePickerCompletion";
            dateTimePickerCompletion.Size = new Size( 250 , 27 );
            dateTimePickerCompletion.TabIndex = 15;
            // 
            // chkBoxSetCompletionDate
            // 
            chkBoxSetCompletionDate.AutoSize = true;
            chkBoxSetCompletionDate.Location = new Point( 180 , 180 );
            chkBoxSetCompletionDate.Name = "chkBoxSetCompletionDate";
            chkBoxSetCompletionDate.Size = new Size( 170 , 24 );
            chkBoxSetCompletionDate.TabIndex = 16;
            chkBoxSetCompletionDate.Text = "Set Completion Date";
            chkBoxSetCompletionDate.UseVisualStyleBackColor = true;
            // 
            // UpdateTrailerForm
            // 
            AutoScaleDimensions = new SizeF( 8F , 20F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 572 , 491 );
            Controls.Add( chkBoxSetCompletionDate );
            Controls.Add( dateTimePickerCompletion );
            Controls.Add( dateTimePickerArrival );
            Controls.Add( BtnUpdateTrailerCancel );
            Controls.Add( BtnTrailerUpdateSubmit );
            Controls.Add( label6 );
            Controls.Add( label5 );
            Controls.Add( label4 );
            Controls.Add( label3 );
            Controls.Add( label2 );
            Controls.Add( label1 );
            Controls.Add( txtDockNum );
            Controls.Add( txtFrom );
            Controls.Add( txtTotalWeight );
            Controls.Add( txtTrailerId );
            Name = "UpdateTrailerForm";
            Text = "UpdateTrailerForm";
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private TextBox txtTrailerId;
        private TextBox txtTotalWeight;
        private TextBox txtFrom;
        private TextBox txtDockNum;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button BtnTrailerUpdateSubmit;
        private Button BtnUpdateTrailerCancel;
        private DateTimePicker dateTimePickerArrival;
        private DateTimePicker dateTimePickerCompletion;
        private CheckBox chkBoxSetCompletionDate;
    }
}