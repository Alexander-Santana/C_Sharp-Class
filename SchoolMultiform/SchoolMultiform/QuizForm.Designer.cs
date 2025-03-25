//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Lab Assignment # 2

namespace SchoolMultiform
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            studentPicture = new PictureBox();
            quizNumberLabel = new Label();
            largeLabel = new Label();
            submitButton = new Button();
            clearButton = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)studentPicture).BeginInit();
            SuspendLayout();
            // 
            // studentPicture
            // 
            studentPicture.Image = (Image)resources.GetObject("studentPicture.Image");
            studentPicture.Location = new Point(198, 23);
            studentPicture.Name = "studentPicture";
            studentPicture.Size = new Size(240, 128);
            studentPicture.SizeMode = PictureBoxSizeMode.Zoom;
            studentPicture.TabIndex = 0;
            studentPicture.TabStop = false;
            // 
            // quizNumberLabel
            // 
            quizNumberLabel.AutoSize = true;
            quizNumberLabel.BorderStyle = BorderStyle.FixedSingle;
            quizNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quizNumberLabel.Location = new Point(61, 77);
            quizNumberLabel.Name = "quizNumberLabel";
            quizNumberLabel.Size = new Size(75, 30);
            quizNumberLabel.TabIndex = 1;
            quizNumberLabel.Text = "Quiz #";
            // 
            // largeLabel
            // 
            largeLabel.AutoSize = true;
            largeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            largeLabel.ForeColor = Color.Brown;
            largeLabel.Location = new Point(61, 238);
            largeLabel.Name = "largeLabel";
            largeLabel.Size = new Size(535, 41);
            largeLabel.TabIndex = 2;
            largeLabel.Text = "Quizzes are not available at this time";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.PaleGreen;
            submitButton.Font = new Font("Segoe UI", 10.8F);
            submitButton.Location = new Point(187, 349);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 43);
            submitButton.TabIndex = 3;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Azure;
            clearButton.Font = new Font("Segoe UI", 10.8F);
            clearButton.Location = new Point(344, 349);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 43);
            clearButton.TabIndex = 4;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.Font = new Font("Segoe UI", 10.8F);
            button3.Location = new Point(273, 425);
            button3.Name = "button3";
            button3.Size = new Size(94, 43);
            button3.TabIndex = 5;
            button3.Text = "Exit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(658, 490);
            Controls.Add(button3);
            Controls.Add(clearButton);
            Controls.Add(submitButton);
            Controls.Add(largeLabel);
            Controls.Add(quizNumberLabel);
            Controls.Add(studentPicture);
            Name = "QuizForm";
            Text = "Quiz";
            ((System.ComponentModel.ISupportInitialize)studentPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox studentPicture;
        private Label quizNumberLabel;
        private Label largeLabel;
        private Button submitButton;
        private Button clearButton;
        private Button button3;
    }
}
