//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Lab Assignment # 2

namespace SchoolMultiform
{
    public partial class GradesForm : Form
    {
        public GradesForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            courseGradeLabel.Visible = true;
            courseGradeTextbox.Visible = true;
            courseLetterGradeLabel.Visible = true;
            courseLetterTextbox.Visible = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            labTextbox.Text = "";
            projectTextbox.Text = "";
            testTextbox.Text = "";
            finalTextbox.Text = "";
            courseGradeLabel.Visible = false;
            courseGradeTextbox.Visible = false;
            courseLetterGradeLabel.Visible = false;
            courseLetterTextbox.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
