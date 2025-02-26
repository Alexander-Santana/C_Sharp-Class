namespace StudentDataEncryption
{
    partial class Form1
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
            labelFirstName = new Label();
            labelLastName = new Label();
            labelAddress = new Label();
            labelEmail = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            btnSubmit = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lblDate = new Label();
            lblLblDate = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(28, 159);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(80, 20);
            labelFirstName.TabIndex = 0;
            labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(28, 212);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(79, 20);
            labelLastName.TabIndex = 1;
            labelLastName.Text = "Last Name";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(28, 265);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(62, 20);
            labelAddress.TabIndex = 2;
            labelAddress.Text = "Address";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(28, 318);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "Email";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(148, 156);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(197, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(148, 205);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(197, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(148, 265);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(197, 27);
            txtAddress.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(148, 311);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(197, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(38, 390);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(165, 390);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(285, 390);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblDate
            // 
            lblDate.BorderStyle = BorderStyle.FixedSingle;
            lblDate.Location = new Point(252, 94);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(127, 25);
            lblDate.TabIndex = 11;
            // 
            // lblLblDate
            // 
            lblLblDate.AutoSize = true;
            lblLblDate.Location = new Point(252, 64);
            lblLblDate.Name = "lblLblDate";
            lblLblDate.Size = new Size(41, 20);
            lblLblDate.TabIndex = 12;
            lblLblDate.Text = "Date";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(28, 48);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 20);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Enter the student data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 450);
            Controls.Add(lblTitle);
            Controls.Add(lblLblDate);
            Controls.Add(lblDate);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtEmail);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(labelEmail);
            Controls.Add(labelAddress);
            Controls.Add(labelLastName);
            Controls.Add(labelFirstName);
            Name = "Form1";
            Text = "Student Data Entry";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFirstName;
        private Label labelLastName;
        private Label labelAddress;
        private Label labelEmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Button btnSubmit;
        private Button btnClear;
        private Button btnExit;
        private Label lblDate;
        private Label lblLblDate;
        private Label lblTitle;
    }
}
