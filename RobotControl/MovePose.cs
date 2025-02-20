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
    public partial class MovePose : Form
    {
        public MovePose()
        {
            InitializeComponent();
        }

        private void MovePose_Load(object sender, EventArgs e)
        {
            try
            {
                txtJ1.Text = UrReceive.ActualPositionJ1.ToString("0.00");
                txtJ2.Text = UrReceive.ActualPositionJ2.ToString("0.00");
                txtJ3.Text = UrReceive.ActualPositionJ3.ToString("0.00");
                txtJ4.Text = UrReceive.ActualPositionJ4.ToString("0.00");
                txtJ5.Text = UrReceive.ActualPositionJ5.ToString("0.00");
                txtJ6.Text = UrReceive.ActualPositionJ6.ToString("0.00");
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
