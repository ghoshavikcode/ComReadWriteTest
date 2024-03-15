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
            LoginDetails.IsLoggedIn = true;
            this.Close();
        }
    }
}