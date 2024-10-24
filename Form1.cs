namespace Tic_Tac_Toe___Ivan_Suralta
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            this.Close();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.ShowDialog();
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            SetupForm setupForm = new SetupForm();
            setupForm.ShowDialog();
            this.Close();
        }
    }
}