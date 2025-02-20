using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using EasyModbus;
using static EasyModbus.ModbusClient;

namespace RobotControl
{
    public partial class Form1 : Form
    {
        private ModbusClient modbusClient = new EasyModbus.ModbusClient();

        //bool isMoving = false;


        public Form1()
        {
            InitializeComponent();

            //皮肤设置
            //Sunisoft.IrisSkin.SkinEngine skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            //skinEngine1.SkinFile = Application.StartupPath + @"\Skins\DiamondGreen.ssk";
            //skinEngine1.SkinFile = Application.StartupPath + @"\Skins\mp10.ssk";
            //skinEngine1.SkinFile = Application.StartupPath + @"\Skins\OneCyan.ssk";
            //skinEngine1.SkinFile = Application.StartupPath + @"\Skins\RealOne.ssk";
            //skinEngine1.SkinFile = Application.StartupPath + @"\Skins\Wave.ssk";

            //skinEngine1.SkinFile = Application.StartupPath + @"\Skins\mp10.ssk";
            //btnRight.BackgroundImage = Properties.Resources.Right;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //var controls = FindControls<GroupBox>(this);
                //// 遍历
                //foreach (GroupBox control in controls)
                //{
                //    if (control != groupBox1)
                //        control.Enabled = false;
                //}

                try
                {
                    AgvCommunication.SerialPort = IniHelper.getString("Config", "Modbus", "SerialPort");
                    AgvCommunication.Baudrate = Convert.ToInt32(IniHelper.getString("Config", "Modbus", "Baudrate"));
                    AgvCommunication.DataBits = Convert.ToInt32(IniHelper.getString("Config", "Modbus", "DataBits")) + 5;
                    AgvCommunication.Parity = (Parity)Convert.ToInt32(IniHelper.getString("Config", "Modbus", "Parity"));
                    AgvCommunication.StopBits = (StopBits)Convert.ToInt32(IniHelper.getString("Config", "Modbus", "StopBits"));
                }
                catch (Exception)
                {
                    MessageBox.Show("AGV配置文件通讯参数部分配置错误！");
                    Application.Exit();
                }

                try
                {
                    AgvGeneral.PortNum = Convert.ToInt32(IniHelper.getString("Config", "Agv", "PortNum"));
                    AgvGeneral.Speed = Convert.ToInt32(Convert.ToDecimal(IniHelper.getString("Config", "Agv", "Speed")) * Convert.ToDecimal(IniHelper.getString("Config", "Agv", "SpeedPercent")) /100);
                }
                catch (Exception)
                {
                    MessageBox.Show("AGV配置文件通用参数部分配置错误！");
                    Application.Exit();
                }

                try
                {
                    AgvGeneral.WheelDip = new byte[4] { Convert.ToByte(IniHelper.getString("Config", "Wheel", "LeftForwardDip")),
                                                Convert.ToByte(IniHelper.getString("Config", "Wheel", "RightForwardDip")),
                                                Convert.ToByte(IniHelper.getString("Config", "Wheel", "LeftBackDip")),
                                                Convert.ToByte(IniHelper.getString("Config", "Wheel", "RightBackDip"))};

                    AgvGeneral.WheelDirection = new int[4] { Convert.ToInt32(IniHelper.getString("Config", "Wheel", "LeftForwardDirection")),
                                                Convert.ToInt32(IniHelper.getString("Config", "Wheel", "RightForwardDirection")),
                                                Convert.ToInt32(IniHelper.getString("Config", "Wheel", "LeftBackDirection")),
                                                Convert.ToInt32(IniHelper.getString("Config", "Wheel", "RightBackDirection"))};
                }
                catch (Exception)
                {
                    MessageBox.Show("AGV配置文件驱动器参数部分配置错误！");
                    Application.Exit();
                }

                //modbusClient.ReceiveDataChanged += new EasyModbus.ModbusClient.ReceiveDataChangedHandler(ModbusReceiveData);
                //modbusClient.SendDataChanged += new EasyModbus.ModbusClient.SendDataChangedHandler(ModbusSendData);
                modbusClient.ConnectedChanged += new EasyModbus.ModbusClient.ConnectedChangedHandler(ModbusConnectedChanged);

                //dataGridView1.Rows.Add();
                //dataGridView1.Rows.Add();
                //dataGridView1.Rows.Add();

                //dataGridView1.Rows[0].Cells["Index"].Value = "左前轮";
                //dataGridView1.Rows[1].Cells["Index"].Value = "右前轮";
                //dataGridView1.Rows[2].Cells["Index"].Value = "左后轮";
                //dataGridView1.Rows[3].Cells["Index"].Value = "右后轮";

                //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                //cboMode.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("启动时报错：" + ex.Message);
            }
        }

