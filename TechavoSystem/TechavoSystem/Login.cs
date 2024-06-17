namespace TechavoSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text == "212121")
            {
                LoginDetails.IsLoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Password");
                txtLoginPassword.Text = string.Empty;
            }
        }
    }
}