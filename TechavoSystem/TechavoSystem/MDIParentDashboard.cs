namespace TechavoSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.menu.NodeMouseClick += menu_Click;
        }

        private void L_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if(LoginDetails.IsLoggedIn)
            {
                lnkLogin.Text = "Logout";
                pnlDashboard.Visible = true;
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LoginDetails.IsLoggedIn)
            {
                LoginDetails.IsLoggedIn= false;
                lnkLogin.Text = "Login";
                pnlDashboard.Visible= false;
            }
            else
            {
                Login();
            }
        }

        private void Login()
        {
            Login l = new Login();
            l.FormClosed += L_FormClosed;
            l.Show();
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            Login();
            LoginTimer.Enabled = false;
        }

        private void HideAllPanel()
        {
            pnlGeneralSettings.Visible = false;
            pnlModbusSettings.Visible = false;
            pnlAISettings.Visible = false;
        }

        private void menu_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Name == null)
            {
                return;
            }
            HideAllPanel();
            if (e.Node.Name == "GeneralSettings")
            {
                pnlGeneralSettings.Visible = true;
            }
            else if (e.Node.Name == "AISettings")
            {
                pnlAISettings.Visible = true;
            }
            else if (e.Node.Name == "ModbusSettings")
            {
                pnlModbusSettings.Visible = true;
            }
            else if (e.Node.Name == "GPRSSettings")
            {
                pnlAISettings.Visible = true;
            }
        }

        private void menuhover_Click(object sender, TreeNodeMouseHoverEventArgs e)
        {

        }

        private void chkTotalizer_CheckedChanged(object sender, EventArgs e)
        {
            TotalizerEnableDisable(chkTotalizer.Checked);
        }
        private void TotalizerEnableDisable(bool isChecked)
        {
            txtKFactor.Enabled = isChecked;
            txtTimebase.Enabled = isChecked;
            chkVolatileFlag.Enabled = isChecked;
            txtDisplayDecimalPoint.Enabled = isChecked;
            chkDataReport.Enabled = isChecked;
            cmbReportDataType.Enabled = isChecked;
            txtTotalizerUnit.Enabled = isChecked;
        }
    }
}
