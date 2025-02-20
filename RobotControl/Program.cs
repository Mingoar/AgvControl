using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            int runMode = Convert.ToInt32(IniHelper.getString("Config", "General", "RunMode"));
            if (runMode == 0)
                Application.Run(new Form0());
            else if (runMode == 1)
                Application.Run(new Form1());
            else if (runMode == 2)
                Application.Run(new Form2());
            else if (runMode == 3)
                Application.Run(new Form2());

        }
    }
}
