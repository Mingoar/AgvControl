using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace RobotControl
{
    public static class AgvCommunication
    {
        static AgvCommunication()
        {
            AgvStatus = false;
        }
        public static string SerialPort { get; set; }
        public static int Baudrate { get; set; }
        public static int DataBits { get; set; }
        public static Parity Parity { get; set; }
        public static StopBits StopBits { get; set; }
        public static bool AgvStatus { get; set; }

    }
}
