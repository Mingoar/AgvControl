using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControl
{
    public partial class MoveLoc : Form
    {
        public MoveLoc()
        {
            InitializeComponent();
        }

        private void MoveLoc_Load(object sender, EventArgs e)
        {
            try
            {
                txtX.Text = UrReceive.ToolActualPositionX.ToString("0.00");
                txtY.Text = UrReceive.ToolActualPositionY.ToString("0.00");
                txtZ.Text = UrReceive.ToolActualPositionZ.ToString("0.00");
                txtRx.Text = UrReceive.ToolActualPositionRpyRx.ToString("0.00");
                txtRy.Text = UrReceive.ToolActualPositionRpyRy.ToString("0.00");
                txtRz.Text = UrReceive.ToolActualPositionRpyRz.ToString("0.00");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
