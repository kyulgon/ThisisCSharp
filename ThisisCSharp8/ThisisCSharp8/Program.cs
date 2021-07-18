using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Security.Permissions;

namespace ThisisCSharp8
{
    // P489
    //class Program
    //{
    //    delegate int Calculate(int a, int b);

    //    static void Main(string[] args)
    //    {
    //        Calculate cal = (a, b) => a + b;
    //        Console.WriteLine($"{3} + {4} : {cal(3, 4)}");
    //    }
    //}



    // P491 StatementLambda
    //class MainApp
    //{
    //    delegate string Concatenate(string[] args);

    //    static void Main(string[] args)
    //    {
    //        Concatenate concat = (arr) =>
    //        {
    //            string result = "";
    //            foreach (string s in arr)
    //                result += s;

    //            return result;
    //        };
    //        Console.WriteLine(concat(args));
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Func<int> func1 = () => 10;
    //        Console.WriteLine($"func1() : {func1()}");

    //        Func<int, int> func2 = (x) => x * 2;
    //        Console.WriteLine($"func2(4) : {func2(4)}");

    //        Func<double, double, double> func3 = (x, y) => x / y;
    //        Console.WriteLine($"func3(22, 7) : {func3(22, 7)}");
    //    }
    //}



    // P496 ActinTest
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Action act1 = () => Console.WriteLine("Action()");
    //        act1();

    //        int result = 0;
    //        Action<int> act2 = (x) => result = x * x;

    //        act2(3);
    //        Console.WriteLine($"result : {result}");

    //        Action<double, double> act3 = (x, y) =>
    //        {
    //            double pi = x / y;
    //            Console.WriteLine($"Action<T1,T2>({x}, {y} : {pi})");
    //        };

    //        act3(22.0, 7.0);
    //    }
    //}


    

