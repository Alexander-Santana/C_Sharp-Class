//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Importing an Existing Formusing System;


using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C10Example_MultiformImport
{

    public partial class ColorForm : Form
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
            promptLabel = new Label();
            redLabel = new Label();
            orangeLabel = new Label();
            yellowLabel = new Label();
            indigoLabel = new Label();
            blueLabel = new Label();
            greenLabel = new Label();
            violetLabel = new Label();
            colorLabel = new Label();
            SuspendLayout();
            // 
            // promptLabel
            // 
            promptLabel.AutoSize = true;
            promptLabel.Location = new Point(197, 12);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(211, 20);
            promptLabel.TabIndex = 0;
            promptLabel.Text = "Select a Color of the Spectrum";
            // 
            // redLabel
            // 
            redLabel.BackColor = Color.Red;
            redLabel.Location = new Point(19, 52);
            redLabel.Name = "redLabel";
            redLabel.Size = new Size(72, 31);
            redLabel.TabIndex = 1;
            redLabel.Click += redLabel_Click_1;
            // 
            // orangeLabel
            // 
            orangeLabel.BackColor = Color.FromArgb(255, 128, 0);
            orangeLabel.Location = new Point(98, 52);
            orangeLabel.Name = "orangeLabel";
            orangeLabel.Size = new Size(72, 31);
            orangeLabel.TabIndex = 2;
            orangeLabel.Click += orangeLabel_Click_1;
            // 
            // yellowLabel
            // 
            yellowLabel.BackColor = Color.Yellow;
            yellowLabel.Location = new Point(177, 52);
            yellowLabel.Name = "yellowLabel";
            yellowLabel.Size = new Size(72, 31);
            yellowLabel.TabIndex = 3;
            yellowLabel.Click += yellowLabel_Click_1;
            // 
            // indigoLabel
            // 
            indigoLabel.BackColor = Color.Purple;
            indigoLabel.Location = new Point(414, 52);
            indigoLabel.Name = "indigoLabel";
            indigoLabel.Size = new Size(72, 31);
            indigoLabel.TabIndex = 6;
            indigoLabel.Click += indigoLabel_Click_1;
            // 
            // blueLabel
            // 
            blueLabel.BackColor = Color.Blue;
            blueLabel.Location = new Point(335, 52);
            blueLabel.Name = "blueLabel";
            blueLabel.Size = new Size(72, 31);
            blueLabel.TabIndex = 5;
            blueLabel.Click += blueLabel_Click_1;
            // 
            // greenLabel
            // 
            greenLabel.BackColor = Color.FromArgb(0, 192, 0);
            greenLabel.Location = new Point(256, 52);
            greenLabel.Name = "greenLabel";
            greenLabel.Size = new Size(72, 31);
            greenLabel.TabIndex = 4;
            greenLabel.Click += greenLabel_Click_1;
            // 
            // violetLabel
            // 
            violetLabel.BackColor = Color.Fuchsia;
            violetLabel.Location = new Point(493, 52);
            violetLabel.Name = "violetLabel";
            violetLabel.Size = new Size(72, 31);
            violetLabel.TabIndex = 7;
            violetLabel.Click += violetLabel_Click_1;
            // 
            // colorLabel
            // 
            colorLabel.BorderStyle = BorderStyle.FixedSingle;
            colorLabel.Location = new Point(234, 108);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(114, 30);
            colorLabel.TabIndex = 8;
            colorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 159);
            Controls.Add(colorLabel);
            Controls.Add(violetLabel);
            Controls.Add(indigoLabel);
            Controls.Add(blueLabel);
            Controls.Add(greenLabel);
            Controls.Add(yellowLabel);
            Controls.Add(orangeLabel);
            Controls.Add(redLabel);
            Controls.Add(promptLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ColorForm";
            Text = "Color Spectrum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label promptLabel;
        private Label redLabel;
        private Label orangeLabel;
        private Label yellowLabel;
        private Label indigoLabel;
        private Label blueLabel;
        private Label greenLabel;
        private Label violetLabel;
        private Label colorLabel;
    }
}