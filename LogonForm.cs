using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_LMS_App
{
    public partial class LogonForm : Form
    {
        private TeacherViewModel teacherViewModel = new();
        public LogonForm()
        {
            InitializeComponent();
        }

        private void LogonForm_Load(object sender, EventArgs e)
        {
            teacherViewModel.CreateData();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            teacherViewModel.Teachers.TryGetValue(usernameInputBox.Text, out Teacher? teacher);
            if(teacher != null && teacher.ValidatePassword(passwordInputBox.Text))
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Login invalid!");
            }
        }

        private void LoginCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
