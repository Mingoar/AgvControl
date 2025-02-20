using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControl
{
    public partial class CommConfig : Form
    {
        public CommConfig()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void CommConfig_Load(object sender, EventArgs e)
        {
            try
            {
                string serialPort = IniHelper.getString("Config", "Modbus", "SerialPort");
                string[] portNames = SerialPort.GetPortNames();
                for (int i = 0; i < portNames.Length; i++)
                {
                    cboSerialPort.Items.Add(portNames[i]);
                    if (portNames[i].Contains(serialPort))
                        cboSerialPort.SelectedIndex = i;
                }
                IniHelper.getString("Config", "Modbus", "BaudRate");

                cboBaudrate.SelectedItem = IniHelper.getString("Config", "Modbus", "Baudrate");
                cboDataBits.SelectedIndex = Convert.ToInt32(IniHelper.getString("Config", "Modbus", "DataBits"));
                cboParity.SelectedIndex = Convert.ToInt32(IniHelper.getString("Config", "Modbus", "Parity"));
                cboStopBits.SelectedIndex = Convert.ToInt32(IniHelper.getString("Config", "Modbus", "StopBits"));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                AgvCommunication.SerialPort = cboSerialPort.Text;
                AgvCommunication.Baudrate = Convert.ToInt32(cboBaudrate.Text);
                AgvCommunication.DataBits = cboDataBits.SelectedIndex;
                AgvCommunication.Parity = (Parity)cboParity.SelectedIndex;
                AgvCommunication.StopBits = (StopBits)cboStopBits.SelectedIndex;

                IniHelper.writeString("Config", "Modbus", "SerialPort", cboSerialPort.Text);
                IniHelper.writeString("Config", "Modbus", "Baudrate", cboBaudrate.Text);
                IniHelper.writeString("Config", "Modbus", "DataBits", cboDataBits.SelectedIndex.ToString());
                IniHelper.writeString("Config", "Modbus", "Parity", cboParity.SelectedIndex.ToString());
                IniHelper.writeString("Config", "Modbus", "StopBits", cboStopBits.SelectedIndex.ToString());

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string serialPort = IniHelper.getString("Config", "Modbus", "SerialPort");
            string[] portNames = SerialPort.GetPortNames();
            cboSerialPort.Items.Clear();
            for (int i = 0; i < portNames.Length; i++)
            {
                cboSerialPort.Items.Add(portNames[i]);
                if (portNames[i].Contains(serialPort))
                    cboSerialPort.SelectedIndex = i;
            }
        }
    }
}