    // P509 연습문제 2번
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 11, 22, 33, 44, 55 };

    //        foreach(int a in array)
    //        {
    //            Action<int> action = (x) =>
    //            {
    //                Console.WriteLine(x * x);
    //            };
    //            action(a);
                    
    //        }
    //    }
    //}



    // P646 BasicThread 
    //class MainApp
    //{
    //    static void DoSomething()
    //    {
    //        for(int i=0; i< 5;i++)
    //        {
    //            Console.WriteLine($"DoSomething : {i}");
    //            Thread.Sleep(100);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Thread t1 = new Thread(new ThreadStart(DoSomething)); // Thread의 인스턴스 생성

    //        Console.WriteLine("Starting thread...");
    //        t1.Start(); // Thread 시작

    //        for(int i = 0; i < 5;i++)
    //        {
    //            Console.WriteLine($"Main : {i}");
    //            Thread.Sleep(10);
    //        }

    //        Console.WriteLine("Waiting until thread stops...");
    //        t1.Join(); // Thread 종료 대기

    //        Console.WriteLine("Finished");
    //    }
    //}



    // P649 AbortingThread
    //class SideTask
    //{
    //    int count;

    //    public SideTask(int count)
    //    {
    //        this.count = count;
    //    }

    //    public void KeepAlive()
    //    {
    //        try
    //        {
    //            while(count > 0)
    //            {
    //                Console.WriteLine($"{count--} left");
    //                Thread.Sleep(10);
    //            }
    //            // Console.WriteLine("Count : 0");
    //        }
    //        catch (ThreadAbortException e)
    //        {
    //            Console.WriteLine(e);
    //            Thread.ResetAbort(); // ResetAbort()가 호출되지 않는 한, catch블록의 끝에서 다시 throw 됨
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Clearing resoure...");
    //        }
            
    //    }
    //}


    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        SideTask task = new SideTask(100);
    //        Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
    //        t1.IsBackground = false;

    //        Console.WriteLine("Starting thread...");
    //        t1.Start();
    //        Thread.Sleep(100);

    //        Console.WriteLine("Aborting thread...");
    //        t1.Abort(); // Thread 취소 -> catch절 실행

    //        Console.WriteLine("Waiting until thread stops...");
    //        t1.Join();

    //        Console.WriteLine("Finished");
    //    }
    //}



    // P655 UsingTreadState
    //class MainApp
    //{
    //    private static void PrintTreadState(ThreadState state)
    //    {
    //        Console.WriteLine("{0,-16} : {1}", state, (int)state);
    //    }

    //    static void Main(string[] args)
    //    {
    //        PrintTreadState(ThreadState.Running);

    //        PrintTreadState(ThreadState.StopRequested);

    //        PrintTreadState(ThreadState.SuspendRequested);

    //        PrintTreadState(ThreadState.Background);

    //        PrintTreadState(ThreadState.Unstarted);

    //        PrintTreadState(ThreadState.Stopped);

    //        PrintTreadState(ThreadState.WaitSleepJoin);

    //        PrintTreadState(ThreadState.Suspended);

    //        PrintTreadState(ThreadState.AbortRequested);

    //        PrintTreadState(ThreadState.Aborted);

    //        PrintTreadState(ThreadState.Aborted | ThreadState.Stopped);
    //    }
    //}




    // P660 InterruptingTread
    //class SideTask
    //{
    //    int count;

    //    public SideTask(int count)
    //    {
    //        this.count = count;
    //    }

    //    public void KeepAlive()
    //    {
    //        try
    //        {
    //            Console.WriteLine("Running thread isn't gonna be interrupted");
    //            Thread.SpinWait(1000000000);

    //            while(count > 0)
    //            {
    //                Console.WriteLine($"{count--} left");
    //                Console.WriteLine("Enter into WaitJoinSleep State...");
    //                Thread.Sleep(10);
    //            }
    //            Console.WriteLine("Count : 0");
    //        }
    //        catch (ThreadInterruptedException e)
    //        {
    //            Console.WriteLine(e);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Clearing resoure...");
    //        }
    //    }

    //    class MainApp
    //    {
    //        static void Main(string[] args)
    //        {
    //            SideTask task = new SideTask(100);
    //            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
    //            t1.IsBackground = false;

    //            // Console.WriteLine("Starting thread...");
    //            t1.Start();

    //            Thread.Sleep(100);

    //            // Console.WriteLine("Interrupting thread...");
    //            t1.Interrupt();

    //            // Console.WriteLine("Waiting until thread stops...");
    //            t1.Join();

    //            Console.WriteLine("Finish");
    //        }
    //    }
    //}



    // P666 Synchronize
    //class Counter
    //{
    //    const int LOOP_COUNT = 1000;
    //    readonly object thisLock;

    //    private int count;
    //    public int Count
    //    {
    //        get { return count; }
    //    }

    //    public Counter()
    //    {
    //        thisLock = new object();
    //        count = 0;
    //    }

    //    public void Increase()
    //    {
    //        int loopCount = LOOP_COUNT;

    //        while(loopCount-- > 0)
    //        {
    //            lock(thisLock)
    //            {
    //                count++;
    //            }
    //            Thread.Sleep(1);
    //        }
    //    }

    //    public void Decrease()
    //    {
    //        int loopCount = LOOP_COUNT;

    //        while(loopCount-- > 0)
    //        {
    //            lock(thisLock)
    //            {
    //                count--;
    //            }
    //            Thread.Sleep(1);
    //        }
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Counter counter = new Counter();

    //        Thread incTread = new Thread(new ThreadStart(counter.Increase));
    //        Thread decThread = new Thread(new ThreadStart(counter.Decrease));

    //        incTread.Start();
    //        decThread.Start();

    //        incTread.Join();
    //        decThread.Join();

    //        Console.WriteLine(counter.Count);
    //    }
    //}



    // P669 UsingMonitor
    //class Counter
    //{
    //    const int LOOP_COUNT = 1000;
    //    readonly object thisLock;

    //    private int count;
    //    public int Count
    //    {
    //        get { return count; }
    //    }

    //    public Counter()
    //    {
    //        thisLock = new object();
    //        count = 0;
    //    }

    //    public void Increase()
    //    {
    //        int loopCount = LOOP_COUNT;
    //        while(loopCount-- > 0)
    //        {
    //            Monitor.Enter(thisLock);
    //            try
    //            {
    //                count++;
    //            }
    //            finally
    //            {
    //                Monitor.Exit(thisLock);
    //            }
    //            Thread.Sleep(1);
    //        }
    //    }

    //    public void Decrease()
    //    {
    //        int loopCount = LOOP_COUNT;
    //        while (loopCount-- > 0)
    //        {
    //            Monitor.Enter(thisLock);
    //            try
    //            {
    //                count--;
    //            }
    //            finally
    //            {
    //                Monitor.Exit(thisLock);
    //            }
    //            Thread.Sleep(1);
    //        }
    //    }
    //}


    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Counter counter = new Counter();

    //        Thread incThread = new Thread(new ThreadStart(counter.Increase));
    //        Thread decThread = new Thread(new ThreadStart(counter.Decrease));

    //        incThread.Start();
    //        decThread.Start();

    //        incThread.Join();
    //        decThread.Join();

    //        Console.WriteLine(counter.Count);
    //    }
    //}



    //class Counter
    //{
    //    const int LOOP_COUNT = 1000;

    //    readonly object thisLock;
    //    bool lockedCount = false;

    //    private int count;
    //    public int Count
    //    {
    //        get { return count; }
    //    }

    //    public Counter()
    //    {
    //        thisLock = new object();
    //        count = 0;
    //    }

    //    public void Increase()
    //    {
    //        int loopCount = LOOP_COUNT;

    //        while(loopCount-- > 0)
    //        {
    //            lock(thisLock)
    //            {
    //                while (count > 0 || lockedCount == true)
    //                    Monitor.Wait(thisLock);

    //                lockedCount = true;
    //                count++;
    //                lockedCount = false;

    //                Monitor.Pulse(thisLock);
    //            }
    //        }
    //    }

    //    public void Decrease()
    //    {
    //        int loopCount = LOOP_COUNT;
            
    //        while(loopCount-- > 0)
    //        {
    //            lock(thisLock)
    //            {
    //                while (count < 0 || lockedCount == true)
    //                    Monitor.Wait(thisLock);

    //                lockedCount = true;
    //                count--;
    //                lockedCount = false;

    //                Monitor.Pulse(thisLock);
    //            }
    //        }
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Counter counter = new Counter();

    //        Thread incThread = new Thread(new ThreadStart(counter.Increase));
    //        Thread decThread = new Thread(new ThreadStart(counter.Decrease));

    //        incThread.Start();
    //        decThread.Start();

    //        incThread.Join();
    //        decThread.Join();

    //        Console.WriteLine(counter.Count);
    //    }
    //}



    // P681 UsingTask
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        string srcFile = args[0];

    //        Action<object> FileCopyAction = (object state) =>
    //        {
    //            String[] paths = (String[])state;
    //            File.Copy(paths[0], paths[1]);

    //            Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
    //                Task.CurrentId, Thread.CurrentThread.ManagedThreadId, paths[0], paths[1]);
    //        };

    //        Task t1 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy1" });

    //        Task t2 = Task.Run(() =>
    //        {
    //            FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
    //        });

    //        t1.Start();

    //        Task t3 = new Task(FileCopyAction, new string[] { srcFile, srcFile + ".copy3" });
    //        t3.RunSynchronously();

    //        t1.Wait();
    //        t2.Wait();
    //        t3.Wait();
    //    }
    //}



  

}
