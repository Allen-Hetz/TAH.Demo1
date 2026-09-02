namespace TAH.Demo1.UI
{
    public partial class frmDemo1 : Form
    {
        public frmDemo1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // This will set the text of lblName to "Allen"
            lblName.Text = "Allen";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // This will exit the app
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // This will clear the text of lblName
            lblName.Text = "";
        }
    }
}
