//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Lab Assignment # 2

namespace SchoolMultiform
{
    public partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            studentPicture = new PictureBox();
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            addressLabel = new Label();
            phoneLabel = new Label();
            emailLabel = new Label();
            firstTextbox = new TextBox();
            lastTextbox = new TextBox();
            addressTextbox = new TextBox();
            phoneTextbox = new TextBox();
            emailTextbox = new TextBox();
            addButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            addingLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)studentPicture).BeginInit();
            SuspendLayout();
            // 
            // studentPicture
            // 
            studentPicture.Image = (Image)resources.GetObject("studentPicture.Image");
            studentPicture.Location = new Point(198, 25);
            studentPicture.Name = "studentPicture";
            studentPicture.Size = new Size(247, 145);
            studentPicture.SizeMode = PictureBoxSizeMode.Zoom;
            studentPicture.TabIndex = 0;
            studentPicture.TabStop = false;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = SystemColors.AppWorkspace;
            firstNameLabel.BorderStyle = BorderStyle.FixedSingle;
            firstNameLabel.Location = new Point(33, 221);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(82, 22);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.BackColor = SystemColors.AppWorkspace;
            lastNameLabel.BorderStyle = BorderStyle.FixedSingle;
            lastNameLabel.Location = new Point(34, 263);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(81, 22);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.BackColor = SystemColors.AppWorkspace;
            addressLabel.BorderStyle = BorderStyle.FixedSingle;
            addressLabel.Location = new Point(51, 305);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(64, 22);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = SystemColors.AppWorkspace;
            phoneLabel.BorderStyle = BorderStyle.FixedSingle;
            phoneLabel.Location = new Point(63, 347);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(52, 22);
            phoneLabel.TabIndex = 4;
            phoneLabel.Text = "Phone";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = SystemColors.AppWorkspace;
            emailLabel.BorderStyle = BorderStyle.FixedSingle;
            emailLabel.Location = new Point(61, 389);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(54, 22);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "E-mail";
            // 
            // firstTextbox
            // 
            firstTextbox.Location = new Point(135, 221);
            firstTextbox.Name = "firstTextbox";
            firstTextbox.Size = new Size(231, 27);
            firstTextbox.TabIndex = 6;
            // 
            // lastTextbox
            // 
            lastTextbox.Location = new Point(135, 263);
            lastTextbox.Name = "lastTextbox";
            lastTextbox.Size = new Size(231, 27);
            lastTextbox.TabIndex = 7;
            // 
            // addressTextbox
            // 
            addressTextbox.Location = new Point(135, 305);
            addressTextbox.Name = "addressTextbox";
            addressTextbox.Size = new Size(231, 27);
            addressTextbox.TabIndex = 8;
            // 
            // phoneTextbox
            // 
            phoneTextbox.Location = new Point(135, 347);
            phoneTextbox.Name = "phoneTextbox";
            phoneTextbox.Size = new Size(231, 27);
            phoneTextbox.TabIndex = 9;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(135, 389);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(231, 27);
            emailTextbox.TabIndex = 10;
            // 
            // addButton
            // 
            addButton.BackColor = Color.PaleGreen;
            addButton.Font = new Font("Segoe UI", 12F);
            addButton.Location = new Point(396, 221);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 69);
            addButton.TabIndex = 11;
            addButton.Text = "Add Student";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Azure;
            clearButton.Font = new Font("Segoe UI", 12F);
            clearButton.Location = new Point(527, 221);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 64);
            clearButton.TabIndex = 12;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(274, 452);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 55);
            exitButton.TabIndex = 13;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // addingLabel
            // 
            addingLabel.AutoSize = true;
            addingLabel.BackColor = SystemColors.AppWorkspace;
            addingLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addingLabel.ForeColor = SystemColors.ActiveCaptionText;
            addingLabel.Location = new Point(396, 380);
            addingLabel.Name = "addingLabel";
            addingLabel.Size = new Size(234, 31);
            addingLabel.TabIndex = 14;
            addingLabel.Text = "Adding data to a file";
            addingLabel.Visible = false;
            // 
            // StudentForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(642, 532);
            Controls.Add(addingLabel);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(addButton);
            Controls.Add(emailTextbox);
            Controls.Add(phoneTextbox);
            Controls.Add(addressTextbox);
            Controls.Add(lastTextbox);
            Controls.Add(firstTextbox);
            Controls.Add(emailLabel);
            Controls.Add(phoneLabel);
            Controls.Add(addressLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(studentPicture);
            Name = "StudentForm";
            Text = "Student";
            ((System.ComponentModel.ISupportInitialize)studentPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox studentPicture;
        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label addressLabel;
        private Label phoneLabel;
        private Label emailLabel;
        private TextBox firstTextbox;
        private TextBox lastTextbox;
        private TextBox addressTextbox;
        private TextBox phoneTextbox;
        private TextBox emailTextbox;
        private Button addButton;
        private Button clearButton;
        private Button exitButton;
        private Label addingLabel;
    }
}
