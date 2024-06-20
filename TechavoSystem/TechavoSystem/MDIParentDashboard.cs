using System;
using System.Data;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace TechavoSystem
{
    public partial class Dashboard : Form
    {
        #region CommonToAll
        private static bool logMonitor = true;
        private static int IsConnected = 0;
        private SerialPort port;
        private static bool IsReadyToSend = false;
        private int errorCount = 0;
        private int errorLimit = 10;
        private string dataRead = string.Empty;
        public Dashboard()
        {
            InitializeComponent();
        }
        private void errorReset_Tick(object sender, EventArgs e)
        {
            errorCount = 0;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cmbDOSelectChannel.Items.Clear();
            cmbDISelectChannel.Items.Clear();
            cmbSelectChannel.Items.Clear();
            cmbConnectProtocol.SelectedIndex = 2;
            EnableDisableGPRSControls(true);
            enableDisableReadWrite(false);
            #region Events
            assignEvents();
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
            txtMinValue.Leave += DecimalCheck;
            txtMaxValue.Leave += DecimalCheck;
            txtThresoldHigh.Leave += DecimalCheck;
            txtThresoldLow.Leave += DecimalCheck;
            txtAlarmConfirmationSec.Leave += NumericCheck;
            txtAlarmSmsInterval.Leave += NumericCheck;
            txtDisplayDecimalPoint.Leave += DecimalCheck;
            txtDIAlarmVerifySec.Leave += NumericCheck;
            txtDISmsRepeatTime.Leave += NumericCheck;
            txtDISMSRepeatSec.Leave += NumericCheck;
            txtAdjustPulseCount.Leave += NumericCheck;
            txtPulseKfactor.Leave += NumericCheck;
            txtKFactor.Leave += DecimalCheck;
            txtPulseDurationRef.Leave += NumericCheck;
            txtUserMobileNo.Leave += NumericCheck;
            txtModbusPollingInterval.Leave += NumericCheck;
            txtModbusTimeout.Leave += NumericCheck;
            txtModbusSlaveId.Leave += TxtModbusSlaveId_Leave;
            txtMasterSlaveId.Leave += TxtModbusSlaveId_Leave;
            txtMasterPollingInterval.Leave += NumericCheck;
            txtMasterTimeout.Leave += NumericCheck;
            #endregion
        }

        private void TxtModbusSlaveId_Leave(object? sender, EventArgs e)
        {
            NumericChecker((TextBox)sender);
            if (Int32.TryParse(((TextBox)sender).Text, out int value))
            {
                if (value < 1 || value > 255)
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
                if (errorCount > errorLimit)
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
            cmbTimebase.Enabled = isChecked;
            chkVolatileFlag.Enabled = isChecked;
            txtDisplayDecimalPoint.Enabled = isChecked;
            chkDataReport.Enabled = isChecked;
            cmbReportDataType.Enabled = isChecked;
            txtTotalizerUnit.Enabled = isChecked;
        }

        private void btnPortRefresh_Click(object sender, EventArgs e)
        {
            if (IsConnected == 1)
            {
                if (port.IsOpen)
                {
                    CloseConnection();
                }
            }
            cmbComPorts.DataSource = SerialPort.GetPortNames();
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
                        dataRead = "*MDL";
                        port.WriteLine("*MDL#");
                    }
                }
                else if (IsConnected == 1)
                {
                    if (port.IsOpen)
                    {
                        CloseConnection();
                        enableDisableReadWrite(false);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private void enableDisableReadWrite(bool enable)
        {
            try
            {
                btnReadMemoryAI.Enabled = enable;
                btnDIReadMemory.Enabled = enable;
                btnDOReadMemory.Enabled = enable;
                btnGeneralReadMemory.Enabled = enable;
                btnGPRSReadMemory.Enabled = enable;
                btnModbusSlaveReadMemory.Enabled = enable;
                btnPulseReadMemory.Enabled = enable;
                btnUserReadMemory.Enabled = enable;
                btnRegReadMemory1.Enabled = enable;
                btnRegReadMemory2.Enabled = enable;
                btnRegReadMemory3.Enabled = enable;
                btnRegReadMemory4.Enabled = enable;
                btnRegReadMemory5.Enabled = enable;
                btnRegReadMemory6.Enabled = enable;
                btnRegReadMemory7.Enabled = enable;
                btnRegReadMemory8.Enabled = enable;
                btnRegReadMemory9.Enabled = enable;
                btnRegReadMemory10.Enabled = enable;
                btnRegReadMemory11.Enabled = enable;
                btnRegReadMemory12.Enabled = enable;
                btnRegReadMemory13.Enabled = enable;
                btnRegReadMemory14.Enabled = enable;
                btnRegReadMemory15.Enabled = enable;
                btnRegReadMemory16.Enabled = enable;
                btnRegReadMemory17.Enabled = enable;
                btnRegReadMemory18.Enabled = enable;
                btnRegReadMemory19.Enabled = enable;
                btnRegReadMemory20.Enabled = enable;
                btnIOStatusRead.Enabled = enable;
                btnModbusRead.Enabled = enable;
                btnStatusGSMRead.Enabled = enable;
                btnSlaveConnectionReadMemory.Enabled = enable;
                btnMasterReadAll.Enabled = enable;

                btnWriteMemoryAI.Enabled = enable;
                btnDIWriteMemory.Enabled = enable;
                btnDOWriteMemory.Enabled = enable;
                btnGeneralWriteMemory.Enabled = enable;
                btnGPRSWriteMemory.Enabled = enable;
                btnModbusSlaveWriteMemory.Enabled = enable;
                btnPulseWriteMemory.Enabled = enable;
                btnUserWriteMemory.Enabled = enable;
                btnRegWriteMemory1.Enabled = enable;
                btnRegWriteMemory2.Enabled = enable;
                btnRegWriteMemory3.Enabled = enable;
                btnRegWriteMemory4.Enabled = enable;
                btnRegWriteMemory5.Enabled = enable;
                btnRegWriteMemory6.Enabled = enable;
                btnRegWriteMemory7.Enabled = enable;
                btnRegWriteMemory8.Enabled = enable;
                btnRegWriteMemory9.Enabled = enable;
                btnRegWriteMemory10.Enabled = enable;
                btnRegWriteMemory11.Enabled = enable;
                btnRegWriteMemory12.Enabled = enable;
                btnRegWriteMemory13.Enabled = enable;
                btnRegWriteMemory14.Enabled = enable;
                btnRegWriteMemory15.Enabled = enable;
                btnRegWriteMemory16.Enabled = enable;
                btnRegWriteMemory17.Enabled = enable;
                btnRegWriteMemory18.Enabled = enable;
                btnRegWriteMemory19.Enabled = enable;
                btnRegWriteMemory20.Enabled = enable;
                btnConsoleSend.Enabled = enable;
                btnSlaveConnectionWriteMemory.Enabled = enable;
                btnMasterWriteAll.Enabled = enable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                CloseConnection();
            }
        }
        private void CloseConnection()
        {
            if (port != null && port.IsOpen)
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void DoUpDate(object s, EventArgs e)
        {
            try
            {
                if (port == null || !port.IsOpen)
                {
                    btnConnect.BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\reddisconnect.jpg");
                    btnConnect.Text = "Connect";
                    IsConnected = 0;
                    return;
                }
                if (IsConnected == 0)
                    return;
                string incomingDetails = port.ReadLine();
                if (string.IsNullOrEmpty(incomingDetails) || incomingDetails.Trim().Length <= 1)
                    return;
                incomingDetails = incomingDetails.Substring(0, incomingDetails.Length - 1);
                if (logMonitor)
                {
                    txtSystemLog.AppendText("\r\n" + incomingDetails);
                }
                if (string.IsNullOrEmpty(dataRead) || !incomingDetails.ToUpper().Contains(dataRead.ToUpper()))
                    return;
                dataRead = string.Empty;
                if (incomingDetails.ToUpper().Contains("*DESKAI"))
                {
                    setFieldsAISett(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*DESKDI"))
                {
                    setFieldsDISett(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*DODESK"))
                {
                    setFieldsDOSett(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*DESKPULSE"))
                {
                    setFieldsPulseSett(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*USER"))
                {
                    setFieldsUserSett(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*DESKGEN"))
                {
                    setFieldsGeneralSett(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*STRANS"))
                {
                    setFieldsModbusSlave(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*SLVSET"))
                {
                    setFieldsModbusMasterSlaveConnection(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*REGSET") && incomingDetails.ToUpper().Contains("|"))
                {
                    setFieldsModbusRegisterConnectionAll(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*REGSET"))
                {
                    setFieldsModbusRegisterConnection(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*CREDIP") || incomingDetails.ToUpper().Contains("*CREDMQTT"))
                {
                    setFieldsGPRS(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*GSMST"))
                {
                    setFieldsGsmStatus(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*INPUTPARA"))
                {
                    setFieldsIOStatus(incomingDetails);
                }
                else if (incomingDetails.ToUpper().Contains("*MDL,"))
                {
                    setChannels(incomingDetails);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace, "Error");
                btnConnect.BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\reddisconnect.jpg");
                btnConnect.Text = "Connect";
                IsConnected = 0;
            }
        }
        private void setChannels(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf("*MDL,") + 5, details.ToString().Length - 1 - (details.ToString().IndexOf("*MDL,") + 5));
                string[] fields = details.ToString().Split(",");
                int channels = Convert.ToInt32(fields[2]);
                for (int i = 0; i < channels; i++)
                {
                    cmbDOSelectChannel.Items.Add(i);
                }
                channels = Convert.ToInt32(fields[3]);
                for (int i = 0; i < channels; i++)
                {
                    cmbDISelectChannel.Items.Add(i);
                }
                channels = Convert.ToInt32(fields[4]);
                for (int i = 0; i < channels; i++)
                {
                    cmbSelectChannel.Items.Add(i);
                }
                //channels = Convert.ToInt32(fields[5]);
                //for (int i = 0; i < channels; i++)
                //{
                //    cmbAOSelectChannel.Items.Add(i);
                //}
                //channels = Convert.ToInt32(fields[6]);
                //for (int i = 0; i < channels; i++)
                //{
                //    cmbSelectChannel.Items.Add(i);
                //}
                enableDisableReadWrite(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
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
                if (errorCount > errorLimit)
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
            sb.Append(cmbTimebase.SelectedIndex.ToString());
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
                cmbTimebase.SelectedIndex = Convert.ToInt32(fields[14]);
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void btnReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSelectChannel.SelectedIndex == -1)
                    MessageBox.Show("Please select channel first");
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*DESKAI";
                    port.WriteLine("*readdeviceAI," + cmbSelectChannel.SelectedIndex + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void btnDIReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbDISelectChannel.SelectedIndex == -1)
                    MessageBox.Show("Please select channel first");
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*DESKDI";
                    port.WriteLine("*readdeviceDI," + cmbDISelectChannel.SelectedIndex + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
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
                if (cmbDOSelectChannel.SelectedIndex == -1)
                    MessageBox.Show("Please select channel first");
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*DODESK";
                    port.WriteLine("*readdeviceDO," + cmbDOSelectChannel.SelectedIndex + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private string CreateCommaSeparatedDO()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*DODESK, ,");
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
                if (errorCount > errorLimit)
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
                    dataRead = "*DESKPULSE";
                    port.WriteLine("*readdevicePulse#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        #endregion
        #region User
        private void btnUserReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUserIndex.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select User Index first");
                }
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*USER";
                    port.WriteLine("*readdeviceUser," + cmbUserIndex.SelectedIndex + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
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
                    dataRead = "*DESKGEN";
                    port.WriteLine("*readdeviceGeneral#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
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
            sb.Append(Convert.ToDateTime(dtGeneralSetDate.Text).ToString("dd/MM/yyyy"));
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        #endregion
        #region GPRS
        private void cmbConnectProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbConnectProtocol.SelectedIndex == 2)
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

            gbGprsBrokerSett.Enabled = enableGPRSControls;
            gbGprsTopics.Enabled = enableGPRSControls;
        }
        private void btnIPSettPassView_Click(object sender, EventArgs e)
        {
            if (txtSimPassword.UseSystemPasswordChar)
                txtSimPassword.UseSystemPasswordChar = false;
            else
                txtSimPassword.UseSystemPasswordChar = true;
        }
        private void btnMQTTShowPass_Click(object sender, EventArgs e)
        {
            if (txtMQTTPassword.UseSystemPasswordChar)
                txtMQTTPassword.UseSystemPasswordChar = false;
            else
                txtMQTTPassword.UseSystemPasswordChar = true;
        }
        private void btnGPRSReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    if (cmbConnectProtocol.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select protocol first");
                    }
                    if (cmbConnectProtocol.SelectedIndex != 2)
                    {
                        dataRead = "*CREDIP";
                    }
                    else
                    {
                        dataRead = "*CREDMQTT";
                    }
                    port.WriteLine("*readdeviceGPRS," + cmbConnectProtocol.SelectedIndex + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }

        private void btnGPRSWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedGPRS();
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private string CreateCommaSeparatedGPRS()
        {
            StringBuilder sb = new StringBuilder();
            if (cmbConnectProtocol.SelectedIndex != 2)
            {
                sb.Append("*CREDIP, ,");
                sb.Append(cmbConnectProtocol.SelectedIndex.ToString());
                sb.Append(",");
                sb.Append(txtServerIPURL.Text.Trim());
                sb.Append(",");
                sb.Append(txtServerPort.Text.Trim());
                sb.Append(",");
                sb.Append(chkSSLSecurityEnable.Checked ? 1 : 0);
                sb.Append(",");
                sb.Append(cmbSSLSecurityEnabled.SelectedIndex.ToString());
                sb.Append(",");
                sb.Append(cmbEventTransmission.SelectedIndex.ToString());
                sb.Append(",");
                sb.Append(txtIP2ServerIP.Text.Trim());
                sb.Append(",");
                sb.Append(txtIP2ServerPort.Text.Trim());
                sb.Append(",");
                sb.Append(chkIp2SSLSecurityEnable.Checked ? 1 : 0);
                sb.Append(",");
                sb.Append(cmbIp2SSLSecurityEnabled.SelectedIndex.ToString());
                sb.Append(",");
                sb.Append(cmbIp2EventTransmission.SelectedIndex.ToString());
                sb.Append(",");
                sb.Append(txtAPN.Text.Trim());
                sb.Append(",");
                sb.Append(txtSimUserName.Text.Trim());
                sb.Append(",");
                sb.Append(txtSimPassword.Text.Trim());
                sb.Append("#");
            }
            else
            {
                sb.Append("*CREDMQTT, ,");
                sb.Append(cmbConnectProtocol.SelectedIndex.ToString());
                sb.Append(",");
                sb.Append(txtBrokerIPDomain.Text.Trim());
                sb.Append(",");
                sb.Append(txtBrokerPort.Text.Trim());
                sb.Append(",");
                sb.Append(txtMQTTUserName.Text.Trim());
                sb.Append(",");
                sb.Append(txtMQTTPassword.Text.Trim());
                sb.Append(",");
                sb.Append(txtClientId.Text.Trim());
                sb.Append(",");
                sb.Append(chkAuthEnable.Checked ? 1 : 0);
                sb.Append(",");
                sb.Append(cmbQosLevel.SelectedIndex.ToString());
                sb.Append(",");
                sb.Append(txtPublishEvent.Text.Trim());
                sb.Append(",");
                sb.Append(txtPublishCMDReply.Text.Trim());
                sb.Append(",");
                sb.Append(txtSubscribeCmd.Text.Trim());
                sb.Append(",");
                sb.Append(txtAPN.Text.Trim());
                sb.Append(",");
                sb.Append(txtSimUserName.Text.Trim());
                sb.Append(",");
                sb.Append(txtSimPassword.Text.Trim());
                sb.Append("#");
            }

            return sb.ToString();
        }
        private void setFieldsGPRS(object details)
        {
            try
            {
                bool isMQTT = details.ToString().Contains("*CREDMQTT");
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                if (isMQTT)
                {
                    cmbConnectProtocol.SelectedIndex = Convert.ToInt32(fields[0]);
                    txtBrokerIPDomain.Text = fields[1];
                    txtBrokerPort.Text = fields[2];
                    txtMQTTUserName.Text = fields[3];
                    txtMQTTPassword.Text = fields[4];
                    txtClientId.Text = fields[5];
                    chkAuthEnable.Checked = fields[6] == "0" ? false : true;
                    cmbQosLevel.SelectedIndex = Convert.ToInt32(fields[7]);
                    txtPublishEvent.Text = fields[8];
                    txtPublishCMDReply.Text = fields[9];
                    txtSubscribeCmd.Text = fields[10];
                    txtAPN.Text = fields[11];
                    txtSimUserName.Text = fields[12];
                    txtSimPassword.Text = fields[13];
                }
                else
                {
                    cmbConnectProtocol.SelectedIndex = Convert.ToInt32(fields[0]);
                    txtServerIPURL.Text = fields[1];
                    txtServerPort.Text = fields[2];
                    chkSSLSecurityEnable.Checked = fields[3] == "0" ? false : true;
                    cmbSSLSecurityEnabled.SelectedIndex = Convert.ToInt32(fields[4]);
                    cmbEventTransmission.SelectedIndex = Convert.ToInt32(fields[5]);
                    txtIP2ServerIP.Text = fields[6];
                    txtIP2ServerPort.Text = fields[7];
                    chkIp2SSLSecurityEnable.Checked = fields[8] == "0" ? false : true;
                    cmbIp2SSLSecurityEnabled.SelectedIndex = Convert.ToInt32(fields[9]);
                    cmbIp2EventTransmission.SelectedIndex = Convert.ToInt32(fields[10]);
                    txtAPN.Text = fields[11];
                    txtSimUserName.Text = fields[12];
                    txtSimPassword.Text = fields[13];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        #endregion
        #region Modbus Slave
        private void btnModbusSlaveReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbModbusPortType.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select port type first.");
                    return;
                }
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*STRANS";
                    port.WriteLine("*readdeviceSlave," + cmbModbusPortType.SelectedIndex + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        #endregion
        #region Modbus Master
        private void btnSlaveConnectionWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = CreateCommaSeparatedMasterSlaveConnection();
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }

        }

        private void btnSlaveConnectionReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMasterSlaveIndex.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select slave index first");
                }
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*SLVSET";
                    port.WriteLine("*readdeviceMasterSlaveConnection," + cmbMasterSlaveIndex.SelectedIndex + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private string CreateCommaSeparatedMasterSlaveConnection()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("*SLVSET, ,");
            sb.Append(cmbMasterSlaveIndex.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtMasterSlaveId.Text.Trim());
            sb.Append(",");
            sb.Append(cmbMasterBaudRate.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(cmbMasterUartType.SelectedIndex.ToString());
            sb.Append(",");
            sb.Append(txtMasterPollingInterval.Text.Trim());
            sb.Append(",");
            sb.Append(txtMasterTimeout.Text.Trim());
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsModbusMasterSlaveConnection(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                cmbMasterSlaveIndex.SelectedIndex = Convert.ToInt32(fields[0]);
                txtMasterSlaveId.Text = fields[1];
                cmbMasterBaudRate.SelectedIndex = Convert.ToInt32(fields[2]);
                cmbMasterUartType.SelectedIndex = Convert.ToInt32(fields[3]);
                txtMasterPollingInterval.Text = fields[4];
                txtMasterTimeout.Text = fields[5];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void assignEvents()
        {
            Control[] c;
            for (int i = 1; i <= 20; i++)
            {
                c = groupBox19.Controls.Find("txtMasterRegIndex" + i.ToString(), true);
                if (c != null && c.Length > 0)
                {
                    ((TextBox)c[0]).Leave += MasterSlaveId_Leave; ;
                }
                c = groupBox19.Controls.Find("txtMasterRegStartAddress" + i.ToString(), true);
                if (c != null && c.Length > 0)
                {
                    ((TextBox)c[0]).Leave += NumericCheck; ;
                }
                c = groupBox19.Controls.Find("txtMasterScaleFactor" + i.ToString(), true);
                if (c != null && c.Length > 0)
                {
                    ((TextBox)c[0]).Leave += DecimalCheck;
                }
                c = groupBox19.Controls.Find("btnRegReadMemory" + i.ToString(), true);
                if (c != null && c.Length > 0)
                {
                    ((Button)c[0]).Click += btnModbusRegisterConnectionReadMemory_Click;
                }
                c = groupBox19.Controls.Find("btnRegWriteMemory" + i.ToString(), true);
                if (c != null && c.Length > 0)
                {
                    ((Button)c[0]).Click += btnModbusRegisterConnectionWriteMemory_Click;
                }
            }
        }

        private void MasterSlaveId_Leave(object? sender, EventArgs e)
        {
            NumericChecker((TextBox)sender);
            if (Int32.TryParse(((TextBox)sender).Text, out int value))
            {
                if (value < 1 || value > 19)
                {
                    MessageBox.Show("Please enter numeric value from 1 to 19");
                    ((TextBox)sender).Text = string.Empty;
                }
            }
        }
        private void btnModbusRegisterConnectionWriteMemory_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(((Button)sender).Name.Substring(17));
                string sendData = CreateCommaSeparatedRegisterConnection(index);
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void btnModbusRegisterConnectionReadMemory_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(((Button)sender).Name.Substring(16)) - 1;
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*REGSET";
                    port.WriteLine("*readdeviceMasterRegisterConnection," + index + "#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private string CreateCommaSeparatedRegisterConnection(int index)
        {
            Control[] c;
            StringBuilder sb = new StringBuilder();
            sb.Append("*REGSET, ,");
            sb.Append(index.ToString());
            sb.Append(",");
            sb.Append(cmbMasterSlaveIndex.SelectedIndex.ToString());
            sb.Append(",");
            c = groupBox19.Controls.Find("txtMasterRegIndex" + index.ToString(), true);
            sb.Append(((TextBox)c[0]).Text.Trim());
            sb.Append(",");
            c = groupBox19.Controls.Find("txtMasterRegStartAddress" + index.ToString(), true);
            sb.Append(((TextBox)c[0]).Text.Trim());
            sb.Append(",");
            c = groupBox19.Controls.Find("txtMasterName" + index.ToString(), true);
            sb.Append(((TextBox)c[0]).Text.Trim());
            sb.Append(",");
            c = groupBox19.Controls.Find("cmbMasterActivation" + index.ToString(), true);
            sb.Append(((ComboBox)c[0]).SelectedIndex.ToString());
            sb.Append(",");
            c = groupBox19.Controls.Find("cmbMasterDataType" + index.ToString(), true);
            sb.Append(((ComboBox)c[0]).SelectedIndex.ToString());
            sb.Append(",");
            c = groupBox19.Controls.Find("cmbMasterFunctionCode" + index.ToString(), true);
            sb.Append(((ComboBox)c[0]).SelectedIndex.ToString());
            sb.Append(",");
            c = groupBox19.Controls.Find("cmbMasterByteOrder" + index.ToString(), true);
            sb.Append(((ComboBox)c[0]).SelectedIndex.ToString());
            sb.Append(",");
            c = groupBox19.Controls.Find("txtMasterScaleFactor" + index.ToString(), true);
            sb.Append(((TextBox)c[0]).Text.Trim());
            sb.Append("#");
            return sb.ToString();
        }
        private void setFieldsModbusRegisterConnection(object details)
        {
            try
            {
                Control[] c;
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                int index = Convert.ToInt32(fields[0]);
                cmbMasterSlaveIndex.SelectedIndex = Convert.ToInt32(fields[1]);
                c = groupBox19.Controls.Find("txtMasterRegIndex" + index.ToString(), true);
                ((TextBox)c[0]).Text = fields[2];
                c = groupBox19.Controls.Find("txtMasterRegStartAddress" + index.ToString(), true);
                ((TextBox)c[0]).Text = fields[3];
                c = groupBox19.Controls.Find("txtMasterName" + index.ToString(), true);
                ((TextBox)c[0]).Text = fields[4];
                c = groupBox19.Controls.Find("cmbMasterActivation" + index.ToString(), true);
                ((ComboBox)c[0]).SelectedIndex = Convert.ToInt32(fields[5]);
                c = groupBox19.Controls.Find("cmbMasterDataType" + index.ToString(), true);
                ((ComboBox)c[0]).SelectedIndex = Convert.ToInt32(fields[6]);
                c = groupBox19.Controls.Find("cmbMasterFunctionCode" + index.ToString(), true);
                ((ComboBox)c[0]).SelectedIndex = Convert.ToInt32(fields[7]);
                c = groupBox19.Controls.Find("cmbMasterByteOrder" + index.ToString(), true);
                ((ComboBox)c[0]).SelectedIndex = Convert.ToInt32(fields[8]);
                c = groupBox19.Controls.Find("txtMasterScaleFactor" + index.ToString(), true);
                ((TextBox)c[0]).Text = fields[9];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void btnMasterReadAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    port.WriteLine("*readdeviceMasterRegisterConnectionAll#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void btnMasterWriteAll_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                pbProcessing.Value = 0;
                lblProgressPercent.Text = "0%";
                for (int i = 1; i < 21; i++)
                {
                    sb.Append(CreateCommaSeparatedRegisterConnection(i));
                    if (i < 20)
                        sb.Append("|");
                    pbProcessing.Value = 4 * i;
                    lblProgressPercent.Text = (4 * i).ToString();
                }
                if (IsConnected == 0)
                {
                    MessageBox.Show("No port is connected.", "Warning");
                    return;
                }
                IsReadyToSend = true;
                uploadSettings(sb.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void setFieldsModbusRegisterConnectionAll(object details)
        {
            try
            {
                if (!details.ToString().Contains("|"))
                    return;
                string[] allDetails = details.ToString().Split("|");
                for (int i = 0; i < allDetails.Length; i++)
                {
                    setFieldsModbusRegisterConnection(allDetails[i]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        #endregion
        #region Status
        private void btnStatusGSMRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*GSMST";
                    port.WriteLine("*readdeviceGSMStatus#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }

        private void btnIOStatusRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (!port.IsOpen)
                {
                    port.Open();
                }
                if (port.IsOpen)
                {
                    dataRead = "*INPUTPARA";
                    port.WriteLine("*readdeviceIOStatus#");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void setFieldsGsmStatus(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                int signalStrength = Convert.ToInt32(fields[0]);
                int noOfBar = signalStrength / 6;
                int remainder = signalStrength % 6;
                if (remainder >= 3)
                {
                    noOfBar = noOfBar + 1;
                }
                lblSignal1.BackColor = Color.White;
                lblSignal2.BackColor = Color.White;
                lblSignal3.BackColor = Color.White;
                lblSignal4.BackColor = Color.White;
                lblSignal5.BackColor = Color.White;
                Control[] c;
                for (int i = 1; i <= noOfBar; i++)
                {
                    c = groupBox26.Controls.Find("lblSignal" + i.ToString(), true);
                    ((Label)c[0]).BackColor = Color.Green;
                }
                lblStatusProvider.Text = fields[1];
                lblStatusDate.Text = fields[2];
                lblStatusTime.Text = fields[3];
                lblStatusSim.Text = fields[4] == "0" ? "Error" : "Ok";
                lblStatusGprs.Text = fields[5] == "0" ? "Error" : "Ok";
                lblStatusIMEI.Text = fields[6];
                if (fields[7] == "0")
                    lblStatusProtocol.Text = "TCP-NONTRANSPARENT";
                else if (fields[7] == "1")
                    lblStatusProtocol.Text = "TCP-TRANSPARENT";
                else if (fields[7] == "2")
                    lblStatusProtocol.Text = "MQTT";
                else if (fields[7] == "3")
                    lblStatusProtocol.Text = "HTTP";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void setFieldsIOStatus(object details)
        {
            try
            {
                details = details.ToString().Substring(details.ToString().IndexOf(" ") + 2, details.ToString().Length - 1 - (details.ToString().IndexOf(" ") + 2));
                string[] fields = details.ToString().Split(",");
                lblStatusSystemVolt.Text = fields[0];
                string digitalInput = fields[1];
                setDigitalInput(digitalInput);
                string digitalOutput = fields[2];
                setDigitalOutput(digitalOutput);
                lblAna1.Text = fields[3];
                lblAna2.Text = fields[4];
                lblAna3.Text = fields[5];
                lblAna4.Text = fields[6];
                lblAna5.Text = fields[7];
                lblAna6.Text = fields[8];
                lblAna7.Text = fields[9];
                lblAna8.Text = fields[10];
                lblTot1.Text = fields[11];
                lblTot2.Text = fields[12];
                lblTot3.Text = fields[13];
                lblTot4.Text = fields[14];
                lblTot5.Text = fields[15];
                lblTot6.Text = fields[16];
                lblTot7.Text = fields[17];
                lblTot8.Text = fields[18];
                lblStatusPulseCounter1.Text = fields[19];
                lblStatusPulseCounter2.Text = fields[20];
                lblStatusPulseCounter3.Text = fields[21];
                lblStatusPulseCounter4.Text = fields[22];
                lblStatusPulseCounter5.Text = fields[23];
                lblStatusPulseCounter6.Text = fields[24];
                lblStatusPulseCounter7.Text = fields[25];
                lblStatusPulseCounter8.Text = fields[26];
                lblStatusDatalogSec.Text = fields[27];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString(), "Error");
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        private void setDigitalInput(string value)
        {
            Control[] c;
            for (int i = 1; i <= value.Length; i++)
            {
                c = groupBox27.Controls.Find("pbDigiIn" + i.ToString(), true);
                if (value.Substring(i - 1, 1) == "0")
                {
                    ((PictureBox)c[0]).BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\BulbOff.png");
                }
                else
                {
                    ((PictureBox)c[0]).BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\BulbOn.png");
                }
            }
        }
        private void setDigitalOutput(string value)
        {
            Control[] c;
            for (int i = 1; i <= value.Length; i++)
            {
                c = groupBox27.Controls.Find("pbDigiOut" + i.ToString(), true);
                if (value.Substring(i - 1, 1) == "0")
                {
                    ((PictureBox)c[0]).BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\BulbOff.png");
                }
                else
                {
                    ((PictureBox)c[0]).BackgroundImage = Image.FromFile(Application.StartupPath + "Icons\\BulbOn.png");
                }
            }
        }
        #endregion
        #region Console
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtConsoleInput.Text = string.Empty;
            txtSystemLog.Text = string.Empty;
        }
        private void btnLogMonitorOff_Click(object sender, EventArgs e)
        {
            if (btnLogMonitorOff.Text == "Log Monitor Off")
            {
                btnLogMonitorOff.Text = "Log Monitor On";
                logMonitor = false;
            }
            else
            {
                btnLogMonitorOff.Text = "Log Monitor Off";
                logMonitor = true;
            }
        }
        private void btnConsoleSend_Click(object sender, EventArgs e)
        {
            try
            {
                string sendData = txtConsoleInput.Text;
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
                if (errorCount > errorLimit)
                    CloseConnection();
            }
        }
        #endregion
    }
}
