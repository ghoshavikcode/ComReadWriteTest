using System.Data;
using System.IO.Ports;
using System.Text;

namespace TechavoSystem
{
    public partial class Dashboard : Form
    {
        #region CommonToAll
        private static int IsConnected = 0;
        static SerialPort port;
        private static bool IsReadyToSend = false;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            #region Events
            this.menu.NodeMouseClick += menu_Click;
            this.FormClosing += Dashboard_FormClosing;
            cmbComPorts.DataSource = SerialPort.GetPortNames();
            txtDoOnTime.Leave += TimeFormatCheck;
            txtDoOffTime.Leave += TimeFormatCheck;
            txtDoRelayCloseOn.Leave += NumericCheck;
            txtDoRelayDelayTime.Leave += NumericCheck;
            txtGeneralDataLogSec.Leave += NumericCheck;
            txtGeneralSmsLogSec.Leave += NumericCheck;
            txtGeneralSetTime.Leave += TimeFormatCheck;
            txtMinValue.Leave += NumericCheck;
            txtMaxValue.Leave += NumericCheck;
            txtThresoldHigh.Leave += NumericCheck;
            txtThresoldLow.Leave += NumericCheck;
            txtAlarmConfirmationSec.Leave += NumericCheck;
            txtAlarmSmsInterval.Leave += NumericCheck;
            txtDisplayDecimalPoint.Leave += DecimalCheck;
            txtDIAlarmVerifySec.Leave += NumericCheck;
            txtDISmsRepeatTime.Leave += NumericCheck;
            txtDISMSRepeatSec.Leave += NumericCheck;
            txtAdjustPulseCount.Leave += NumericCheck;
            txtPulseKfactor.Leave += NumericCheck;
            txtKFactor.Leave += NumericCheck;
            txtPulseDurationRef.Leave += NumericCheck;
            txtUserMobileNo.Leave += NumericCheck;
            txtModbusPollingInterval.Leave += NumericCheck;
            txtModbusTimeout.Leave += NumericCheck;
            txtModbusSlaveId.Leave += TxtModbusSlaveId_Leave;
            #endregion
        }

        private void TxtModbusSlaveId_Leave(object? sender, EventArgs e)
        {
            NumericChecker((TextBox)sender);
            if (Int32.TryParse(((TextBox)sender).Text, out int value))
            {
                if(value < 1 || value > 255)
                {
                    MessageBox.Show("Please enter numeric value from 1 to 255");
                    ((TextBox)sender).Text = string.Empty;
                }
            }
        }

        private void NumericCheck(object? sender, EventArgs e)
        {
            NumericChecker((TextBox)sender);
        }
        private void DecimalCheck(object? sender, EventArgs e)
        {
            DecimalChecker((TextBox)sender);
        }

        private void TimeFormatCheck(object? sender, EventArgs e)
        {
            CheckTime((TextBox)sender);
        }

