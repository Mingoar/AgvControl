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
    public partial class Form0 : Form
    {
        private ModbusClient modbusClient = new EasyModbus.ModbusClient();

        bool isMoving = false;


        public Form0()
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
                var controls = FindControls<GroupBox>(this);
                // 遍历
                foreach (GroupBox control in controls)
                {
                    if (control != groupBox1)
                        control.Enabled = false;
                }
                txtComm.Enabled = false;

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
                    MessageBox.Show("配置文件通讯参数部分配置错误！");
                    Application.Exit();
                }

                try
                {
                    AgvGeneral.PortNum = Convert.ToInt32(IniHelper.getString("Config", "Agv", "PortNum"));
                    AgvGeneral.Speed = Convert.ToInt32(IniHelper.getString("Config", "Agv", "Speed"));
                }
                catch (Exception)
                {
                    MessageBox.Show("配置文件通用参数部分配置错误！");
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
                    MessageBox.Show("配置文件驱动器参数部分配置错误！");
                    Application.Exit();
                }

                //modbusClient.ReceiveDataChanged += new EasyModbus.ModbusClient.ReceiveDataChangedHandler(ModbusReceiveData);
                //modbusClient.SendDataChanged += new EasyModbus.ModbusClient.SendDataChangedHandler(ModbusSendData);
                modbusClient.ConnectedChanged += new EasyModbus.ModbusClient.ConnectedChangedHandler(ModbusConnectedChanged);

                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();
                dataGridView1.Rows.Add();

                dataGridView1.Rows[0].Cells["Index"].Value = "左前轮";
                dataGridView1.Rows[1].Cells["Index"].Value = "右前轮";
                dataGridView1.Rows[2].Cells["Index"].Value = "左后轮";
                dataGridView1.Rows[3].Cells["Index"].Value = "右后轮";

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                cboMode.SelectedIndex = 0;
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
                txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
            }));
        }


        void ModbusSendData(object sender)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.sendData).Replace("-", " "), Color.Green);
                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + BitConverter.ToString(modbusClient.sendData).Replace("-", " "), Color.Green);
            }));

        }

        private void ModbusConnectedChanged(object sender)
        {
            if (modbusClient.Connected)
            {
                //btnRobotStatus.BackColor = Color.Lime;
                //btnRobotStatus.Text = "已连接";
                pictureBox1.Image = Properties.Resources.Connect;
                AgvCommunication.AgvStatus = true;
                txtComm.AppendTextColorful("Modbus已连接！");

                var controls = FindControls<GroupBox>(this);
                // 遍历
                foreach (GroupBox control in controls)
                {
                    control.Enabled = true;
                }
                txtComm.Enabled = true;
            }
            else
            {
                //btnRobotStatus.Text = "已断开";
                //btnRobotStatus.BackColor = Color.DarkGray;
                pictureBox1.Image = Properties.Resources.DisConnect;
                AgvCommunication.AgvStatus = false;
                txtComm.AppendTextColorful("Modbus已断开！");

                var controls = FindControls<GroupBox>(this);
                // 遍历
                foreach (GroupBox control in controls)
                {
                    if (control != groupBox1)
                        control.Enabled = false;
                }
                txtComm.Enabled = false;
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


        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (AgvCommunication.AgvStatus)
                {
                    MessageBox.Show("Modbus已连接！");
                    return;
                }

                //modbusClient.SerialPort = AgvCommunication.SerialPort;

                //modbusClient.Baudrate = AgvCommunication.Baudrate;
                //modbusClient.Parity = AgvCommunication.Parity;
                //modbusClient.StopBits = AgvCommunication.StopBits;

                modbusClient.IPAddress = "192.168.1.12";
                modbusClient.Port = 502;
                modbusClient.SerialPort = null;

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

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                modbusClient.Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Modbus断开失败：" + ex.Message);
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                int[] result;

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "开始查询");
                //有效工作模式
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3600, 1);
                    dataGridView1.Rows[i].Cells["EffectiveMode"].Value = result[0];
                }

                //状态字
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3200, 1);
                    dataGridView1.Rows[i].Cells["StateWord"].Value = result[0].ToString("X").PadLeft(4, '0');
                }

                //实际位置
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3700, 2);
                    dataGridView1.Rows[i].Cells["RealPosition"].Value = ModbusClient.ConvertRegistersToInt(result);
                }

                //实际速度
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3B00, 2);
                    dataGridView1.Rows[i].Cells["RealSpeed"].Value = AgvGeneral.Dec2Rpm(ModbusClient.ConvertRegistersToInt(result));
                }

                //实际电流
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3E00, 1);
                    dataGridView1.Rows[i].Cells["RealCurrent"].Value = AgvGeneral.Dec2Arms(result[0]);
                    //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                }

                //目标速度
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x6F00, 2);
                    dataGridView1.Rows[i].Cells["TargetSpeed"].Value = AgvGeneral.Dec2Rpm(ModbusClient.ConvertRegistersToInt(result));
                    //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                }

                //加速度
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x4B00, 2);
                    dataGridView1.Rows[i].Cells["Acceleration"].Value = AgvGeneral.Dec2Rpms(ModbusClient.ConvertRegistersToInt(result));
                    //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                }

                //工作模式
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3500, 1);
                    dataGridView1.Rows[i].Cells["Mode"].Value = result[0];
                }

                //控制字
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3100, 1);
                    dataGridView1.Rows[i].Cells["ControlWord"].Value = result[0].ToString("X");
                }

                //速度位置方向控制
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x4700, 1);
                    dataGridView1.Rows[i].Cells["SpeedDirection"].Value = result[0];
                }

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束查询");
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtComm.Clear();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int f = 100;
            int r = AgvGeneral.Rpm2Dec(f);
            //f = ModbusClient.ConvertRegistersToFloat(new int[] { 0x0008, 0x5555 });
        }

        private void btnModeSet_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                int[] result;

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "开始设定工作模式");

                int mode = 0;
                switch (cboMode.SelectedIndex)
                {
                    case 0:
                        mode = 3;
                        break;
                    case 1:
                        mode = 1;
                        break;
                    default:
                        return;
                }

                //工作模式
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    modbusClient.WriteSingleRegister(0x3500, mode);
                }

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定工作模式");
            }
            catch (Exception ex)
            {
                MessageBox.Show("工作模式设定失败：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                byte id = Convert.ToByte(Regex.Replace(btn.Name, @"[^\d.\d]", ""));
                modbusClient.UnitIdentifier = AgvGeneral.WheelDip[id];

                if (btn.Name.Contains("Forward"))
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[id];
                    modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpm2Dec(AgvGeneral.Speed * AgvGeneral.WheelDirection[id])));
                }
                else
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[id];
                    modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpm2Dec(AgvGeneral.Speed * AgvGeneral.WheelDirection[id] * -1)));
                }

                modbusClient.WriteSingleRegister(0x3100, 0xF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动失败：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                byte i = Convert.ToByte(Regex.Replace(btn.Name, @"[^\d.\d]", ""));
                modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                modbusClient.WriteSingleRegister(0x3100, 0x6);
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

        private void btnSpeedSet_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                //btn.Enabled = false;

                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "开始设定速度");

                int speed;
                if (!int.TryParse(txtSpeed.Text, out speed))
                {
                    MessageBox.Show("数字格式输入有误");
                    return;
                }
                AgvGeneral.Speed = speed;

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
            finally
            {
                btn.Enabled = true;
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
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, true);
                MoveAGV(1, true);
                MoveAGV(2, true);
                MoveAGV(3, true);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(1, false);
                MoveAGV(2, false);
                MoveAGV(3, false);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(1, true);
                MoveAGV(2, true);
                MoveAGV(3, false);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, true);
                MoveAGV(1, false);
                MoveAGV(2, false);
                MoveAGV(3, true);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnClockWise_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, true);
                MoveAGV(1, false);
                MoveAGV(2, true);
                MoveAGV(3, false);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnCounterClockWise_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(1, true);
                MoveAGV(2, false);
                MoveAGV(3, true);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnLeftForward_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(1, true);
                MoveAGV(2, true);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnRightForward_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, true);
                MoveAGV(3, true);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnLeftBack_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(0, false);
                MoveAGV(3, false);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnRightBack_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                MoveAGV(1, false);
                MoveAGV(2, false);

                txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定速度");
                isMoving = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("移动报错：" + ex.Message);
            }
            finally
            {
                btn.Enabled = true;
            }
        }

        private void btnStopAll_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                if (isMoving)
                {
                    btn.Enabled = false;

                    for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                    {
                        modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                        modbusClient.WriteSingleRegister(0x3100, 0x6);
                    }
                    isMoving = false;
                }
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

        private void btnStopAll_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                if (isMoving)
                {
                    btn.Enabled = false;

                    for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                    {
                        modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                        modbusClient.WriteSingleRegister(0x3100, 0x6);
                    }
                    isMoving = false;
                }
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

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            txtComm.Clear();
            txtComm.AppendTextColorful("按下按钮。。。。。");
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            txtComm.Clear();
            txtComm.AppendTextColorful("放开按钮。。。。。");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


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
