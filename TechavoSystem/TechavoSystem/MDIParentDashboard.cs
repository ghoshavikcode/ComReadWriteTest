using Microsoft.VisualBasic;
using System.IO.Ports;
using System.Text;

namespace TechavoSystem
{
    public partial class Dashboard : Form
    {
        private static int IsConnected = 0;
        static SerialPort port;
        private static bool IsReadyToSend = false;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.menu.NodeMouseClick += menu_Click;
            this.FormClosing += Dashboard_FormClosing;
            cmbComPorts.DataSource = SerialPort.GetPortNames();
        }

        private void Dashboard_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (port.IsOpen)
                port.Close();
        }

        private void L_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (LoginDetails.IsLoggedIn)
            {
                lnkLogin.Text = "Logout";
                pnlDashboard.Visible = true;
                pnlConnect.Visible = true;
            }
        }

        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (LoginDetails.IsLoggedIn)
            {
                LoginDetails.IsLoggedIn = false;
                lnkLogin.Text = "Login";
                pnlDashboard.Visible = false;
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

        private string CreateCommaSeparatedAI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*DESKAI, ,");
            sb.Append(cmbSelectChannel.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbAIType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbAIAlarm.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtMinValue.Text.Trim());
            sb.Append(",");
            sb.Append(txtMaxValue.Text.Trim());
            sb.Append(",");
            sb.Append(txtThresoldHigh.Text.Trim());
            sb.Append(",");
            sb.Append(txtThresoldLow.Text.Trim());
            sb.Append(",");
            sb.Append(txtAlarmConfirmationSec.Text.Trim());
            sb.Append(",");
            sb.Append(txtAlarmSmsInterval.Text.Trim());
            sb.Append(",");
            sb.Append(chkAIDataReport.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(cmbAIReportDataType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(chkTotalizer.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkVolatileFlag.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(txtKFactor.Text.Trim());
            sb.Append(",");
            sb.Append(txtTimebase.Text.Trim());
            sb.Append(",");
            sb.Append(txtDisplayDecimalPoint.Text.Trim());
            sb.Append(",");
            sb.Append(chkDataReport.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(cmbReportDataType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbDO1.SelectedIndex.ToString());
            sb.Append(cmbDO2.SelectedIndex.ToString());
            sb.Append(cmbDO3.SelectedIndex.ToString());
            sb.Append(cmbDO4.SelectedIndex.ToString());
            sb.Append(cmbDO5.SelectedIndex.ToString());
            sb.Append(cmbDO6.SelectedIndex.ToString());
            sb.Append(cmbDO7.SelectedIndex.ToString());
            sb.Append(cmbDO8.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(chkUser1.Checked ? 1 : 0);
            sb.Append(chkUser2.Checked ? 1 : 0);
            sb.Append(chkUser3.Checked ? 1 : 0);
            sb.Append(chkUser4.Checked ? 1 : 0);
            sb.Append(chkUser5.Checked ? 1 : 0);
            sb.Append(chkUser6.Checked ? 1 : 0);
            sb.Append("#");
            return sb.ToString();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsConnected == 0)
                {
                    port = new SerialPort(cmbComPorts.SelectedItem.ToString(), 9600, Parity.None, 8, StopBits.One);
                    port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                    // open serial port
                    if (!port.IsOpen)
                    {
                        port.Open();
                        btnConnect.BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\greenconnect.jpg");
                        btnConnect.Text = "Connected";
                        IsConnected = 1;
                    }
                }
                else if (IsConnected == 1)
                {
                    if (port.IsOpen)
                    {
                        port.Close();
                        btnConnect.BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\reddisconnect.jpg");
                        btnConnect.Text = "Connect";
                        IsConnected = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(DoUpDate));
        }

        private void DoUpDate(object s, EventArgs e)
        {
            string incomingDetails = port.ReadExisting();

            if (incomingDetails.ToUpper().Contains("DESKAI"))
            {
                setFieldsIpSett(incomingDetails);
            }
        }

        private void setFieldsIpSett(string details)
        {
            try
            {
                details = details.Substring(details.IndexOf(" ") + 2, details.Length - 1 - (details.IndexOf(" ") + 2));
                string[] fields = details.Split(",");
                cmbSelectChannel.SelectedIndex = Convert.ToInt32(fields[0]);
                cmbAIType.SelectedIndex = Convert.ToInt32(fields[1]);
                cmbAIAlarm.SelectedIndex = Convert.ToInt32(fields[2]);
                txtMinValue.Text = fields[3];
                txtMaxValue.Text = fields[4];
                txtThresoldHigh.Text = fields[5];
                txtThresoldLow.Text = fields[6];
                txtAlarmConfirmationSec.Text = fields[7];
                txtAlarmSmsInterval.Text = fields[8];
                chkAIDataReport.Checked = fields[9] == "0" ? false : true;
                cmbAIReportDataType.SelectedIndex = Convert.ToInt32(fields[10]);
                chkTotalizer.Checked = fields[11] == "0" ? false : true;
                chkVolatileFlag.Checked = fields[12] == "0" ? false : true;
                txtKFactor.Text = fields[13].ToString();
                txtTimebase.Text = fields[14];
                txtDisplayDecimalPoint.Text = fields[15];
                chkDataReport.Checked = fields[16] == "0" ? false : true;
                cmbReportDataType.SelectedIndex = Convert.ToInt32(fields[17]);
                cmbDO1.SelectedIndex = Convert.ToInt32(fields[18].Substring(0, 1));
                cmbDO2.SelectedIndex = Convert.ToInt32(fields[18].Substring(1, 1));
                cmbDO3.SelectedIndex = Convert.ToInt32(fields[18].Substring(2, 1));
                cmbDO4.SelectedIndex = Convert.ToInt32(fields[18].Substring(3, 1));
                cmbDO5.SelectedIndex = Convert.ToInt32(fields[18].Substring(4, 1));
                cmbDO6.SelectedIndex = Convert.ToInt32(fields[18].Substring(5, 1));
                cmbDO7.SelectedIndex = Convert.ToInt32(fields[18].Substring(6, 1));
                cmbDO8.SelectedIndex = Convert.ToInt32(fields[18].Substring(7, 1));
                chkUser1.Checked = fields[19].Substring(0, 1) == "0" ? false : true;
                chkUser2.Checked = fields[19].Substring(1, 1) == "0" ? false : true;
                chkUser3.Checked = fields[19].Substring(2, 1) == "0" ? false : true;
                chkUser4.Checked = fields[19].Substring(3, 1) == "0" ? false : true;
                chkUser5.Checked = fields[19].Substring(4, 1) == "0" ? false : true;
                chkUser6.Checked = fields[19].Substring(5, 1) == "0" ? false : true;
                port.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Information");
            }
        }

        private void btnWriteMemory_Click(object sender, EventArgs e)
        {
            string sendData = CreateCommaSeparatedAI();
            pbProcessing.Value = 0;
            if (IsConnected == 0)
            {
                MessageBox.Show("No port is connected.", "Warning");
                return;
            }
            IsReadyToSend = true;
            uploadSettings(sendData);
        }
        private void uploadSettings(string data)
        {
            try
            {
                if (IsReadyToSend)
                {
                    if (port.IsOpen)
                    {
                        port.WriteLine(data);
                    }
                    pbProcessing.Value = 100;
                    IsReadyToSend = false;
                    MessageBox.Show("Data uploaded successfully.", "Information");
                    port.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
            }
        }

        private void btnReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if(!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdevice#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
