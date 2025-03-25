//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Importing an Existing Formusing System;


using System.Windows.Forms;

using System;
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
    enum Spectrum
    {
        Red, Orange, Yellow, Green,Blue, Indigo, Violet
    }

    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        // The DisplayColor method displays the
        // name of a color.
        private void DisplayColor(Spectrum color)
        {
            colorLabel.Text = color.ToString();
        }

        private void redLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        private void orangeLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        private void yellowLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        private void greenLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        private void blueLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        private void indigoLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Indigo);
        }

        private void violetLabel_Click_1(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Violet);
        }
    }
}
