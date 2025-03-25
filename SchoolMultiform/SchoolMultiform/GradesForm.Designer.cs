//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Lab Assignment # 2

namespace SchoolMultiform
{
    public partial class GradesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradesForm));
            gradesPicture = new PictureBox();
            labLabel = new Label();
            projectLabel = new Label();
            testLabel = new Label();
            finalLabel = new Label();
            courseGradeLabel = new Label();
            courseLetterGradeLabel = new Label();
            labTextbox = new TextBox();
            projectTextbox = new TextBox();
            testTextbox = new TextBox();
            finalTextbox = new TextBox();
            courseGradeTextbox = new TextBox();
            courseLetterTextbox = new TextBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)gradesPicture).BeginInit();
            SuspendLayout();
            // 
            // gradesPicture
            // 
            gradesPicture.Image = (Image)resources.GetObject("gradesPicture.Image");
            gradesPicture.Location = new Point(189, 12);
            gradesPicture.Name = "gradesPicture";
            gradesPicture.Size = new Size(254, 127);
            gradesPicture.SizeMode = PictureBoxSizeMode.Zoom;
            gradesPicture.TabIndex = 0;
            gradesPicture.TabStop = false;
            // 
            // labLabel
            // 
            labLabel.AutoSize = true;
            labLabel.BackColor = SystemColors.AppWorkspace;
            labLabel.BorderStyle = BorderStyle.FixedSingle;
            labLabel.Font = new Font("Segoe UI", 10.2F);
            labLabel.Location = new Point(207, 160);
            labLabel.Name = "labLabel";
            labLabel.Size = new Size(39, 25);
            labLabel.TabIndex = 1;
            labLabel.Text = "Lab";
            // 
            // projectLabel
            // 
            projectLabel.AutoSize = true;
            projectLabel.BackColor = SystemColors.AppWorkspace;
            projectLabel.BorderStyle = BorderStyle.FixedSingle;
            projectLabel.Font = new Font("Segoe UI", 10.2F);
            projectLabel.Location = new Point(181, 196);
            projectLabel.Name = "projectLabel";
            projectLabel.Size = new Size(65, 25);
            projectLabel.TabIndex = 2;
            projectLabel.Text = "Project";
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.BackColor = SystemColors.AppWorkspace;
            testLabel.BorderStyle = BorderStyle.FixedSingle;
            testLabel.Font = new Font("Segoe UI", 10.2F);
            testLabel.Location = new Point(205, 237);
            testLabel.Name = "testLabel";
            testLabel.Size = new Size(41, 25);
            testLabel.TabIndex = 3;
            testLabel.Text = "Test";
            // 
            // finalLabel
            // 
            finalLabel.AutoSize = true;
            finalLabel.BackColor = SystemColors.AppWorkspace;
            finalLabel.BorderStyle = BorderStyle.FixedSingle;
            finalLabel.Font = new Font("Segoe UI", 10.2F);
            finalLabel.Location = new Point(153, 274);
            finalLabel.Name = "finalLabel";
            finalLabel.Size = new Size(93, 25);
            finalLabel.TabIndex = 4;
            finalLabel.Text = "Final Exam";
            // 
            // courseGradeLabel
            // 
            courseGradeLabel.AutoSize = true;
            courseGradeLabel.BackColor = SystemColors.AppWorkspace;
            courseGradeLabel.BorderStyle = BorderStyle.FixedSingle;
            courseGradeLabel.Font = new Font("Segoe UI", 10.2F);
            courseGradeLabel.Location = new Point(130, 312);
            courseGradeLabel.Name = "courseGradeLabel";
            courseGradeLabel.Size = new Size(116, 25);
            courseGradeLabel.TabIndex = 5;
            courseGradeLabel.Text = "Course Grade";
            courseGradeLabel.Visible = false;
            // 
            // courseLetterGradeLabel
            // 
            courseLetterGradeLabel.AccessibleDescription = "";
            courseLetterGradeLabel.AutoSize = true;
            courseLetterGradeLabel.BackColor = SystemColors.AppWorkspace;
            courseLetterGradeLabel.BorderStyle = BorderStyle.FixedSingle;
            courseLetterGradeLabel.Font = new Font("Segoe UI", 10.2F);
            courseLetterGradeLabel.Location = new Point(81, 351);
            courseLetterGradeLabel.Name = "courseLetterGradeLabel";
            courseLetterGradeLabel.Size = new Size(165, 25);
            courseLetterGradeLabel.TabIndex = 6;
            courseLetterGradeLabel.Text = "Course Letter Grade";
            courseLetterGradeLabel.Visible = false;
            // 
            // labTextbox
            // 
            labTextbox.Location = new Point(269, 160);
            labTextbox.Name = "labTextbox";
            labTextbox.Size = new Size(66, 27);
            labTextbox.TabIndex = 7;
            // 
            // projectTextbox
            // 
            projectTextbox.Location = new Point(269, 198);
            projectTextbox.Name = "projectTextbox";
            projectTextbox.Size = new Size(66, 27);
            projectTextbox.TabIndex = 8;
            // 
            // testTextbox
            // 
            testTextbox.Location = new Point(269, 236);
            testTextbox.Name = "testTextbox";
            testTextbox.Size = new Size(66, 27);
            testTextbox.TabIndex = 9;
            // 
            // finalTextbox
            // 
            finalTextbox.Location = new Point(269, 274);
            finalTextbox.Name = "finalTextbox";
            finalTextbox.Size = new Size(66, 27);
            finalTextbox.TabIndex = 10;
            // 
            // courseGradeTextbox
            // 
            courseGradeTextbox.Location = new Point(269, 312);
            courseGradeTextbox.Name = "courseGradeTextbox";
            courseGradeTextbox.Size = new Size(50, 27);
            courseGradeTextbox.TabIndex = 11;
            courseGradeTextbox.Visible = false;
            // 
            // courseLetterTextbox
            // 
            courseLetterTextbox.Location = new Point(269, 350);
            courseLetterTextbox.Name = "courseLetterTextbox";
            courseLetterTextbox.Size = new Size(50, 27);
            courseLetterTextbox.TabIndex = 12;
            courseLetterTextbox.Visible = false;
            // 
            // calculateButton
            // 
            calculateButton.BackColor = Color.PaleGreen;
            calculateButton.Font = new Font("Segoe UI", 10.2F);
            calculateButton.Location = new Point(442, 160);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(109, 73);
            calculateButton.TabIndex = 13;
            calculateButton.Text = "Calculate Grades";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Azure;
            clearButton.Font = new Font("Segoe UI", 10.2F);
            clearButton.Location = new Point(442, 250);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(109, 73);
            clearButton.TabIndex = 14;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.Font = new Font("Segoe UI", 10.2F);
            exitButton.Location = new Point(442, 385);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(109, 47);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // GradesForm1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(632, 453);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(courseLetterTextbox);
            Controls.Add(courseGradeTextbox);
            Controls.Add(finalTextbox);
            Controls.Add(testTextbox);
            Controls.Add(projectTextbox);
            Controls.Add(labTextbox);
            Controls.Add(courseLetterGradeLabel);
            Controls.Add(courseGradeLabel);
            Controls.Add(finalLabel);
            Controls.Add(testLabel);
            Controls.Add(projectLabel);
            Controls.Add(labLabel);
            Controls.Add(gradesPicture);
            Name = "GradesForm1";
            Text = "Grades";
            ((System.ComponentModel.ISupportInitialize)gradesPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox gradesPicture;
        private Label labLabel;
        private Label projectLabel;
        private Label testLabel;
        private Label finalLabel;
        private Label courseGradeLabel;
        private Label courseLetterGradeLabel;
        private TextBox labTextbox;
        private TextBox projectTextbox;
        private TextBox testTextbox;
        private TextBox finalTextbox;
        private TextBox courseGradeTextbox;
        private TextBox courseLetterTextbox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
