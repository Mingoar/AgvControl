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
    public static class ArmCommunication
    {
        static ArmCommunication()
        {
            ArmStatus = false;
        }
        public static string IP { get; set; }
        public static int Port { get; set; }
        public static int RobotName { get; set; }
        public static bool ArmStatus { get; set; }

    }
}
