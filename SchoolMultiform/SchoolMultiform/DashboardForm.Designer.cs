//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Lab Assignment # 2

namespace SchoolMultiform
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            schoolPicture = new PictureBox();
            infoLabel = new Label();
            infoButton = new Button();
            gradesLabel = new Label();
            gradesButton = new Button();
            quizButton = new Button();
            quizLabel = new Label();
            exitLabel = new Label();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)schoolPicture).BeginInit();
            SuspendLayout();
            // 
            // schoolPicture
            // 
            schoolPicture.Image = (Image)resources.GetObject("schoolPicture.Image");
            schoolPicture.Location = new Point(147, 12);
            schoolPicture.Name = "schoolPicture";
            schoolPicture.Size = new Size(195, 115);
            schoolPicture.SizeMode = PictureBoxSizeMode.Zoom;
            schoolPicture.TabIndex = 0;
            schoolPicture.TabStop = false;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.BackColor = SystemColors.AppWorkspace;
            infoLabel.BorderStyle = BorderStyle.FixedSingle;
            infoLabel.Location = new Point(111, 182);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(144, 22);
            infoLabel.TabIndex = 1;
            infoLabel.Text = "Student Information";
            // 
            // infoButton
            // 
            infoButton.BackColor = Color.Gold;
            infoButton.Location = new Point(297, 154);
            infoButton.Name = "infoButton";
            infoButton.Size = new Size(113, 76);
            infoButton.TabIndex = 2;
            infoButton.Text = "Add Student Information";
            infoButton.UseVisualStyleBackColor = false;
            infoButton.Click += infoButton_Click;
            // 
            // gradesLabel
            // 
            gradesLabel.AutoSize = true;
            gradesLabel.BackColor = SystemColors.AppWorkspace;
            gradesLabel.BorderStyle = BorderStyle.FixedSingle;
            gradesLabel.Location = new Point(143, 276);
            gradesLabel.Name = "gradesLabel";
            gradesLabel.Size = new Size(112, 22);
            gradesLabel.TabIndex = 3;
            gradesLabel.Text = "Student Grades";
            // 
            // gradesButton
            // 
            gradesButton.BackColor = Color.RosyBrown;
            gradesButton.Location = new Point(297, 248);
            gradesButton.Name = "gradesButton";
            gradesButton.Size = new Size(113, 76);
            gradesButton.TabIndex = 4;
            gradesButton.Text = "Add Student Grades";
            gradesButton.UseVisualStyleBackColor = false;
            gradesButton.Click += gradesButton_Click;
            // 
            // quizButton
            // 
            quizButton.BackColor = Color.PaleTurquoise;
            quizButton.Location = new Point(297, 340);
            quizButton.Name = "quizButton";
            quizButton.Size = new Size(113, 76);
            quizButton.TabIndex = 5;
            quizButton.Text = "Complete a Quiz";
            quizButton.UseVisualStyleBackColor = false;
            quizButton.Click += quizButton_Click;
            // 
            // quizLabel
            // 
            quizLabel.AutoSize = true;
            quizLabel.BackColor = SystemColors.AppWorkspace;
            quizLabel.BorderStyle = BorderStyle.FixedSingle;
            quizLabel.Location = new Point(214, 368);
            quizLabel.Name = "quizLabel";
            quizLabel.Size = new Size(41, 22);
            quizLabel.TabIndex = 6;
            quizLabel.Text = "Quiz";
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.BackColor = SystemColors.AppWorkspace;
            exitLabel.BorderStyle = BorderStyle.FixedSingle;
            exitLabel.Location = new Point(220, 466);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(35, 22);
            exitLabel.TabIndex = 7;
            exitLabel.Text = "Exit";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.Location = new Point(297, 438);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(113, 76);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit The Program";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(521, 526);
            Controls.Add(exitButton);
            Controls.Add(exitLabel);
            Controls.Add(quizLabel);
            Controls.Add(quizButton);
            Controls.Add(gradesButton);
            Controls.Add(gradesLabel);
            Controls.Add(infoButton);
            Controls.Add(infoLabel);
            Controls.Add(schoolPicture);
            Name = "Form1";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)schoolPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox schoolPicture;
        private Label infoLabel;
        private Button infoButton;
        private Label gradesLabel;
        private Button gradesButton;
        private Button quizButton;
        private Label quizLabel;
        private Label exitLabel;
        private Button exitButton;
    }
}
