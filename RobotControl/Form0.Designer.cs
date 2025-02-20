
namespace RobotControl
{
    partial class Form0
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.连接设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showTime = new System.Windows.Forms.Timer(this.components);
            this.txtComm = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnForward3 = new System.Windows.Forms.Button();
            this.btnForward2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnForward1 = new System.Windows.Forms.Button();
            this.btnSpeedSet = new System.Windows.Forms.Button();
            this.btnModeSet = new System.Windows.Forms.Button();
            this.btnStop3 = new System.Windows.Forms.Button();
            this.btnStop2 = new System.Windows.Forms.Button();
            this.btnStop1 = new System.Windows.Forms.Button();
            this.btnStop0 = new System.Windows.Forms.Button();
            this.btnBack3 = new System.Windows.Forms.Button();
            this.btnBack2 = new System.Windows.Forms.Button();
            this.btnBack1 = new System.Windows.Forms.Button();
            this.btnBack0 = new System.Windows.Forms.Button();
            this.btnForward0 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClockWise = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCounterClockWise = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRightBack = new System.Windows.Forms.Button();
            this.btnRightForward = new System.Windows.Forms.Button();
            this.btnLeftBack = new System.Windows.Forms.Button();
            this.btnLeftForward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectiveMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealCurrent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TargetSpeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Acceleration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ControlWord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SpeedDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1435, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接设置ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.操作ToolStripMenuItem.Text = "程序";
            // 
            // 连接设置ToolStripMenuItem
            // 
            this.连接设置ToolStripMenuItem.Name = "连接设置ToolStripMenuItem";
            this.连接设置ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.连接设置ToolStripMenuItem.Text = "通讯参数设置";
            this.连接设置ToolStripMenuItem.Click += new System.EventHandler(this.连接参数设置ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 272);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::RobotControl.Properties.Resources.DisConnect;
            this.pictureBox1.Location = new System.Drawing.Point(112, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(134, 99);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(84, 37);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "一键断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(20, 157);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(84, 37);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(20, 99);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(84, 37);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "一键连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接状态";
            // 
            // showTime
            // 
            this.showTime.Enabled = true;
            this.showTime.Interval = 200;
            this.showTime.Tick += new System.EventHandler(this.showTime_Tick);
            // 
            // txtComm
            // 
            this.txtComm.Location = new System.Drawing.Point(960, 54);
            this.txtComm.Name = "txtComm";
            this.txtComm.ReadOnly = true;
            this.txtComm.Size = new System.Drawing.Size(463, 458);
            this.txtComm.TabIndex = 3;
            this.txtComm.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtSpeed);
            this.groupBox3.Controls.Add(this.cboMode);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnStopAll);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnForward3);
            this.groupBox3.Controls.Add(this.btnForward2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnForward1);
            this.groupBox3.Controls.Add(this.btnSpeedSet);
            this.groupBox3.Controls.Add(this.btnModeSet);
            this.groupBox3.Controls.Add(this.btnStop3);
            this.groupBox3.Controls.Add(this.btnStop2);
            this.groupBox3.Controls.Add(this.btnStop1);
            this.groupBox3.Controls.Add(this.btnStop0);
            this.groupBox3.Controls.Add(this.btnBack3);
            this.groupBox3.Controls.Add(this.btnBack2);
            this.groupBox3.Controls.Add(this.btnBack1);
            this.groupBox3.Controls.Add(this.btnBack0);
            this.groupBox3.Controls.Add(this.btnForward0);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Controls.Add(this.btnClockWise);
            this.groupBox3.Controls.Add(this.btnRight);
            this.groupBox3.Controls.Add(this.btnCounterClockWise);
            this.groupBox3.Controls.Add(this.btnLeft);
            this.groupBox3.Controls.Add(this.btnRightBack);
            this.groupBox3.Controls.Add(this.btnRightForward);
            this.groupBox3.Controls.Add(this.btnLeftBack);
            this.groupBox3.Controls.Add(this.btnLeftForward);
            this.groupBox3.Controls.Add(this.btnForward);
            this.groupBox3.Controls.Add(this.btnQuery);
            this.groupBox3.Location = new System.Drawing.Point(264, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(678, 472);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操作";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(406, 79);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 25);
            this.txtSpeed.TabIndex = 4;
            this.txtSpeed.Text = "1000";
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "速度模式",
            "位置模式"});
            this.cboMode.Location = new System.Drawing.Point(157, 79);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(121, 23);
            this.cboMode.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(114, 24);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 37);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "右后";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "左后";
            // 
            // btnStopAll
            // 
            this.btnStopAll.Font = new System.Drawing.Font("宋体", 12F);
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(507, 225);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(100, 70);
            this.btnStopAll.TabIndex = 2;
            this.btnStopAll.Text = "急停";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "右前";
            // 
            // btnForward3
            // 
            this.btnForward3.Location = new System.Drawing.Point(361, 171);
            this.btnForward3.Name = "btnForward3";
            this.btnForward3.Size = new System.Drawing.Size(62, 37);
            this.btnForward3.TabIndex = 2;
            this.btnForward3.Text = "前进";
            this.btnForward3.UseVisualStyleBackColor = true;
            this.btnForward3.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnForward2
            // 
            this.btnForward2.Location = new System.Drawing.Point(64, 171);
            this.btnForward2.Name = "btnForward2";
            this.btnForward2.Size = new System.Drawing.Size(62, 37);
            this.btnForward2.TabIndex = 2;
            this.btnForward2.Text = "前进";
            this.btnForward2.UseVisualStyleBackColor = true;
            this.btnForward2.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "左前";
            // 
            // btnForward1
            // 
            this.btnForward1.Location = new System.Drawing.Point(361, 122);
            this.btnForward1.Name = "btnForward1";
            this.btnForward1.Size = new System.Drawing.Size(62, 37);
            this.btnForward1.TabIndex = 2;
            this.btnForward1.Text = "前进";
            this.btnForward1.UseVisualStyleBackColor = true;
            this.btnForward1.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnSpeedSet
            // 
            this.btnSpeedSet.Location = new System.Drawing.Point(307, 72);
            this.btnSpeedSet.Name = "btnSpeedSet";
            this.btnSpeedSet.Size = new System.Drawing.Size(84, 37);
            this.btnSpeedSet.TabIndex = 2;
            this.btnSpeedSet.Text = "速度设定";
            this.btnSpeedSet.UseVisualStyleBackColor = true;
            this.btnSpeedSet.Click += new System.EventHandler(this.btnSpeedSet_Click);
            // 
            // btnModeSet
            // 
            this.btnModeSet.Location = new System.Drawing.Point(24, 72);
            this.btnModeSet.Name = "btnModeSet";
            this.btnModeSet.Size = new System.Drawing.Size(126, 37);
            this.btnModeSet.TabIndex = 2;
            this.btnModeSet.Text = "工作模式设定";
            this.btnModeSet.UseVisualStyleBackColor = true;
            this.btnModeSet.Click += new System.EventHandler(this.btnModeSet_Click);
            // 
            // btnStop3
            // 
            this.btnStop3.Location = new System.Drawing.Point(497, 171);
            this.btnStop3.Name = "btnStop3";
            this.btnStop3.Size = new System.Drawing.Size(62, 37);
            this.btnStop3.TabIndex = 2;
            this.btnStop3.Text = "停止";
            this.btnStop3.UseVisualStyleBackColor = true;
            this.btnStop3.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop2
            // 
            this.btnStop2.Location = new System.Drawing.Point(204, 171);
            this.btnStop2.Name = "btnStop2";
            this.btnStop2.Size = new System.Drawing.Size(62, 37);
            this.btnStop2.TabIndex = 2;
            this.btnStop2.Text = "停止";
            this.btnStop2.UseVisualStyleBackColor = true;
            this.btnStop2.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop1
            // 
            this.btnStop1.Location = new System.Drawing.Point(497, 122);
            this.btnStop1.Name = "btnStop1";
            this.btnStop1.Size = new System.Drawing.Size(62, 37);
            this.btnStop1.TabIndex = 2;
            this.btnStop1.Text = "停止";
            this.btnStop1.UseVisualStyleBackColor = true;
            this.btnStop1.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStop0
            // 
            this.btnStop0.Location = new System.Drawing.Point(204, 122);
            this.btnStop0.Name = "btnStop0";
            this.btnStop0.Size = new System.Drawing.Size(62, 37);
            this.btnStop0.TabIndex = 2;
            this.btnStop0.Text = "停止";
            this.btnStop0.UseVisualStyleBackColor = true;
            this.btnStop0.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBack3
            // 
            this.btnBack3.Location = new System.Drawing.Point(429, 171);
            this.btnBack3.Name = "btnBack3";
            this.btnBack3.Size = new System.Drawing.Size(62, 37);
            this.btnBack3.TabIndex = 2;
            this.btnBack3.Text = "后退";
            this.btnBack3.UseVisualStyleBackColor = true;
            this.btnBack3.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.Location = new System.Drawing.Point(136, 171);
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Size = new System.Drawing.Size(62, 37);
            this.btnBack2.TabIndex = 2;
            this.btnBack2.Text = "后退";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnBack1
            // 
            this.btnBack1.Location = new System.Drawing.Point(429, 122);
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Size = new System.Drawing.Size(62, 37);
            this.btnBack1.TabIndex = 2;
            this.btnBack1.Text = "后退";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnBack0
            // 
            this.btnBack0.Location = new System.Drawing.Point(136, 122);
            this.btnBack0.Name = "btnBack0";
            this.btnBack0.Size = new System.Drawing.Size(62, 37);
            this.btnBack0.TabIndex = 2;
            this.btnBack0.Text = "后退";
            this.btnBack0.UseVisualStyleBackColor = true;
            this.btnBack0.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnForward0
            // 
            this.btnForward0.Location = new System.Drawing.Point(64, 122);
            this.btnForward0.Name = "btnForward0";
            this.btnForward0.Size = new System.Drawing.Size(62, 37);
            this.btnForward0.TabIndex = 2;
            this.btnForward0.Text = "前进";
            this.btnForward0.UseVisualStyleBackColor = true;
            this.btnForward0.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(262, 392);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 70);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "后";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseDown);
            this.btnBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnClockWise
            // 
            this.btnClockWise.Location = new System.Drawing.Point(507, 310);
            this.btnClockWise.Name = "btnClockWise";
            this.btnClockWise.Size = new System.Drawing.Size(100, 70);
            this.btnClockWise.TabIndex = 2;
            this.btnClockWise.Text = "顺时针";
            this.btnClockWise.UseVisualStyleBackColor = true;
            this.btnClockWise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClockWise_MouseDown);
            this.btnClockWise.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(386, 310);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 70);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnCounterClockWise
            // 
            this.btnCounterClockWise.Location = new System.Drawing.Point(24, 310);
            this.btnCounterClockWise.Name = "btnCounterClockWise";
            this.btnCounterClockWise.Size = new System.Drawing.Size(100, 70);
            this.btnCounterClockWise.TabIndex = 2;
            this.btnCounterClockWise.Text = "逆时针";
            this.btnCounterClockWise.UseVisualStyleBackColor = true;
            this.btnCounterClockWise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCounterClockWise_MouseDown);
            this.btnCounterClockWise.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(139, 310);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(100, 70);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "左";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnRightBack
            // 
            this.btnRightBack.Location = new System.Drawing.Point(386, 392);
            this.btnRightBack.Name = "btnRightBack";
            this.btnRightBack.Size = new System.Drawing.Size(100, 70);
            this.btnRightBack.TabIndex = 2;
            this.btnRightBack.Text = "右后";
            this.btnRightBack.UseVisualStyleBackColor = true;
            this.btnRightBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRightBack_MouseDown);
            this.btnRightBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnRightForward
            // 
            this.btnRightForward.Location = new System.Drawing.Point(386, 225);
            this.btnRightForward.Name = "btnRightForward";
            this.btnRightForward.Size = new System.Drawing.Size(100, 70);
            this.btnRightForward.TabIndex = 2;
            this.btnRightForward.Text = "右前";
            this.btnRightForward.UseVisualStyleBackColor = true;
            this.btnRightForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRightForward_MouseDown);
            this.btnRightForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnLeftBack
            // 
            this.btnLeftBack.Location = new System.Drawing.Point(139, 392);
            this.btnLeftBack.Name = "btnLeftBack";
            this.btnLeftBack.Size = new System.Drawing.Size(100, 70);
            this.btnLeftBack.TabIndex = 2;
            this.btnLeftBack.Text = "左后";
            this.btnLeftBack.UseVisualStyleBackColor = true;
            this.btnLeftBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeftBack_MouseDown);
            this.btnLeftBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnLeftForward
            // 
            this.btnLeftForward.Location = new System.Drawing.Point(139, 225);
            this.btnLeftForward.Name = "btnLeftForward";
            this.btnLeftForward.Size = new System.Drawing.Size(100, 70);
            this.btnLeftForward.TabIndex = 2;
            this.btnLeftForward.Text = "左前";
            this.btnLeftForward.UseVisualStyleBackColor = true;
            this.btnLeftForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeftForward_MouseDown);
            this.btnLeftForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(262, 225);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(100, 70);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "前";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            this.btnForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(24, 24);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(84, 37);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.EffectiveMode,
            this.StateWord,
            this.RealPosition,
            this.RealSpeed,
            this.RealCurrent,
            this.TargetSpeed,
            this.Acceleration,
            this.Mode,
            this.ControlWord,
            this.SpeedDirection});
            this.dataGridView1.Location = new System.Drawing.Point(12, 529);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1398, 171);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // Index
            // 
            this.Index.HeaderText = "位置";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 125;
            // 
            // EffectiveMode
            // 
            this.EffectiveMode.HeaderText = "有效工作模式";
            this.EffectiveMode.MinimumWidth = 6;
            this.EffectiveMode.Name = "EffectiveMode";
            this.EffectiveMode.ReadOnly = true;
            this.EffectiveMode.Width = 125;
            // 
            // StateWord
            // 
            this.StateWord.HeaderText = "状态字";
            this.StateWord.MinimumWidth = 6;
            this.StateWord.Name = "StateWord";
            this.StateWord.ReadOnly = true;
            this.StateWord.Width = 125;
            // 
            // RealPosition
            // 
            this.RealPosition.HeaderText = "实际位置";
            this.RealPosition.MinimumWidth = 6;
            this.RealPosition.Name = "RealPosition";
            this.RealPosition.ReadOnly = true;
            this.RealPosition.Width = 125;
            // 
            // RealSpeed
            // 
            this.RealSpeed.HeaderText = "实际速度";
            this.RealSpeed.MinimumWidth = 6;
            this.RealSpeed.Name = "RealSpeed";
            this.RealSpeed.ReadOnly = true;
            this.RealSpeed.Width = 125;
            // 
            // RealCurrent
            // 
            this.RealCurrent.HeaderText = "实际电流";
            this.RealCurrent.MinimumWidth = 6;
            this.RealCurrent.Name = "RealCurrent";
            this.RealCurrent.ReadOnly = true;
            this.RealCurrent.Width = 125;
            // 
            // TargetSpeed
            // 
            this.TargetSpeed.HeaderText = "目标速度";
            this.TargetSpeed.MinimumWidth = 6;
            this.TargetSpeed.Name = "TargetSpeed";
            this.TargetSpeed.ReadOnly = true;
            this.TargetSpeed.Width = 125;
            // 
            // Acceleration
            // 
            this.Acceleration.HeaderText = "加速度";
            this.Acceleration.MinimumWidth = 6;
            this.Acceleration.Name = "Acceleration";
            this.Acceleration.Width = 125;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "工作模式";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            this.Mode.Width = 125;
            // 
            // ControlWord
            // 
            this.ControlWord.HeaderText = "控制字";
            this.ControlWord.MinimumWidth = 6;
            this.ControlWord.Name = "ControlWord";
            this.ControlWord.ReadOnly = true;
            this.ControlWord.Width = 125;
            // 
            // SpeedDirection
            // 
            this.SpeedDirection.HeaderText = "速度位置方向控制";
            this.SpeedDirection.MinimumWidth = 6;
            this.SpeedDirection.Name = "SpeedDirection";
            this.SpeedDirection.ReadOnly = true;
            this.SpeedDirection.Width = 125;
            // 
            // Form0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 724);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtComm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form0";
            this.Text = "AGV运载小车控制系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Timer showTime;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接设置ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtComm;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnModeSet;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnForward3;
        private System.Windows.Forms.Button btnForward2;
        private System.Windows.Forms.Button btnForward1;
        private System.Windows.Forms.Button btnForward0;
        private System.Windows.Forms.Button btnStop0;
        private System.Windows.Forms.Button btnBack0;
        private System.Windows.Forms.Button btnStop3;
        private System.Windows.Forms.Button btnStop2;
        private System.Windows.Forms.Button btnStop1;
        private System.Windows.Forms.Button btnBack3;
        private System.Windows.Forms.Button btnBack2;
        private System.Windows.Forms.Button btnBack1;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button btnSpeedSet;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnClockWise;
        private System.Windows.Forms.Button btnCounterClockWise;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnLeftForward;
        private System.Windows.Forms.Button btnRightForward;
        private System.Windows.Forms.Button btnRightBack;
        private System.Windows.Forms.Button btnLeftBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectiveMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealCurrent;
        private System.Windows.Forms.DataGridViewTextBoxColumn TargetSpeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Acceleration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlWord;
        private System.Windows.Forms.DataGridViewTextBoxColumn SpeedDirection;
    }
}

