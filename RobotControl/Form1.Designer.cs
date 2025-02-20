
namespace RobotControl
{
    partial class Form1
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
            this.机械臂通讯设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnArmDisconnect = new System.Windows.Forms.Button();
            this.btnAgvDisconnect = new System.Windows.Forms.Button();
            this.btnArmConnect = new System.Windows.Forms.Button();
            this.btnAgvConnect = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showTime = new System.Windows.Forms.Timer(this.components);
            this.gbAgv = new System.Windows.Forms.GroupBox();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClockWise = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCounterClockWise = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRightBack = new System.Windows.Forms.Button();
            this.btnRightForward = new System.Windows.Forms.Button();
            this.btnLeftBack = new System.Windows.Forms.Button();
            this.btnLeftForward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.strip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbAgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1258, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.连接设置ToolStripMenuItem,
            this.机械臂通讯设置ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.操作ToolStripMenuItem.Text = "程序";
            // 
            // 连接设置ToolStripMenuItem
            // 
            this.连接设置ToolStripMenuItem.Name = "连接设置ToolStripMenuItem";
            this.连接设置ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.连接设置ToolStripMenuItem.Text = "AGV通讯设置";
            this.连接设置ToolStripMenuItem.Click += new System.EventHandler(this.连接参数设置ToolStripMenuItem_Click);
            // 
            // 机械臂通讯设置ToolStripMenuItem
            // 
            this.机械臂通讯设置ToolStripMenuItem.Name = "机械臂通讯设置ToolStripMenuItem";
            this.机械臂通讯设置ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.机械臂通讯设置ToolStripMenuItem.Text = "机械臂通讯设置";
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnArmDisconnect);
            this.groupBox1.Controls.Add(this.btnAgvDisconnect);
            this.groupBox1.Controls.Add(this.btnArmConnect);
            this.groupBox1.Controls.Add(this.btnAgvConnect);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通讯";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::RobotControl.Properties.Resources.DisConnect;
            this.pictureBox2.Location = new System.Drawing.Point(89, 83);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::RobotControl.Properties.Resources.DisConnect;
            this.pictureBox1.Location = new System.Drawing.Point(89, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnArmDisconnect
            // 
            this.btnArmDisconnect.Location = new System.Drawing.Point(295, 83);
            this.btnArmDisconnect.Name = "btnArmDisconnect";
            this.btnArmDisconnect.Size = new System.Drawing.Size(84, 37);
            this.btnArmDisconnect.TabIndex = 2;
            this.btnArmDisconnect.Text = "断开";
            this.btnArmDisconnect.UseVisualStyleBackColor = true;
            // 
            // btnAgvDisconnect
            // 
            this.btnAgvDisconnect.Location = new System.Drawing.Point(295, 24);
            this.btnAgvDisconnect.Name = "btnAgvDisconnect";
            this.btnAgvDisconnect.Size = new System.Drawing.Size(84, 37);
            this.btnAgvDisconnect.TabIndex = 2;
            this.btnAgvDisconnect.Text = "断开";
            this.btnAgvDisconnect.UseVisualStyleBackColor = true;
            this.btnAgvDisconnect.Click += new System.EventHandler(this.btnAgvDisconnect_Click);
            // 
            // btnArmConnect
            // 
            this.btnArmConnect.Location = new System.Drawing.Point(192, 82);
            this.btnArmConnect.Name = "btnArmConnect";
            this.btnArmConnect.Size = new System.Drawing.Size(84, 37);
            this.btnArmConnect.TabIndex = 2;
            this.btnArmConnect.Text = "连接";
            this.btnArmConnect.UseVisualStyleBackColor = true;
            this.btnArmConnect.Click += new System.EventHandler(this.btnArmConnect_Click);
            // 
            // btnAgvConnect
            // 
            this.btnAgvConnect.Location = new System.Drawing.Point(192, 24);
            this.btnAgvConnect.Name = "btnAgvConnect";
            this.btnAgvConnect.Size = new System.Drawing.Size(84, 37);
            this.btnAgvConnect.TabIndex = 2;
            this.btnAgvConnect.Text = "连接";
            this.btnAgvConnect.UseVisualStyleBackColor = true;
            this.btnAgvConnect.Click += new System.EventHandler(this.btnAgvConnect_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "机械臂";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "AGV";
            // 
            // showTime
            // 
            this.showTime.Enabled = true;
            this.showTime.Interval = 200;
            this.showTime.Tick += new System.EventHandler(this.showTime_Tick);
            // 
            // gbAgv
            // 
            this.gbAgv.Controls.Add(this.numSpeed);
            this.gbAgv.Controls.Add(this.btnStopAll);
            this.gbAgv.Controls.Add(this.btnBack);
            this.gbAgv.Controls.Add(this.btnClockWise);
            this.gbAgv.Controls.Add(this.btnRight);
            this.gbAgv.Controls.Add(this.label1);
            this.gbAgv.Controls.Add(this.btnCounterClockWise);
            this.gbAgv.Controls.Add(this.btnLeft);
            this.gbAgv.Controls.Add(this.btnRightBack);
            this.gbAgv.Controls.Add(this.btnRightForward);
            this.gbAgv.Controls.Add(this.btnLeftBack);
            this.gbAgv.Controls.Add(this.btnLeftForward);
            this.gbAgv.Controls.Add(this.btnForward);
            this.gbAgv.Location = new System.Drawing.Point(484, 54);
            this.gbAgv.Name = "gbAgv";
            this.gbAgv.Size = new System.Drawing.Size(678, 363);
            this.gbAgv.TabIndex = 4;
            this.gbAgv.TabStop = false;
            this.gbAgv.Text = "操作";
            // 
            // numSpeed
            // 
            this.numSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSpeed.Location = new System.Drawing.Point(203, 33);
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(75, 25);
            this.numSpeed.TabIndex = 5;
            this.numSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // btnStopAll
            // 
            this.btnStopAll.Font = new System.Drawing.Font("宋体", 12F);
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(522, 86);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(100, 70);
            this.btnStopAll.TabIndex = 2;
            this.btnStopAll.Text = "急停";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(277, 253);
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
            this.btnClockWise.Location = new System.Drawing.Point(522, 171);
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
            this.btnRight.Location = new System.Drawing.Point(401, 171);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(100, 70);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "AGV速度";
            // 
            // btnCounterClockWise
            // 
            this.btnCounterClockWise.Location = new System.Drawing.Point(39, 171);
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
            this.btnLeft.Location = new System.Drawing.Point(154, 171);
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
            this.btnRightBack.Location = new System.Drawing.Point(401, 253);
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
            this.btnRightForward.Location = new System.Drawing.Point(401, 86);
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
            this.btnLeftBack.Location = new System.Drawing.Point(154, 253);
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
            this.btnLeftForward.Location = new System.Drawing.Point(154, 86);
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
            this.btnForward.Location = new System.Drawing.Point(277, 86);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(100, 70);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "前";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            this.btnForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // strip
            // 
            this.strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.strip.Location = new System.Drawing.Point(0, 727);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(1258, 22);
            this.strip.TabIndex = 7;
            this.strip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 749);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.gbAgv);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AGV运载小车控制系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbAgv.ResumeLayout(false);
            this.gbAgv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgvConnect;
        private System.Windows.Forms.Button btnAgvDisconnect;
        private System.Windows.Forms.Timer showTime;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 连接设置ToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbAgv;
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnArmConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnArmDisconnect;
        private System.Windows.Forms.ToolStripMenuItem 机械臂通讯设置ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip strip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button button1;
    }
}

