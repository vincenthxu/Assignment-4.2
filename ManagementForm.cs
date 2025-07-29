namespace Mini_LMS_App
{
    public partial class ManagementForm : Form
    {
        private StudentViewModel studentViewModel;
        private string filePath = "highestgpa.txt";
        public ManagementForm()
        {
            InitializeComponent();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            ValidateUserLogon();
            studentViewModel = new();
            studentViewModel.CreateData();
            studentViewModel.Students.Sort();
            studentBindingSource.DataSource = studentViewModel.Students;
        }

        private void ValidateUserLogon()
        {
            LogonForm logonForm = new LogonForm();
            if (logonForm.ShowDialog(this) != DialogResult.Yes)
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
            studentBindingSource.ResetBindings(true);
        }

        private void saveHighestGPAButton_Click(object sender, EventArgs e)
        {
            int count = studentViewModel.Students.Count;
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(studentViewModel.Students[count - 1]);
            }
            MessageBox.Show($"Saved {studentViewModel.Students[count - 1].FullName}'s information to {filePath}");
        }
    }
}
