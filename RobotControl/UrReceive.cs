using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotControl
{
    public static class UrReceive
    {
        public static double controllerStartedTime { get; set; }

        //关节目标位置；
        public static double TargetPositionJ1 { get; set; }
        public static double TargetPositionJ2 { get; set; }
        public static double TargetPositionJ3 { get; set; }
        public static double TargetPositionJ4 { get; set; }
        public static double TargetPositionJ5 { get; set; }
        public static double TargetPositionJ6 { get; set; }
       
        //关节目标速度；
        public static double TargetVelocitiesJ1 { get; set; }
        public static double TargetVelocitiesJ2 { get; set; }
        public static double TargetVelocitiesJ3 { get; set; }
        public static double TargetVelocitiesJ4 { get; set; }
        public static double TargetVelocitiesJ5 { get; set; }
        public static double TargetVelocitiesJ6 { get; set; }
       
        //关节目标加速度
        public static double TargetAccJ1 { get; set; }
        public static double TargetAccJ2 { get; set; }
        public static double TargetAccJ3 { get; set; }
        public static double TargetAccJ4 { get; set; }
        public static double TargetAccJ5 { get; set; }
        public static double TargetAccJ6 { get; set; }

        //关节目标电流
        public static double TargetCurrentsJ1 { get; set; }
        public static double TargetCurrentsJ2 { get; set; }
        public static double TargetCurrentsJ3 { get; set; }
        public static double TargetCurrentsJ4 { get; set; }
        public static double TargetCurrentsJ5 { get; set; }
        public static double TargetCurrentsJ6 { get; set; }

        //关节目标扭矩
        public static double TargetMomentJ1 { get; set; }
        public static double TargetMomentJ2 { get; set; }
        public static double TargetMomentJ3 { get; set; }
        public static double TargetMomentJ4 { get; set; }
        public static double TargetMomentJ5 { get; set; }
        public static double TargetMomentJ6 { get; set; }
        
        //关节实际位置
        public static double ActualPositionJ1 { get; set; }
        public static double ActualPositionJ2 { get; set; }
        public static double ActualPositionJ3 { get; set; }
        public static double ActualPositionJ4 { get; set; }
        public static double ActualPositionJ5 { get; set; }
        public static double ActualPositionJ6 { get; set; }

        //关节实际速度；
        public static double ActualSpeedJ1 { get; set; }
        public static double ActualSpeedJ2 { get; set; }
        public static double ActualSpeedJ3 { get; set; }
        public static double ActualSpeedJ4 { get; set; }
        public static double ActualSpeedJ5 { get; set; }
        public static double ActualSpeedJ6 { get; set; }

        //关节实际电流
        public static double ActualCurrentsJ1 { get; set; }
        public static double ActualCurrentsJ2 { get; set; }
        public static double ActualCurrentsJ3 { get; set; }
        public static double ActualCurrentsJ4 { get; set; }
        public static double ActualCurrentsJ5 { get; set; }
        public static double ActualCurrentsJ6 { get; set; }

        //关节控制电路
        public static double ControlCurrentsJ1 { get; set; }
        public static double ControlCurrentsJ2 { get; set; }
        public static double ControlCurrentsJ3 { get; set; }
        public static double ControlCurrentsJ4 { get; set; }
        public static double ControlCurrentsJ5 { get; set; }
        public static double ControlCurrentsJ6 { get; set; }

        //工具在世界坐标系下的实际位置；
        public static double ToolActualPositionX { get; set; }
        public static double ToolActualPositionY { get; set; }
        public static double ToolActualPositionZ { get; set; }
        public static double ToolActualPositionRx { get; set; }
        public static double ToolActualPositionRy { get; set; }
        public static double ToolActualPositionRz { get; set; }
        public static double ToolActualPositionRpyRx { get; set; }
        public static double ToolActualPositionRpyRy { get; set; }
        public static double ToolActualPositionRpyRz { get; set; }

        //TCP在笛卡尔坐标系下的速度
        public static double TcpActualSpeedX { get; set; }
        public static double TcpActualSpeedY { get; set; }
        public static double TcpActualSpeedZ { get; set; }
        public static double TcpActualSpeedRx { get; set; }
        public static double TcpActualSpeedRy { get; set; }
        public static double TcpActualSpeedRz { get; set; }

        //TCP上受到的力
        public static double TcpForceX { get; set; }
        public static double TcpForceY { get; set; }
        public static double TcpForceZ { get; set; }
        public static double TcpForceRx { get; set; }
        public static double TcpForceRy { get; set; }
        public static double TcpForceRz { get; set; }

        //工具在笛卡尔坐标系下的目标位置；
        public static double ToolTargetPositionX { get; set; }
        public static double ToolTargetPositionY { get; set; }
        public static double ToolTargetPositionZ { get; set; }
        public static double ToolTargetPositionRx { get; set; }
        public static double ToolTargetPositionRy { get; set; }
        public static double ToolTargetPositionRz { get; set; }

        //坐标系下的TCP目标速度；
        public static double TcpTargetSpeedX { get; set; }
        public static double TcpTargetSpeedY { get; set; }
        public static double TcpTargetSpeedZ { get; set; }
        public static double TcpTargetSpeedRx { get; set; }
        public static double TcpTargetSpeedRy { get; set; }
        public static double TcpTargetSpeedRz { get; set; }

        //DI
        public static ulong DigitalInputBits { get; set; }

        //关节温度；
        public static double MotorTemperaJ1 { get; set; }
        public static double MotorTemperaJ2 { get; set; }
        public static double MotorTemperaJ3 { get; set; }
        public static double MotorTemperaJ4 { get; set; }
        public static double MotorTemperaJ5 { get; set; }
        public static double MotorTemperaJ6 { get; set; }

        //控制器线程执行时间
        public static double ControllerThreadTime { get; set; }
        //机器人模式
        public static double RobotMode { get; set; }

        //关节控制模式
        public static double JointModeJ1 { get; set; }
        public static double JointModeJ2 { get; set; }
        public static double JointModeJ3 { get; set; }
        public static double JointModeJ4 { get; set; }
        public static double JointModeJ5 { get; set; }
        public static double JointModeJ6 { get; set; }

        //安全模式
        public static double SafetyMode { get; set; }
        //速度缩放
        public static double SpeedScaling { get; set; }
        //主板电压
        public static double Vmain { get; set; }
        //机器人电压
        public static double VRobot { get; set; }
        //主板电流 
        public static double IRobot { get; set; }

        //实际关节电压
        public static double ActualVoltagetsJ1 { get; set; }
        public static double ActualVoltagetsJ2 { get; set; }
        public static double ActualVoltagetsJ3 { get; set; }
        public static double ActualVoltagetsJ4 { get; set; }
        public static double ActualVoltagetsJ5 { get; set; }
        public static double ActualVoltagetsJ6 { get; set; }

        //数字量输出；
        public static ulong DigitalOutputBits { get; set; }
    }
}
