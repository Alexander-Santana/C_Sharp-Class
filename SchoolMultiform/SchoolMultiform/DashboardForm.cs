//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Lab Assignment # 2

namespace SchoolMultiform
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Program is Opening a Form to Enter Student Data.");
        }

        private void gradesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Program is Opening a Form to Enter Student Grades.");
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Program is Opening a Form to Enter Student Grades");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