        private void ModbusReceiveData(object sender)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
            }));
        }


        void ModbusSendData(object sender)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.sendData).Replace("-", " "), Color.Green);
                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + BitConverter.ToString(modbusClient.sendData).Replace("-", " "), Color.Green);
            }));

        }

        private void ModbusConnectedChanged(object sender)
        {
            if (modbusClient.Connected)
            {
                try
                {
                    AgvModeSet(3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("AGV连接失败：" + ex.Message);
                    lblStatus.Text = "AGV连接失败：" + ex.Message;
                }
                //btnRobotStatus.BackColor = Color.Lime;
                //btnRobotStatus.Text = "已连接";
                pictureBox1.Image = Properties.Resources.Connect;
                AgvCommunication.AgvStatus = true;
                lblStatus.Text = "AGV已连接";
                gbAgv.Enabled = true;
                
            }
            else
            {
                //btnRobotStatus.Text = "已断开";
                //btnRobotStatus.BackColor = Color.DarkGray;
                pictureBox1.Image = Properties.Resources.DisConnect;
                AgvCommunication.AgvStatus = false;
                lblStatus.Text = "Modbus已断开";
                gbAgv.Enabled = false;
            }
        }


        private void DisconnectRobot()
        {
            try
            {
                AgvCommunication.AgvStatus = false;
                //btnRobotStatus.Text = "已断开";
                //btnRobotStatus.BackColor = Color.DarkGray;
                pictureBox1.Image = Properties.Resources.DisConnect;

                var controls = FindControls<GroupBox>(this);
                // 遍历
                foreach (GroupBox control in controls)
                {
                    if (control != groupBox1)
                        control.Enabled = false;
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        //UIint -》bool数组；
        private bool[] UInt64ToBoolArr(UInt64 dataSource)
        {
            bool[] bitArr = new bool[32];
            for (int i = 0; i < bitArr.Length; i++)
            {
                UInt64 temp = (UInt64)(1 << i);
                bitArr[i] = (dataSource & temp) == temp ? true : false;
            }
            return bitArr;
        }


        private void showTime_Tick(object sender, EventArgs e)
        {
            //if (rcvConvertEnd)
            //{
            //    WindowShow();
            //}
        }


        private void btnAgvConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (AgvCommunication.AgvStatus)
                {
                    MessageBox.Show("AGV已连接！");
                    return;
                }

                modbusClient.SerialPort = AgvCommunication.SerialPort;

                ////modbusClient.UnitIdentifier = byte.Parse(txtSlaveAddressInput.Text);
                modbusClient.Baudrate = AgvCommunication.Baudrate;
                modbusClient.Parity = AgvCommunication.Parity;
                modbusClient.StopBits = AgvCommunication.StopBits;

                modbusClient.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modbus连接失败：" + ex.Message);
            }

        }

        /// <summary>
        /// 遍历所有控件树递,归所有子控件，查找所有包含指定控件类型的控件，并返回所有包含指定控件类型的控件的列表。调用该方法，获取所有按钮控件：var buttons = FindControls<Button>(this);
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="control"></param>
        /// <returns></returns>
        public static List<T> FindControls<T>(Control control) where T : Control
        {
            List<T> controls = new List<T>();

            // 遍历控件集合
            foreach (Control ctrl in control.Controls)
            {
                // 判断控件类型是否为指定类型
                if (ctrl is T tControl)
                {
                    // 添加符合条件的控件
                    controls.Add(tControl);
                }

                // 如果控件还有子控件，则递归调用此方法
                if (ctrl.HasChildren)
                {
                    controls.AddRange(FindControls<T>(ctrl));
                }
            }

            // 返回符合条件的控件列表
            return controls;
        }


        private void 退出程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 连接参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CommConfig window = new CommConfig();
                window.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgvDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("AGV断开失败：" + ex.Message);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                int[] result;

                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "开始查询");
                //有效工作模式
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3600, 1);
                    //dataGridView1.Rows[i].Cells["EffectiveMode"].Value = result[0];
                }

                //状态字
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3200, 1);
                    //dataGridView1.Rows[i].Cells["StateWord"].Value = result[0].ToString("X").PadLeft(4, '0');
                }

                //实际位置
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3700, 2);
                    //dataGridView1.Rows[i].Cells["RealPosition"].Value = ModbusClient.ConvertRegistersToInt(result);
                }

                //实际速度
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3B00, 2);
                    //dataGridView1.Rows[i].Cells["RealSpeed"].Value = AgvGeneral.Dec2Rpm(ModbusClient.ConvertRegistersToInt(result));

                }

                //实际电流
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3E00, 1);
                    //dataGridView1.Rows[i].Cells["RealCurrent"].Value = AgvGeneral.Dec2Arms(result[0]);
                    //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                }

                //目标速度
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x6F00, 2);
                    //dataGridView1.Rows[i].Cells["TargetSpeed"].Value = AgvGeneral.Dec2Rpm(ModbusClient.ConvertRegistersToInt(result));
                    //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                }

                //工作模式
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3500, 1);
                    //dataGridView1.Rows[i].Cells["Mode"].Value = result[0];
                }

                //控制字
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3100, 1);
                    //dataGridView1.Rows[i].Cells["ControlWord"].Value = result[0].ToString("X");
                }

                //速度位置方向控制
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x4700, 1);
                    //dataGridView1.Rows[i].Cells["SpeedDirection"].Value = result[0];
                }

                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束查询");
            }
            catch (Exception ex)
            {
                MessageBox.Show("查询数据失败：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int f = 100;
            int r = AgvGeneral.Rpm2Dec(f);
            //f = ModbusClient.ConvertRegistersToFloat(new int[] { 0x0008, 0x5555 });
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mode">|1:位置模式|3:速度模式</param>
        private void AgvModeSet(int mode)
        {
            //工作模式
            for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
            {
                modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                modbusClient.WriteSingleRegister(0x3500, mode);
            }
        }


        private void AgvSpeedSet()
        {
            try
            {
                //btn.Enabled = false;

                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "开始设定速度");

                int speed = Convert.ToInt32(AgvGeneral.Speed * numSpeed.Value / 100);
                
                AgvGeneral.Speed = Convert.ToInt32(Convert.ToDouble(IniHelper.getString("Config", "Agv", "Speed")) * Convert.ToDouble(numSpeed.Value) / 100.00); ;

                ////目标速度
                //for (byte i = 0; i <= General.PortNum - 1; i++)
                //{
                //    modbusClient.UnitIdentifier = General.WheelDip[i];
                //    //modbusClient.WriteSingleRegister(0x6F00, General.Rpm2Dec(speed));
                //    modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(General.Rpm2Dec(speed)));
                //}

                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
            }
            catch (Exception ex)
            {
                MessageBox.Show("速度设定失败：" + ex.Message);
            }
        }

        private void MoveAGV(byte id, bool isForward)
        {

            modbusClient.UnitIdentifier = AgvGeneral.WheelDip[id];

            if (isForward)
            {
                modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpm2Dec(AgvGeneral.Speed * AgvGeneral.WheelDirection[id])));
            }
            else
            {
                modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpm2Dec(AgvGeneral.Speed * AgvGeneral.WheelDirection[id] * -1)));
            }

            modbusClient.WriteSingleRegister(0x3100, 0xF);
        }

        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向前运动";
                //btn.Enabled = false;
                //isMoving = true;

                MoveAGV(0, true);
                MoveAGV(1, true);
                MoveAGV(2, true);
                MoveAGV(3, true);
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向后运动";
                //btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(1, false);
                MoveAGV(2, false);
                MoveAGV(3, false);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向左运动";
                //btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(1, true);
                MoveAGV(2, true);
                MoveAGV(3, false);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向右运动";
                //btn.Enabled = false;

                MoveAGV(0, true);
                MoveAGV(1, false);
                MoveAGV(2, false);
                MoveAGV(3, true);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnClockWise_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV顺时针运动";
                //btn.Enabled = false;

                MoveAGV(0, true);
                MoveAGV(1, false);
                MoveAGV(2, true);
                MoveAGV(3, false);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnCounterClockWise_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV逆时针运动";
                //btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(1, true);
                MoveAGV(2, false);
                MoveAGV(3, true);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnLeftForward_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向左前运动";
                //btn.Enabled = false;

                MoveAGV(1, true);
                MoveAGV(2, true);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnRightForward_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向右前运动";
                //btn.Enabled = false;

                MoveAGV(0, true);
                MoveAGV(3, true);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnLeftBack_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向左后运动";
                //btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(3, false);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnRightBack_MouseDown(object sender, MouseEventArgs e)
        {
            //Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "AGV向右后运动";
                //btn.Enabled = false;

                MoveAGV(1, false);
                MoveAGV(2, false);

                //isMoving = true;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "移动报错：" + ex.Message;
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
        }

        private void btnStopAll_MouseUp(object sender, MouseEventArgs e)
        {
            
            try
            {
                lblStatus.Text = "停止运动";
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    modbusClient.WriteSingleRegister(0x3100, 0x6);
                }
                //if (isMoving)
                //{
                //    lblStatus.Text = "结束运动";
                //    isMoving = false;
                //    for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                //    {
                //        modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                //        modbusClient.WriteSingleRegister(0x3100, 0x6);
                //    }
                //}
            }
            catch (Exception ex)
            {
                lblStatus.Text = "制动报错：" + ex.Message;
            }
        }

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                lblStatus.Text = "急停";
                //for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                //{
                //    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                //    modbusClient.WriteSingleRegister(0x3100, 0x6);
                //}
                //if (isMoving)
                //{
                //    btn.Enabled = false;

                //    for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                //    {
                //        modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                //        modbusClient.WriteSingleRegister(0x3100, 0x6);
                //    }
                //    isMoving = false;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("停止失败：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "按下按钮。。。。";
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            lblStatus.Text = "放开按钮。。。。";
        }

        private void btnArmConnect_Click(object sender, EventArgs e)
        {
            string port = "6001";
            string ip = "192.168.1.11";
            //robot = comboBox1.SelectedItem.ToString();

            //mRobot = new NbtRobot(IP, port, comboBox1.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //private void btnStopAll_MouseLeave(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        return;
        //        if (isMoving)
        //        {
        //            Button btn = (Button)sender;
        //            for (byte i = 0; i <= General.PortNum - 1; i++)
        //            {
        //                modbusClient.UnitIdentifier = General.WheelDip[i];
        //                modbusClient.WriteSingleRegister(0x3100, 0x6);
        //            }
        //            isMoving = false;
        //            btn.Enabled = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("停止失败：" + ex.Message);
        //    }
        //}




        //private void btnRight_Paint(object sender, PaintEventArgs e)
        //{
        //    Button button = sender as Button;
        //    Graphics g = e.Graphics;

        //    // 箭头的坐标点
        //    Point[] arrowPoints = new Point[]
        //    {
        //        new Point(5, button.Height / 2),
        //        new Point(button.Width - 5, 5),
        //        new Point(button.Width - 5, button.Height - 5)
        //    };

        //    // 绘制箭头
        //    g.FillPolygon(Brushes.Black, arrowPoints);
        //}
    }
}
