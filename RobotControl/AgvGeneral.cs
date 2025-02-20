using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControl
{
    public static class AgvGeneral
    {
        public static int Rpm2Dec(int rpm)
        {
            return Convert.ToInt32(((double)rpm * 512 * 10000 / 1875));
        }

        public static int Dec2Rpm(int dec)
        {
            return Convert.ToInt32((double)dec * 1875 / 512 / 10000);
        }

        public static int Rpms2Dec(int rpms)
        {
            return Convert.ToInt32(((double)rpms * 65536 * 10000 / 4000000));
        }

        public static int Dec2Rpms(int dec)
        {
            return Convert.ToInt32((double)dec * 4000000 / 65536 / 10000);
        }

        public static int Arms2Dec(int arms)
        {
            return Convert.ToInt32(2048 / (48 / 1.414) * arms);
        }

        public static double Dec2Arms(int dec)
        {
            return Math.Round(dec / (2048 / (48 / 1.414)), 2);
        }
        public static int Speed { get; set; }

        public static int SpeedPercent { get; set; }

        public static int Acceleration { get; set; }

        public static int Deceleration { get; set; }
        


        public static int PortNum { get; set; }

        public static byte[] WheelDip { get; set; }

        public static int[] WheelDirection { get; set; }
    }
}
