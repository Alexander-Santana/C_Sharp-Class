//Name: Alexander Santana
//Date: 3/25/2025
//Assignment: Advanced C# Programming: Chapter-10...Lab Assignment # 2

namespace SchoolMultiform
{
    public partial class DashboardForm1 : Form
    {
        public DashboardForm1()
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

        private void InitializeComponent()
        {
            btnOpenStudent = new Button();
            btnOpenQuiz = new Button();
            btnOpenGrades = new Button();
            btnExit = new Button();
            btnOpenDashboard = new Button();
            SuspendLayout();
            // 
            // btnOpenStudent
            // 
            btnOpenStudent.BackColor = Color.WhiteSmoke;
            btnOpenStudent.Location = new Point(55, 113);
            btnOpenStudent.Name = "btnOpenStudent";
            btnOpenStudent.Size = new Size(209, 29);
            btnOpenStudent.TabIndex = 0;
            btnOpenStudent.Text = "Student";
            btnOpenStudent.UseVisualStyleBackColor = false;
            btnOpenStudent.Click += btnOpenStudent_Click;
            // 
            // btnOpenQuiz
            // 
            btnOpenQuiz.BackColor = Color.Yellow;
            btnOpenQuiz.Location = new Point(25, 173);
            btnOpenQuiz.Name = "btnOpenQuiz";
            btnOpenQuiz.Size = new Size(128, 29);
            btnOpenQuiz.TabIndex = 1;
            btnOpenQuiz.Text = "Quiz";
            btnOpenQuiz.UseVisualStyleBackColor = false;
            btnOpenQuiz.Click += btnOpenQuiz_Click;
            // 
            // btnOpenGrades
            // 
            btnOpenGrades.BackColor = SystemColors.GradientActiveCaption;
            btnOpenGrades.Location = new Point(159, 173);
            btnOpenGrades.Name = "btnOpenGrades";
            btnOpenGrades.Size = new Size(121, 29);
            btnOpenGrades.TabIndex = 2;
            btnOpenGrades.Text = "Grades";
            btnOpenGrades.UseVisualStyleBackColor = false;
            btnOpenGrades.Click += btnOpenGrades_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.IndianRed;
            btnExit.Location = new Point(114, 225);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 46);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnOpenDashboard
            // 
            btnOpenDashboard.BackColor = Color.CornflowerBlue;
            btnOpenDashboard.Location = new Point(55, 12);
            btnOpenDashboard.Name = "btnOpenDashboard";
            btnOpenDashboard.Size = new Size(209, 83);
            btnOpenDashboard.TabIndex = 4;
            btnOpenDashboard.Text = "Dashboard";
            btnOpenDashboard.UseVisualStyleBackColor = false;
            btnOpenDashboard.Click += btnOpenDashboard_Click;
            // 
            // DashboardForm1
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(316, 300);
            Controls.Add(btnOpenDashboard);
            Controls.Add(btnExit);
            Controls.Add(btnOpenGrades);
            Controls.Add(btnOpenQuiz);
            Controls.Add(btnOpenStudent);
            Name = "DashboardForm1";
            ResumeLayout(false);
        }

        private void btnOpenStudent_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.ShowDialog();
        }

        private Button btnOpenStudent;
        private Button btnOpenQuiz;
        private Button btnExit;
        private Button btnOpenGrades;

        private void btnOpenQuiz_Click(object sender, EventArgs e)
        {
            QuizForm quizForm = new QuizForm();
            quizForm.ShowDialog();
        }

        private void btnOpenGrades_Click(object sender, EventArgs e)
        {
            GradesForm gradesForm = new GradesForm();
            gradesForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenDashboard_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.ShowDialog();
        }
    }
}
