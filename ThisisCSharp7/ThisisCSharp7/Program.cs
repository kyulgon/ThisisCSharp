using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThisisCSharp7
{
    // P459 Delegate
    //delegate int MyDelegate(int a, int b); // 대리자 선언

    //class Calculator
    //{
    //    public int Plus(int a, int b) // 대리자는 인스턴스 메소드도 참조 가능
    //    {
    //        return a + b;
    //    }

    //    public static int Minus(int a, int b) // 대리자는 정적 메소드도 참조할 수 있다
    //    {
    //        return a - b;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculator Calc = new Calculator();
    //        MyDelegate Callback; // 인스턴스 생성

    //        Callback = new MyDelegate(Calc.Plus);
    //        Console.WriteLine(Callback(3, 4)); // 메서드를 호출하듯 대리자를 사용

    //        Callback = new MyDelegate(Calculator.Minus);
    //        Console.WriteLine(Callback(7, 5)); // 메서드를 호출하듯 대리자를 사용
    //    }
    //}



    // P462 UsingCallback
    //delegate int Compare(int a, int b); // 대리자 선언

    //class MainApp
    //{
    //    static int AscendCompare(int a, int b) // 오름차순
    //    {
    //        if (a > b)
    //            return 1;
    //        else if (a == b)
    //            return 0;
    //        else
    //            return -1;
    //    }

    //    static int DescendCompare(int a, int b) // 내림차순
    //    {
    //        if (a < b)
    //            return 1;
    //        else if (a == b)
    //            return 0;
    //        else
    //            return -1;

    //    }

    //    static void BubbleSort(int[] DataSet, Compare Comparer) // 버블소트 코딩
    //    {
    //        int temp = 0;

    //        for (int i = 0; i < DataSet.Length -1; i++)
    //        {
    //            for (int j = 0; j < DataSet.Length - (i + 1); j++)
    //            {
    //                if(Comparer(DataSet[j], DataSet[j+1]) > 0)
    //                {
    //                    temp = DataSet[j + 1];
    //                    DataSet[j + 1] = DataSet[j];
    //                    DataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] array = { 3, 7, 4, 2, 10 };

    //        Console.WriteLine("Sorting Ascending...");
    //        BubbleSort(array, new Compare(AscendCompare));

    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Console.Write($"{array[i]} ");
    //        }

    //        int[] array2 = { 7, 2, 8, 10, 11 };
    //        Console.WriteLine("\nSorting Descending...");
    //        BubbleSort(array2, new Compare(DescendCompare));

    //        for (int i = 0; i < array2.Length; i++)
    //        {
    //            Console.Write($"{array2[i]} ");
    //        }
    //        Console.WriteLine();
    //    }
    //}




    // P646 BasicThread
    //class MainApp
    //{
    //    static void DoSomething()
    //    {
    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine($"DoSomething : {i}");
    //            Thread.Sleep(10);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        Thread t1 = new Thread(new ThreadStart(DoSomething));

    //        Console.WriteLine("Starting thread...");
    //        t1.Start();

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine($"Main : {i}");
    //            Thread.Sleep(10);
    //        }

    //        Console.WriteLine("Wating until thread stops...");
    //        t1.Join();

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
    //            Thread.ResetAbort();
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
    //        t1.Abort();

    //        Console.WriteLine("Wating until thread stops...");
    //        t1.Join();

    //        Console.WriteLine("Finish");
    //    }
    //}



    // P459 Delegate
    //delegate int MyDelegate(int a, int b); // 대리자 선언

    //class Calculator
    //{
    //    public int Plus(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public static int Minus(int a, int b)
    //    {
    //        return a - b;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Calculator Calc = new Calculator();
    //        MyDelegate Callback;

    //        Callback = new MyDelegate(Calc.Plus);
    //        Console.WriteLine(Callback(3, 4));

    //        Callback = new MyDelegate(Calculator.Minus);
    //        Console.WriteLine(Callback(7, 5));
    //    }
    //}



    // P462 UsingCallback
    //delegate int Compare(int a, int b);

    //class MainApp
    //{
    //    static int AscendCompare(int a, int b)
    //    {
    //        if (a > b)
    //            return 1;
    //        else if (a == b)
    //            return 0;
    //        else
    //            return -1;
    //    }

    //    static int DescendCompare(int a, int b)
    //    {
    //        if (a < b)
    //            return 1;
    //        else if (a == b)
    //            return 0;
    //        else
    //            return -1;
    //    }

    //    static void BubbleSort(int[] DataSet, Compare Comparer)
    //    {
    //        int temp = 0;

    //        for (int i = 0; i < DataSet.Length-1; i++)
    //        {
    //            for (int j = 0; j < DataSet.Length - (i+1); j++)
    //            {
    //                if(Comparer(DataSet[j], DataSet[j+1]) > 0)
    //                {
    //                    temp = DataSet[j + 1];
    //                    DataSet[j + 1] = DataSet[j];
    //                    DataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] array = { 3, 7, 4, 2, 10 };


    //        BubbleSort(array, new Compare(AscendCompare));

    //        for (int i = 0; i < array.Length; i++)
    //            Console.Write($"{array[i]} ");

    //        Console.WriteLine();
    //        BubbleSort(array, new Compare(DescendCompare));

    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Console.Write($"{array[i]} ");
    //        }
    //    }
    //}




    // P466 GenericDelegate
    //delegate int Compare<T>(T a, T b);

    //class MainApp
    //{
    //    static int AscendCompare<T>(T a, T b) where T : IComparable<T>
    //    {
    //        return a.CompareTo(b);
    //    }

    //    static int DescendCompare<T>(T a, T b) where T : IComparable<T>
    //    {
    //        return a.CompareTo(b) * -1;
    //    }

    //    static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
    //    {
    //        T temp;

    //        for (int i = 0; i < DataSet.Length -1; i++)
    //        {
    //            for (int j = 0; j < DataSet.Length - (i+1); j++)
    //            {
    //                if(Comparer(DataSet[j], DataSet[j+1]) > 0)
    //                {
    //                    temp = DataSet[j + 1];
    //                    DataSet[j + 1] = DataSet[j];
    //                    DataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] array = { 3, 7, 4, 2, 10 };

    //        BubbleSort<int>(array, new Compare<int>(AscendCompare));
    //        for (int i = 0; i < array.Length; i++)
    //            Console.Write($"{array[i]} ");
    //        Console.WriteLine();

    //        BubbleSort<int>(array, new Compare<int>(DescendCompare));
    //        for (int i = 0; i < array.Length; i++)
    //            Console.Write($"{array[i]} ");
    //        Console.WriteLine();

    //        string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

    //        BubbleSort<string>(array2, new Compare<string>(DescendCompare));
    //        for (int i = 0; i < array2.Length; i++)
    //            Console.Write($"{array2[i]} ");
    //    }
    //}



    // P470 DelegateChains
    //delegate void Notify(string message); // Notify 대리자 선언

    //class Notifier// Notify 대리자의 인스턴스 EventOccured를 가진 클래스 Notifier 선언
    //{
    //    public Notify EventOccured;
    //}

    //class EventListener
    //{
    //    private string name;
    //    public EventListener(string name)
    //    {
    //        this.name = name;
    //    }

    //    public void SomethingHappend(string message)
    //    {
    //        Console.WriteLine($"{name}.SomethingHappend : {message}");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Notifier notifier = new Notifier();
    //        EventListener listener1 = new EventListener("Listener1");
    //        EventListener listener2 = new EventListener("Listener2");
    //        EventListener listener3 = new EventListener("Listener3");

    //        // += 연산자를 이용한 체인 만들기
    //        notifier.EventOccured += listener1.SomethingHappend;
    //        notifier.EventOccured += listener2.SomethingHappend;
    //        notifier.EventOccured += listener3.SomethingHappend;
    //        notifier.EventOccured("You've got mail.");

    //        Console.WriteLine();

    //        // -= 연산자를 이용한 체인 끊기
    //        notifier.EventOccured -= listener2.SomethingHappend;
    //        notifier.EventOccured("Downlad complete");
    //        Console.WriteLine();

    //        notifier.EventOccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
    //        notifier.EventOccured("Nuclear launch detexted.");

    //        Console.WriteLine();

    //        Notify notify1 = new Notify(listener1.SomethingHappend);
    //        Notify notify2 = new Notify(listener2.SomethingHappend);

    //        notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2);
    //        notifier.EventOccured("Fire!!");

    //        Console.WriteLine();

    //        notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);
    //        notifier.EventOccured("RPG!");

    //    }
    //}


    //delegate int Compare(int a, int b);

    //class MainApp
    //{
    //    static void BubbleSort(int[] DataSet, Compare Comparer)
    //    {
    //        int temp = 0;

    //        for (int i = 0; i < DataSet.Length - 1; i++)
    //        {
    //            for (int j = 0; j < DataSet.Length - (i+1); j++)
    //            {
    //                if(Comparer(DataSet[j], DataSet[j+1]) > 0)
    //                {
    //                    temp = DataSet[j + 1];
    //                    DataSet[j + 1] = DataSet[j];
    //                    DataSet[j] = temp;
    //                }
    //            }
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 3, 7, 4, 2, 10 };

    //        Console.WriteLine("Sorting ascending...");
    //        BubbleSort(arr, delegate (int a, int b)
    //        {
    //            if (a > b)
    //                return 1;
    //            else if (a == b)
    //                return 0;
    //            else
    //                return -1;
    //        });

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            Console.Write($"{arr[i]} ");
    //        }

    //        Console.WriteLine();
    //        int[] arr2 = { 7, 2, 8, 10, 11 };
    //        Console.WriteLine("Sorting desending");
    //        BubbleSort(arr2, delegate (int a, int b)
    //        {
    //            if (a < b)
    //                return 1;
    //            else if (a == b)
    //                return 0;
    //            else
    //                return -1;
    //        });

    //        for (int i = 0; i < arr2.Length; i++)
    //        {
    //            Console.Write($"{arr2[i]} ");
    //        }
    //    }
    //}

    //delegate void EventHandler(string message);

    //class MyNotifier
    //{
    //    public event EventHandler SomethingHappend;
    //    public void DoSomethisn(int number)
    //    {
    //        int temp = number % 10;

    //        if(temp !=0 && temp % 3 == 0)
    //        {
    //            SomethingHappend(string.Format("{0} : 짝", number));
    //        }
    //    }
    //}

    //class MainApp
    //{
    //    static public void MyHandler(string message)
    //    {
    //        Console.WriteLine(message);
    //    }

    //    static void Main(string[] args)
    //    {
    //        MyNotifier notifier = new MyNotifier();
    //        notifier.SomethingHappend += new EventHandler(MyHandler);

    //        for (int i = 1; i < 30; i++)
    //        {
    //            notifier.DoSomethisn(i);
    //        }
    //    }
    //}



    // P482 연습문제1
    //delegate int MyDelegate(int a, int b);

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        MyDelegate Callback;

    //        Callback = delegate (int a, int b)
    //        {
    //            return a + b;
    //        };
    //        Console.WriteLine(Callback(3, 4));

    //        Callback = delegate (int a, int b)
    //        {
    //            return a - b;
    //        };
    //        Console.WriteLine(Callback(7, 5));
    //    }
    //}



    // P482 연습문제2
    delegate void MyDelegate(int a);

    class Market
    {
        public event MyDelegate CustomerEvent;

        public void BuySomethins(int CustomerNo)
        {
            if (CustomerNo == 30)
                CustomerEvent(CustomerNo);
        }
    }

    class MainApp
    {
        static public void MyHandler(int a)
        {
            Console.WriteLine(a);
        }

        static void Main(string[] args)
        {
            Market market = new Market();
            market.CustomerEvent += new MyDelegate(MyHandler);

            for (int customerNo = 0; customerNo < 100; customerNo += 10)
            {
                //Console.WriteLine("축하합니다! " + market.BuySomethins(customerNo) +)
                //market.BuySomethins(customerNo);
            }
        }
    }
}
