using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExtensionMethod
{  
    // P278 ExtensionMethod
    //class MainApp
    //{
    //    public static int Square(int myInt)
    //    {
    //        return myInt * myInt;
    //    }

    //    public static int Power(int myInt, int exponent)
    //    {
    //        int result = myInt;
    //        for (int i = 1; i < exponent; i++)
    //        {
    //            result = result * myInt;
    //        }

    //        return result;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine($"3^2 : {Square(3)}");
    //        Console.WriteLine($"3^4 : {Power(3,4)}");
    //        Console.WriteLine($"2^10 : {Power(2,10)}");
    //    }
    //}

    // P281 Structure
    //struct Point3D
    //{
    //    public int X;
    //    public int Y;
    //    public int Z;

    //    public Point3D(int X, int Y, int Z)
    //    {
    //        this.X = X;
    //        this.Y = Y;
    //        this.Z = Z;
    //    }

    //    public override string ToString() // System.Object형식의 ToString() 메서드를 오버라이딩
    //    {
    //        return string.Format($"{X}, {Y}, {Z}");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Point3D p3d1; // 선언만으로도 인스턴스가 생성
    //        p3d1.X = 10;
    //        p3d1.Y = 20;
    //        p3d1.Z = 40;

    //        Console.WriteLine(p3d1.ToString());

    //        Point3D p3d2 = new Point3D(100, 200, 300);
    //        Point3D p3d3 = p3d2;
    //        p3d3.Z = 400;

    //        Console.WriteLine(p3d2.ToString());
    //        Console.WriteLine(p3d3.ToString());
    //    }
    //}

    
    
    // P284 ReadonlyStruct
    //readonly struct RGBColor
    //{
    //    public readonly byte R;
    //    public readonly byte G;
    //    public readonly byte B;

    //    public RGBColor(byte r, byte g, byte b)
    //    {
    //        R = r;
    //        G = g;
    //        B = b;
    //    }
    //}
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        RGBColor Red = new RGBColor(255, 0, 0);
    //        //Red.G = 100; // 컴파일 에러

    //        RGBColor myColor = new RGBColor(Red.R, 100, Red.B);
    //    }
    //}



    //struct ACSetting
    //{
    //    public double currentInCelsius; // 현재 온도
    //    public double target; // 희망온도

    //    public readonly double GetFahrenheit()
    //    {
    //        target = currentInCelsius * 1.8 + 32;
    //        return target;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        ACSetting acs;
    //        acs.currentInCelsius = 25;
    //        acs.target = 25;

    //        Console.WriteLine($"{acs.GetFahrenheit()}");
    //        Console.WriteLine($"{acs.target}");
    //    }
    //}

    // P303 Interface
    //interface ILogger // 인터페이스 선언
    //{
    //    void WriteLog(string message); // 구현부만 있음
    //}

    //class consoleLogger : ILogger // 인터페이스를 상속하여 구현해줌
    //{
    //    public void WriteLog(string message)
    //    {
    //        Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
    //    }
    //}

    //class FileLogger : ILogger
    //{
    //    private StreamWriter writer;

    //    public FileLogger(string path)
    //    {
    //        writer = File.CreateText(path);
    //        writer.AutoFlush = true;
    //    }

    //    public void WriteLog(string message)
    //    {
    //        Console.WriteLine("{0} {1}", DateTime.Now.ToShortDateString(), message);
    //    }
    //}

    //class ClimateMonitor
    //{
    //    private ILogger logger;
    //    public ClimateMonitor(ILogger logger)
    //    {
    //        this.logger = logger;
    //    }

    //    public void start()
    //    {
    //        while(true)
    //        {
    //            Console.Write("온도를 입력해주세요 : ");
    //            string temperature = Console.ReadLine();
    //            if (temperature == "")
    //                break;

    //            logger.WriteLog("현재 온도 : " + temperature);
    //        }
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLogg.txt"));

    //        monitor.start();
    //    }
    //}


    // P307 
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger // 인터페이스에 인터페이스 상속
    {
        void WriteLog(string format, params Object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger // 상속받은 인페이스를 상속
    {
        // 인터페이스 둘다 구현해줌
        public void WriteLog(string message)
        {
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog(string format, params Object[] args)
        {
            String message = String.Format(format, args);
            Console.WriteLine("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2); // 순서대로 들어감 1
            logger.WriteLog("The world is not flat");   // 2
            
        }
    }
}
