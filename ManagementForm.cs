namespace Mini_LMS_App
{
    public partial class ManagementForm : Form
    {
        private StudentViewModel studentViewModel = new();
        private string filePath = "highestgpa.json";
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            ValidateUserLogon();
            studentViewModel.CreateData();
            studentViewModel.Students.Sort();
            studentBindingSource.DataSource = studentViewModel.Students;
        }

        private void ValidateUserLogon()
        {
            LogonForm logonForm = new LogonForm();
            if (logonForm.ShowDialog(this) != DialogResult.OK)
            {
                Close();
            }
        }

        private void deleteHighestGPAButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            int count = studentViewModel.Students.Count;
            if (count > 0)
            {
                studentViewModel.Students.RemoveAt(count - 1);
            }
            else
            {
                // List is empty
                MessageBox.Show("No students exist!");
            }
            studentBindingSource.ResetBindings(true);
        }

        private void saveHighestGPAButton_Click(object sender, EventArgs e)
        {
            int count = studentViewModel.Students.Count;
            if (count > 0)
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine(studentViewModel.Students[count - 1]);
                }
                MessageBox.Show($"Saved {studentViewModel.Students[count - 1].FullName}'s information to {filePath}");
            }
            else
            {
                // List is empty
                MessageBox.Show("No students exist!");
            }
        }
    }
}
