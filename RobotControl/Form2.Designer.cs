
namespace RobotControl
{
    partial class Form2
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClockWise = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnCounterClockWise = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnModeSet = new System.Windows.Forms.Button();
            this.btnSpeedSet = new System.Windows.Forms.Button();
            this.numSpeed = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notifybar = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.通讯参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出程序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisconnect.Location = new System.Drawing.Point(42, 296);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(150, 100);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("宋体", 16F);
            this.btnConnect.Location = new System.Drawing.Point(42, 151);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(150, 100);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.Location = new System.Drawing.Point(37, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "连接状态";
            // 
            // btnStopAll
            // 
            this.btnStopAll.Font = new System.Drawing.Font("宋体", 16F);
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(666, 218);
            this.btnStopAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(150, 100);
            this.btnStopAll.TabIndex = 2;
            this.btnStopAll.Text = "急停";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBack.Location = new System.Drawing.Point(269, 414);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 100);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "后";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseDown);
            this.btnBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnClockWise
            // 
            this.btnClockWise.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClockWise.Location = new System.Drawing.Point(462, 162);
            this.btnClockWise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClockWise.Name = "btnClockWise";
            this.btnClockWise.Size = new System.Drawing.Size(150, 100);
            this.btnClockWise.TabIndex = 2;
            this.btnClockWise.Text = "顺时针";
            this.btnClockWise.UseVisualStyleBackColor = true;
            this.btnClockWise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClockWise_MouseDown);
            this.btnClockWise.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRight.Location = new System.Drawing.Point(462, 285);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(150, 100);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "右";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRight_MouseDown);
            this.btnRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnCounterClockWise
            // 
            this.btnCounterClockWise.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCounterClockWise.Location = new System.Drawing.Point(52, 162);
            this.btnCounterClockWise.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCounterClockWise.Name = "btnCounterClockWise";
            this.btnCounterClockWise.Size = new System.Drawing.Size(150, 100);
            this.btnCounterClockWise.TabIndex = 2;
            this.btnCounterClockWise.Text = "逆时针";
            this.btnCounterClockWise.UseVisualStyleBackColor = true;
            this.btnCounterClockWise.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCounterClockWise_MouseDown);
            this.btnCounterClockWise.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLeft.Location = new System.Drawing.Point(52, 285);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(150, 100);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "左";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLeft_MouseDown);
            this.btnLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnForward
            // 
            this.btnForward.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForward.Location = new System.Drawing.Point(269, 163);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(150, 100);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = "前";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnForward_MouseDown);
            this.btnForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnStopAll_MouseUp);
            // 
            // btnModeSet
            // 
            this.btnModeSet.Font = new System.Drawing.Font("宋体", 16F);
            this.btnModeSet.Location = new System.Drawing.Point(52, 38);
            this.btnModeSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModeSet.Name = "btnModeSet";
            this.btnModeSet.Size = new System.Drawing.Size(150, 100);
            this.btnModeSet.TabIndex = 2;
            this.btnModeSet.Text = "初始化";
            this.btnModeSet.UseVisualStyleBackColor = true;
            this.btnModeSet.Click += new System.EventHandler(this.btnModeSet_Click);
            // 
            // btnSpeedSet
            // 
            this.btnSpeedSet.Font = new System.Drawing.Font("宋体", 16F);
            this.btnSpeedSet.Location = new System.Drawing.Point(269, 38);
            this.btnSpeedSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSpeedSet.Name = "btnSpeedSet";
            this.btnSpeedSet.Size = new System.Drawing.Size(150, 100);
            this.btnSpeedSet.TabIndex = 2;
            this.btnSpeedSet.Text = "速度设定";
            this.btnSpeedSet.UseVisualStyleBackColor = true;
            this.btnSpeedSet.Click += new System.EventHandler(this.btnSpeedSet_Click);
            // 
            // numSpeed
            // 
            this.numSpeed.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numSpeed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSpeed.Location = new System.Drawing.Point(480, 73);
            this.numSpeed.Name = "numSpeed";
            this.numSpeed.Size = new System.Drawing.Size(120, 38);
            this.numSpeed.TabIndex = 6;
            this.numSpeed.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numSpeed);
            this.groupBox1.Controls.Add(this.btnModeSet);
            this.groupBox1.Controls.Add(this.btnStopAll);
            this.groupBox1.Controls.Add(this.btnForward);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Controls.Add(this.btnClockWise);
            this.groupBox1.Controls.Add(this.btnSpeedSet);
            this.groupBox1.Controls.Add(this.btnCounterClockWise);
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(331, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(847, 530);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AGV操作";
            // 
            // notifybar
            // 
            this.notifybar.Name = "notifybar";
            this.notifybar.Size = new System.Drawing.Size(0, 16);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifybar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1198, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.程序ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1198, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 程序ToolStripMenuItem
            // 
            this.程序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.通讯参数设置ToolStripMenuItem,
            this.退出程序ToolStripMenuItem});
            this.程序ToolStripMenuItem.Name = "程序ToolStripMenuItem";
            this.程序ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.程序ToolStripMenuItem.Text = "程序";
            // 
            // 通讯参数设置ToolStripMenuItem
            // 
            this.通讯参数设置ToolStripMenuItem.Name = "通讯参数设置ToolStripMenuItem";
            this.通讯参数设置ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.通讯参数设置ToolStripMenuItem.Text = "通讯参数设置";
            this.通讯参数设置ToolStripMenuItem.Click += new System.EventHandler(this.通讯参数设置ToolStripMenuItem_Click);
            // 
            // 退出程序ToolStripMenuItem
            // 
            this.退出程序ToolStripMenuItem.Name = "退出程序ToolStripMenuItem";
            this.退出程序ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.退出程序ToolStripMenuItem.Text = "退出程序";
            this.退出程序ToolStripMenuItem.Click += new System.EventHandler(this.退出程序ToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::RobotControl.Properties.Resources.DisConnect;
            this.pictureBox1.Location = new System.Drawing.Point(163, 51);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "AGV运载小车控制系统 V1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSpeed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnClockWise;
        private System.Windows.Forms.Button btnCounterClockWise;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModeSet;
        private System.Windows.Forms.Button btnSpeedSet;
        private System.Windows.Forms.NumericUpDown numSpeed;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripStatusLabel notifybar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 程序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通讯参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出程序ToolStripMenuItem;
    }
}

