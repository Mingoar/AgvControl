
namespace RobotControl
{
    partial class MovePose
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtJ1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJ2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJ3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJ4 = new System.Windows.Forms.TextBox();
            this.txtJ5 = new System.Windows.Forms.TextBox();
            this.txtJ6 = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "1轴";
            // 
            // txtJ1
            // 
            this.txtJ1.Location = new System.Drawing.Point(89, 37);
            this.txtJ1.Name = "txtJ1";
            this.txtJ1.Size = new System.Drawing.Size(100, 25);
            this.txtJ1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "2轴";
            // 
            // txtJ2
            // 
            this.txtJ2.Location = new System.Drawing.Point(89, 86);
            this.txtJ2.Name = "txtJ2";
            this.txtJ2.Size = new System.Drawing.Size(100, 25);
            this.txtJ2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "3轴";
            // 
            // txtJ3
            // 
            this.txtJ3.Location = new System.Drawing.Point(89, 136);
            this.txtJ3.Name = "txtJ3";
            this.txtJ3.Size = new System.Drawing.Size(100, 25);
            this.txtJ3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "4轴";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "5轴";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "6轴";
            // 
            // txtJ4
            // 
            this.txtJ4.Location = new System.Drawing.Point(284, 37);
            this.txtJ4.Name = "txtJ4";
            this.txtJ4.Size = new System.Drawing.Size(100, 25);
            this.txtJ4.TabIndex = 3;
            // 
            // txtJ5
            // 
            this.txtJ5.Location = new System.Drawing.Point(284, 86);
            this.txtJ5.Name = "txtJ5";
            this.txtJ5.Size = new System.Drawing.Size(100, 25);
            this.txtJ5.TabIndex = 3;
            // 
            // txtJ6
            // 
            this.txtJ6.Location = new System.Drawing.Point(284, 136);
            this.txtJ6.Name = "txtJ6";
            this.txtJ6.Size = new System.Drawing.Size(100, 25);
            this.txtJ6.TabIndex = 3;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(178, 196);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(84, 47);
            this.btnMove.TabIndex = 1;
            this.btnMove.Text = "移动";
            this.btnMove.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 264);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(84, 47);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MovePose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 323);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.txtJ6);
            this.Controls.Add(this.txtJ3);
            this.Controls.Add(this.txtJ5);
            this.Controls.Add(this.txtJ2);
            this.Controls.Add(this.txtJ4);
            this.Controls.Add(this.txtJ1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MovePose";
            this.Text = "MovePose";
            this.Load += new System.EventHandler(this.MovePose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJ1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJ2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJ3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJ4;
        private System.Windows.Forms.TextBox txtJ5;
        private System.Windows.Forms.TextBox txtJ6;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnClose;
    }
}