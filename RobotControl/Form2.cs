using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Form2 : Form
    {
        private ModbusClient modbusClient = new EasyModbus.ModbusClient();

        bool isMoving = false;


        public Form2()
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
                //foreach (GroupBox control in controls)
                //{
                //    if (control != groupBox1)
                //        control.Enabled = false;
                //}
                //txtComm.Enabled = false;

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
                    numSpeed.Value = AgvGeneral.Speed / 10;
                    AgvGeneral.Acceleration = Convert.ToInt32(IniHelper.getString("Config", "Agv", "Acceleration"));
                    AgvGeneral.Deceleration = Convert.ToInt32(IniHelper.getString("Config", "Agv", "Deceleration"));
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
                //btnRobotStatus.BackColor = Color.Lime;
                //btnRobotStatus.Text = "已连接";
                pictureBox1.Image = Properties.Resources.Connect;
                AgvCommunication.AgvStatus = true;
                notifybar.Text = "Modbus已连接！";

                var controls = FindControls<GroupBox>(this);
                // 遍历
                foreach (GroupBox control in controls)
                {
                    control.Enabled = true;
                }
                //txtComm.Enabled = true;
            }
            else
            {
                //btnRobotStatus.Text = "已断开";
                //btnRobotStatus.BackColor = Color.DarkGray;
                pictureBox1.Image = Properties.Resources.DisConnect;
                AgvCommunication.AgvStatus = false;
                notifybar.Text = "Modbus已断开！";

                var controls = FindControls<GroupBox>(this);
                //遍历
                foreach (GroupBox control in controls)
                {
                    control.Enabled = false;

                }
                //txtComm.Enabled = false;
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
                //foreach (GroupBox control in controls)
                //{
                //    if (control != groupBox1)
                //        control.Enabled = false;
                //}
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

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "开始查询";
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
                    //dataGridView1.Rows[i].Cells["RealSpeed"].Value = General.Dec2Rpm(ModbusClient.ConvertRegistersToInt(result));

                }

                //实际电流
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x3E00, 1);
                    //dataGridView1.Rows[i].Cells["RealCurrent"].Value = General.Dec2Arms(result[0]);
                    //txtComm.AppendTextColorful(BitConverter.ToString(modbusClient.receiveData).Replace("-", " "), Color.Red);
                }

                //目标速度
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    result = modbusClient.ReadHoldingRegisters(0x6F00, 2);
                    //dataGridView1.Rows[i].Cells["TargetSpeed"].Value = General.Dec2Rpm(ModbusClient.ConvertRegistersToInt(result));
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

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "结束查询";
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
            notifybar.Text = string.Empty;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int xWidth1 = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;//获取显示器屏幕宽度
            int yHeight1 = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;//高度
            MessageBox.Show(xWidth1 + "px * " + yHeight1 + "px\r\n" + Width + "px * " + Height + "px");
            //int f = 100;
            //int r = General.Rpm2Dec(f);
            //f = ModbusClient.ConvertRegistersToFloat(new int[] { 0x0008, 0x5555 });
        }


        private void ModeSe(int mode)
        {
            try
            {

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "开始设定工作模式";


                //工作模式
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    modbusClient.WriteSingleRegister(0x3500, mode);
                }

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定工作模式";
            }
            catch (Exception ex)
            {
                MessageBox.Show("工作模式设定失败：" + ex.Message);
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

                //int speed;
                //if (!int.TryParse(txtSpeed.Text, out speed))
                //{
                //    MessageBox.Show("数字格式输入有误");
                //    return;
                //}
                AgvGeneral.Speed = Convert.ToInt32(numSpeed.Value * 10);

                for (int i = 1; i <= 4; i++)
                {
                    //modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpm2Dec(AgvGeneral.Speed * AgvGeneral.WheelDirection[i])));
                    modbusClient.WriteMultipleRegisters(0x4B00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpms2Dec(AgvGeneral.Acceleration)));
                    modbusClient.WriteMultipleRegisters(0x4C00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpms2Dec(AgvGeneral.Deceleration)));
                }

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

        private void MoveAGVSetSpeed(bool f0, bool f1, bool f2, bool f3)
        {
            MoveAGVSetSpeed(0, f0);
            MoveAGVSetSpeed(1, f1);
            MoveAGVSetSpeed(2, f2);
            MoveAGVSetSpeed(3, f3);
        }

        private void MoveAGVSetSpeed(byte id, bool isForward)
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

            //modbusClient.WriteSingleRegister(0x3100, 0xF);
        }

        private void MoveAGVRun(byte id0, byte id1, byte id2, byte id3)
        {
            MoveAGVRun(id0);
            MoveAGVRun(id1);
            MoveAGVRun(id2);
            MoveAGVRun(id3);
        }

        private void MoveAGV(OrderedDictionary od)
        {
            foreach (DictionaryEntry entry in od)
            {
                modbusClient.UnitIdentifier = AgvGeneral.WheelDip[Convert.ToInt32(entry.Key)];
                if ((bool)entry.Value)
                {
                    modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpm2Dec(AgvGeneral.Speed * AgvGeneral.WheelDirection[Convert.ToInt32(entry.Key)])));
                }
                else
                {
                    modbusClient.WriteMultipleRegisters(0x6F00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpm2Dec(AgvGeneral.Speed * AgvGeneral.WheelDirection[Convert.ToInt32(entry.Key)] * -1)));
                }
                modbusClient.WriteMultipleRegisters(0x4B00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpms2Dec(AgvGeneral.Acceleration)));
                modbusClient.WriteMultipleRegisters(0x4C00, ModbusClient.ConvertIntToRegisters(AgvGeneral.Rpms2Dec(AgvGeneral.Deceleration)));
            }
            foreach (DictionaryEntry entry in od)
            {
                modbusClient.UnitIdentifier = AgvGeneral.WheelDip[Convert.ToInt32(entry.Key)];
                modbusClient.WriteSingleRegister(0x3100, 0xF);
            }
        }

        private void MoveAGVRun(byte id)
        {
            modbusClient.UnitIdentifier = AgvGeneral.WheelDip[id];
            modbusClient.WriteSingleRegister(0x3100, 0xF);
        }

        private void btnForward_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                //btn.Enabled = false;

                OrderedDictionary od = new OrderedDictionary();
                od.Add(0, true);
                od.Add(1, true);
                od.Add(2, true);
                od.Add(3, true);
                MoveAGV(od);

                //MoveAGVSetSpeed(true, true, true, true);

                //MoveAGVRun(0, 1, 2, 3);

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "向前移动";
                isMoving = true;
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

        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                //btn.Enabled = false;

                OrderedDictionary od = new OrderedDictionary();
                od.Add(0, false);
                od.Add(1, false);
                od.Add(2, false);
                od.Add(3, false);
                MoveAGV(od);

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "向后移动";
                isMoving = true;
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

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                //btn.Enabled = false;

                OrderedDictionary od = new OrderedDictionary();
                od.Add(0, false);
                od.Add(3, false);
                od.Add(1, true);
                od.Add(2, true);
                MoveAGV(od);

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "向左移动";
                isMoving = true;
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

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                //btn.Enabled = false;

                OrderedDictionary od = new OrderedDictionary();
                od.Add(0, true);
                od.Add(3, true);
                od.Add(1, false);
                od.Add(2, false);
                MoveAGV(od);

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "向右移动";
                isMoving = true;
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

        private void btnClockWise_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                //btn.Enabled = false;

                OrderedDictionary od = new OrderedDictionary();
                od.Add(0, true);
                od.Add(1, false);
                od.Add(2, true);
                od.Add(3, false);
                MoveAGV(od);

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "顺时针移动";
                isMoving = true;
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

        private void btnCounterClockWise_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                //btn.Enabled = false;

                OrderedDictionary od = new OrderedDictionary();
                od.Add(0, false);
                od.Add(1, true);
                od.Add(2, false);
                od.Add(3, true);
                MoveAGV(od);

                notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "逆时针移动";
                isMoving = true;
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

        //private void btnLeftForward_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    try
        //    {
        //        //btn.Enabled = false;

        //        OrderedDictionary od = new OrderedDictionary();
        //        od.Add(1, true);
        //        od.Add(2, true);
        //        MoveAGV(od);

        //        notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "左前移动";
        //        isMoving = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("移动报错：" + ex.Message);
        //    }
        //    //finally
        //    //{
        //    //    btn.Enabled = true;
        //    //}
        //}

        //private void btnRightForward_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    try
        //    {
        //        //btn.Enabled = false;

        //        OrderedDictionary od = new OrderedDictionary();
        //        od.Add(0, true);
        //        od.Add(3, true);
        //        MoveAGV(od);

        //        notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "右前移动";
        //        isMoving = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("移动报错：" + ex.Message);
        //    }
        //    //finally
        //    //{
        //    //    btn.Enabled = true;
        //    //}
        //}

        //private void btnLeftBack_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    try
        //    {
        //        //btn.Enabled = false;

        //        OrderedDictionary od = new OrderedDictionary();
        //        od.Add(0, false);
        //        od.Add(3, false);
        //        MoveAGV(od);

        //        notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "左后移动";
        //        isMoving = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("移动报错：" + ex.Message);
        //    }
        //    //finally
        //    //{
        //    //    btn.Enabled = true;
        //    //}
        //}

        //private void btnRightBack_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Button btn = (Button)sender;
        //    try
        //    {
        //        //btn.Enabled = false;

        //        OrderedDictionary od = new OrderedDictionary();
        //        od.Add(1, false);
        //        od.Add(2, false);
        //        MoveAGV(od);

        //        notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "右后移动";
        //        isMoving = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("移动报错：" + ex.Message);
        //    }
        //    //finally
        //    //{
        //    //    btn.Enabled = true;
        //    //}
        //}

        private void btnStopAll_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                if (isMoving)
                {
                    //btn.Enabled = false;

                    for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                    {
                        modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                        modbusClient.WriteSingleRegister(0x3100, 0x6);
                    }
                    notifybar.Text = DateTime.Now.ToString("HH:mm:ss.fff:") + "停止移动";
                    isMoving = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("停止失败：" + ex.Message);
            }
            //finally
            //{
            //    btn.Enabled = true;
            //}
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

        private void btnStopAll_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnModeSet_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            try
            {
                btn.Enabled = false;

                //int[] result;

                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "开始设定工作模式");

                int mode = 3;
                //switch (cboMode.SelectedIndex)
                //{
                //    case 0:
                //        mode = 3;
                //        break;
                //    case 1:
                //        mode = 1;
                //        break;
                //    default:
                //        return;
                //}

                //工作模式
                for (byte i = 0; i <= AgvGeneral.PortNum - 1; i++)
                {
                    modbusClient.UnitIdentifier = AgvGeneral.WheelDip[i];
                    modbusClient.WriteSingleRegister(0x3500, mode);
                }

                //txtComm.AppendTextColorful(DateTime.Now.ToString("HH:mm:ss.fff:") + "结束设定工作模式");
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

        private void 通讯参数设置ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 退出程序ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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