        private void Dashboard_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (port is not null && port.IsOpen)
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
            pnlDOSettings.Visible = false;
            pnlDISettings.Visible = false;
            pnlPulseSettings.Visible = false;
            pnlUser.Visible = false;
            pnlModbusSettings.Visible = false;
            pnlModbusMaster.Visible = false;
            pnlModbusSlave.Visible = false;
            pnlGPRSSettings.Visible = false;
            pnlStatus.Visible = false;
            pnlConsole.Visible = false;
        }

        private void menu_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Name == null)
                {
                    return;
                }
                HideAllPanel();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                if (e.Node.Name == "GeneralSettings")
                {
                    pnlGeneralSettings.Visible = true;
                }
                else if (e.Node.Name == "AISettings")
                {
                    pnlAISettings.Visible = true;
                }
                else if (e.Node.Name == "DISettings")
                {
                    pnlDISettings.Visible = true;
                }
                else if (e.Node.Name == "DOSettings")
                {
                    pnlDOSettings.Visible = true;
                }
                else if (e.Node.Name == "ModbusSettings")
                {
                    pnlModbusSettings.Visible = true;
                }
                else if (e.Node.Name == "GPRSSettings")
                {
                    pnlGPRSSettings.Visible = true;
                }
                else if (e.Node.Name == "PulseSettings")
                {
                    pnlPulseSettings.Visible = true;
                }
                else if (e.Node.Name == "User")
                {
                    pnlUser.Visible = true;
                }
                else if (e.Node.Name == "ModbusSlave")
                {
                    pnlModbusSlave.Visible = true;
                }
                else if (e.Node.Name == "ModbusMaster")
                {
                    pnlModbusMaster.Visible = true;
                }
                else if (e.Node.Name == "status")
                {
                    pnlStatus.Visible = true;
                }
                else if (e.Node.Name == "console")
                {
                    pnlConsole.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
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
                        CloseConnection();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private void CloseConnection()
        {
            if (port.IsOpen)
            {
                port.Close();
            }
            btnConnect.BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\reddisconnect.jpg");
            btnConnect.Text = "Connect";
            IsConnected = 0;
        }
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                this.Invoke(new EventHandler(DoUpDate));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private void DoUpDate(object s, EventArgs e)
        {
            string incomingDetails = port.ReadExisting();

            if (incomingDetails.ToUpper().Contains("DESKAI"))
            {
                setFieldsAISett(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("DESKDI"))
            {
                setFieldsDISett(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("DESKDO"))
            {
                setFieldsDOSett(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("DESKPULSE"))
            {
                setFieldsPulseSett(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("USER"))
            {
                setFieldsUserSett(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("DESKGEN"))
            {
                setFieldsGeneralSett(incomingDetails);
            }
            else if (incomingDetails.ToUpper().Contains("STRANS"))
            {
                setFieldsModbusSlave(incomingDetails);
            }
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
                    lblProgressPercent.Text = pbProcessing.Value + "%";
                    IsReadyToSend = false;
                    MessageBox.Show("Data uploaded successfully.", "Information");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private void CheckTime(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return;
            if (!textBox.Text.Contains(":"))
            {
                MessageBox.Show("Time format should be HH:MM");
                textBox.Text = string.Empty;
            }
            else
            {
                string[] hourMin = textBox.Text.Split(':');
                if (hourMin[0].Length != 2 || hourMin[1].Length != 2)
                {
                    MessageBox.Show("Time format should be HH:MM");
                    textBox.Text = string.Empty;
                }
                else
                {
                    int hour = 0;
                    int minute = 0;
                    bool successHour = int.TryParse(hourMin[0], out hour);
                    bool successMin = int.TryParse(hourMin[1], out minute);
                    if (!successHour || !successMin || hour > 23 || minute > 59)
                    {
                        MessageBox.Show("Invalid Time");
                        textBox.Text = string.Empty;
                    }
                }
            }
        }
        private void NumericChecker(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return;
            long value = 0;
            bool success = long.TryParse(textBox.Text, out value);
            if (!success)
            {
                MessageBox.Show("Please enter numeric value");
                textBox.Text = string.Empty;
            }
        }
        private void DecimalChecker(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return;
            decimal value = 0;
            bool success = decimal.TryParse(textBox.Text, out value);
            if (!success)
            {
                MessageBox.Show("Please enter decimal value");
                textBox.Text = string.Empty;
            }
        }
        #endregion
        #region AI
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
        private void setFieldsAISett(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
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
                //port.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private void btnReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdeviceAI#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }
        private void btnWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedAI();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sendData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        #endregion
        #region DI
        private void setFieldsDISett(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                cmbDISelectChannel.SelectedIndex = Convert.ToInt32(fields[0]);
                cmbDIType.SelectedIndex = Convert.ToInt32(fields[1]);
                cmbDIAlarm.SelectedIndex = Convert.ToInt32(fields[2]);
                txtDIAlarmVerifySec.Text = fields[3];
                txtDISmsRepeatTime.Text = fields[4];
                txtDISMSRepeatSec.Text = fields[5];
                chkDIDataReport.Checked = fields[6] == "0" ? false : true;
                cmbDIReportDt.SelectedIndex = Convert.ToInt32(fields[7]);
                cmbDIDO1.SelectedIndex = Convert.ToInt32(fields[8].Substring(0, 1));
                cmbDIDO2.SelectedIndex = Convert.ToInt32(fields[8].Substring(1, 1));
                cmbDIDO3.SelectedIndex = Convert.ToInt32(fields[8].Substring(2, 1));
                cmbDIDO4.SelectedIndex = Convert.ToInt32(fields[8].Substring(3, 1));
                cmbDIDO5.SelectedIndex = Convert.ToInt32(fields[8].Substring(4, 1));
                cmbDIDO6.SelectedIndex = Convert.ToInt32(fields[8].Substring(5, 1));
                cmbDIDO7.SelectedIndex = Convert.ToInt32(fields[8].Substring(6, 1));
                cmbDIDO8.SelectedIndex = Convert.ToInt32(fields[8].Substring(7, 1));
                chkDIUser1.Checked = fields[9].Substring(0, 1) == "0" ? false : true;
                chkDIUser2.Checked = fields[9].Substring(1, 1) == "0" ? false : true;
                chkDIUser3.Checked = fields[9].Substring(2, 1) == "0" ? false : true;
                chkDIUser4.Checked = fields[9].Substring(3, 1) == "0" ? false : true;
                chkDIUser5.Checked = fields[9].Substring(4, 1) == "0" ? false : true;
                chkDIUser6.Checked = fields[9].Substring(5, 1) == "0" ? false : true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private void btnDIReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdeviceDI#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }

        private void btnDIWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedDI();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0";
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sendData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private string CreateCommaSeparatedDI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*DESKDI, ,");
            sb.Append(cmbDISelectChannel.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbDIType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbDIAlarm.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtDIAlarmVerifySec.Text.Trim());
            sb.Append(",");
            sb.Append(txtDISmsRepeatTime.Text.Trim());
            sb.Append(",");
            sb.Append(txtDISMSRepeatSec.Text.Trim());
            sb.Append(",");
            sb.Append(chkDIDataReport.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(cmbDIReportDt.SelectedIndex);
            sb.Append(",");
            sb.Append(cmbDIDO1.SelectedIndex.ToString());
            sb.Append(cmbDIDO2.SelectedIndex.ToString());
            sb.Append(cmbDIDO3.SelectedIndex.ToString());
            sb.Append(cmbDIDO4.SelectedIndex.ToString());
            sb.Append(cmbDIDO5.SelectedIndex.ToString());
            sb.Append(cmbDIDO6.SelectedIndex.ToString());
            sb.Append(cmbDIDO7.SelectedIndex.ToString());
            sb.Append(cmbDIDO8.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(chkDIUser1.Checked ? 1 : 0);
            sb.Append(chkDIUser2.Checked ? 1 : 0);
            sb.Append(chkDIUser3.Checked ? 1 : 0);
            sb.Append(chkDIUser4.Checked ? 1 : 0);
            sb.Append(chkDIUser5.Checked ? 1 : 0);
            sb.Append(chkDIUser6.Checked ? 1 : 0);
            sb.Append("#");
            return sb.ToString();
        }
        #endregion
        #region DO
        private void btnDOReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdeviceDO#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }
        private void btnDOWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedDO();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sendData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private string CreateCommaSeparatedDO()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*DESKDO, ,");
            sb.Append(cmbDOSelectChannel.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbDOType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtDoRelayCloseOn.Text.Trim());
            sb.Append(",");
            sb.Append(txtDoRelayDelayTime.Text.Trim());
            sb.Append(",");
            sb.Append(txtDoOnTime.Text.Trim());
            sb.Append(",");
            sb.Append(txtDoOffTime.Text.Trim());
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsDOSett(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                cmbDOSelectChannel.SelectedIndex = Convert.ToInt32(fields[0]);
                cmbDOType.SelectedIndex = Convert.ToInt32(fields[1]);
                txtDoRelayCloseOn.Text = fields[2];
                txtDoRelayDelayTime.Text = fields[3];
                txtDoOnTime.Text = fields[4];
                txtDoOffTime.Text = fields[5];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        #endregion
        #region Pulse
        private void btnPulseReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdevicePulse#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }
        private void btnPulseWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedPulse();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sendData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private string CreateCommaSeparatedPulse()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*DESKPULSE, ,");
            sb.Append(txtAdjustPulseCount.Text.Trim());
            sb.Append(",");
            sb.Append(txtPulseKfactor.Text.Trim());
            sb.Append(",");
            sb.Append(chkPulseIsVolatile.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(txtPulseDurationRef.Text.Trim());
            sb.Append(",");
            sb.Append(cmbPulseReportDT.SelectedIndex.ToString());
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsPulseSett(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                txtAdjustPulseCount.Text = fields[0];
                txtPulseKfactor.Text = fields[1];
                chkPulseIsVolatile.Checked = fields[2] == "0" ? false : true;
                txtPulseDurationRef.Text = fields[3];
                cmbPulseReportDT.SelectedIndex = Convert.ToInt32(fields[4]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        #endregion
        #region User
        private void btnUserReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdeviceUser#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }
        private void btnUserWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedUser();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sendData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private string CreateCommaSeparatedUser()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*USER, ,");
            sb.Append(cmbUserIndex.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtUserMobileNo.Text.Trim());
            sb.Append(",");
            sb.Append(chkUserSmsTimerReport.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkUserSmsOnPowerOn.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkUserSmsOnLowTower.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkUserSmsOnGprsFail.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkUserIsAdmin.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkUserIsAlarm.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkUserCanCall.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(cmbUserSelectDo.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(chkUserIsVolatile.Checked ? 1 : 0);
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsUserSett(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                cmbUserIndex.SelectedIndex = Convert.ToInt32(fields[0]);
                txtUserMobileNo.Text = fields[1];
                chkUserSmsTimerReport.Checked = fields[2] == "0" ? false : true;
                chkUserSmsOnPowerOn.Checked = fields[3] == "0" ? false : true;
                chkUserSmsOnLowTower.Checked = fields[4] == "0" ? false : true;
                chkUserSmsOnGprsFail.Checked = fields[5] == "0" ? false : true;
                chkUserIsAdmin.Checked = fields[6] == "0" ? false : true;
                chkUserIsAlarm.Checked = fields[7] == "0" ? false : true;
                chkUserCanCall.Checked = fields[8] == "0" ? false : true;
                cmbUserSelectDo.SelectedIndex = Convert.ToInt32(fields[9]);
                chkUserIsVolatile.Checked = fields[10] == "0" ? false : true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        #endregion
        #region General
        private void btnGeneralReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdeviceGeneral#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }
        private void btnGeneralWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedGeneral();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sendData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private string CreateCommaSeparatedGeneral()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*DESKGEN, ,");
            sb.Append(txtGeneralUserId.Text.Trim());
            sb.Append(",");
            sb.Append(txtIemiNo.Text.Trim());
            sb.Append(",");
            sb.Append(txtGeneralDataLogSec.Text.Trim());
            sb.Append(",");
            sb.Append(txtGeneralSmsLogSec.Text.Trim());
            sb.Append(",");
            sb.Append(dtGeneralSetDate.Text);
            sb.Append(",");
            sb.Append(txtGeneralSetTime.Text.Trim());
            sb.Append(",");
            sb.Append(chkGeneralModbusDebug.Checked ? 1 : 0);
            sb.Append(",");
            sb.Append(chkGeneralRtcDebug.Checked ? 1 : 0);
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsGeneralSett(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                txtGeneralUserId.Text = fields[0];
                txtIemiNo.Text = fields[1];
                txtGeneralDataLogSec.Text = fields[2];
                txtGeneralSmsLogSec.Text = fields[3];
                dtGeneralSetDate.Text = fields[4];
                txtGeneralSetTime.Text = fields[5];
                chkGeneralModbusDebug.Checked = fields[6] == "0" ? false : true;
                chkGeneralRtcDebug.Checked = fields[7] == "0" ? false : true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        #endregion
        #region GPRS
        private void cmbConnectProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConnectProtocol.SelectedIndex == 0)
            {
                EnableDisableGPRSControls(true);
            }
            else
            {
                EnableDisableGPRSControls(false);
            }
        }
        private void EnableDisableGPRSControls(bool enableGPRSControls)
        {
            gbGprsIPSett1.Enabled = !enableGPRSControls;
            gbGprsIPSett2.Enabled = !enableGPRSControls;
            gbGprsModemSett.Enabled = !enableGPRSControls;

            gbGprsBrokerSett.Enabled = enableGPRSControls;
            gbGprsTopics.Enabled = enableGPRSControls;
        }
        #endregion
        #region Modbus Slave
        private void btnModbusSlaveReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdeviceSlave#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }
        private void btnModbusSlaveWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedSlave();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sendData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private string CreateCommaSeparatedSlave()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*STRANS, ,");
            sb.Append(cmbModbusPortType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtModbusSlaveId.Text.Trim());
            sb.Append(",");
            sb.Append(cmbModbusBaudRate.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbModbusUartType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtModbusPollingInterval.Text.Trim());
            sb.Append(",");
            sb.Append(txtModbusTimeout.Text.Trim());
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsModbusSlave(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                cmbModbusPortType.SelectedIndex = Convert.ToInt32(fields[0]);
                txtModbusSlaveId.Text = fields[1];
                cmbModbusBaudRate.SelectedIndex = Convert.ToInt32(fields[2]);
                cmbModbusUartType.SelectedIndex = Convert.ToInt32(fields[3]);
                txtModbusPollingInterval.Text = fields[4];
                txtModbusTimeout.Text = fields[5];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        #endregion
        #region Modbus Master
        
        #endregion
    }
}
