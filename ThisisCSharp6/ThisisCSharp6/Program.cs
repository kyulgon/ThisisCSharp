using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ThisisCSharp6
{
    //// P379 JaggedArray
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int[][] jagged = new int[3][];
    //        jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
    //        jagged[1] = new int[] { 10, 20, 30 };
    //        jagged[2] = new int[] { 100, 200 };

    //        foreach(int[] arr in jagged)
    //        {
    //            Console.Write($"Length : {arr.Length}, ");
    //            foreach(int e in arr)
    //            {
    //                Console.Write($"{e} ");
    //            }
    //            Console.WriteLine("");
    //        }
    //        Console.WriteLine("");
    //    }
    //}


    // P382 UsingList
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        ArrayList list = new ArrayList();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            list.Add(i);
    //        }

    //        foreach(object obj in list)
    //        {
    //            Console.Write($"{obj} ");              
    //        }
    //        Console.WriteLine();

    //        list.RemoveAt(2);

    //        foreach(object obj in list)
    //            Console.Write($"{obj} ");
    //        Console.WriteLine();

    //        list.Insert(2, 2);

    //        foreach (object obj in list)
    //            Console.Write($"{obj} ");
    //        Console.WriteLine();

    //        list.Add("abc");
    //        list.Add("def");

    //        for (int i = 0; i < list.Count; i++)
    //        {
    //            Console.Write($"{list[i]} ");
    //        }
    //    }
    //}


    // P385 UsingQueu
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Queue que = new Queue();
    //        que.Enqueue(1);
    //        que.Enqueue(2);
    //        que.Enqueue(3);
    //        que.Enqueue(4);
    //        que.Enqueue(5);

    //        //foreach (object obj in que)
    //        //    Console.WriteLine($"{obj} ");

    //        while (que.Count > 0)
    //            Console.WriteLine(que.Dequeue());
    //    }
    //}


    // P387 UsingStack
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Stack stack = new Stack();
    //        stack.Push(1);
    //        stack.Push(2);
    //        stack.Push(3);
    //        stack.Push(4);
    //        stack.Push(5);

    //        while(stack.Count > 0)
    //        {
    //            Console.WriteLine(stack.Pop());
    //        }
    //    }
    //}



    // P388 UsingHashtable
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Hashtable ht = new Hashtable();
    //        ht["하나"] = "one";
    //        ht["둘"] = "two";
    //        ht["셋"] = "three";
    //        ht["넷"] = "four";
    //        ht["다섯"] = "five";

    //        Console.WriteLine(ht["하나"]);
    //        Console.WriteLine(ht["둘"]);
    //        Console.WriteLine(ht["셋"]);
    //        Console.WriteLine(ht["넷"]);
    //        Console.WriteLine(ht["다섯"]);
    //    }
    //}



    // P390 InitalizingCOllections
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 123, 456, 789 };

    //        ArrayList list = new ArrayList(arr);
    //        foreach (object item in list)
    //            Console.WriteLine($"ArrayList : {item}");
    //        Console.WriteLine();

    //        Stack stack = new Stack(arr);
    //        foreach(object item in stack)
    //            Console.WriteLine($"Statck : {item}");
    //        Console.WriteLine();

    //        ArrayList list2 = new ArrayList() { 11, 22, 33 };
    //        foreach(object item in list2)
    //            Console.WriteLine($"ArrayList2 : {item}");
    //    }       
    //}



    // P394 Indexer
    //class MyList
    //{
    //    private int[] array;

    //    public MyList()
    //    {
    //        array = new int[3];
    //    }

    //    public int this[int index]
    //    {
    //        get { return array[index]; }
    //        set
    //        {
    //            if(index >= array.Length)
    //            {
    //                Array.Resize<int>(ref array, index + 1);
    //                Console.WriteLine($"Array Resized : {array.Length}");
    //            }
    //        }

    //    }

    //    public int Length
    //    {
    //        get { return array.Length; }
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList list = new MyList();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            list[i] = i;
    //        }


    //        for (int i = 0; i < list.Length; i++)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}



    // P396 Yield
    //class MyEnumerator
    //{
    //    int[] numbers = { 1, 2, 3, 4 };
    //    public IEnumerator GetEnumerator()
    //    {
    //        yield return numbers[0];
    //        yield return numbers[1];
    //        yield return numbers[2];
    //        yield break;
    //        yield return numbers[3]; // 실행 안됨
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        var obj = new MyEnumerator();
    //        foreach(int i in obj)
    //        {
    //            Console.WriteLine(i);
    //        }
    //    }
    //}



    // P398 Enumerable
    //class MyList : IEnumerable, IEnumerator
    //{
    //    private int[] array;
    //    int position = -1; // 초기값

    //    public MyList()
    //    {
    //        array = new int[3];
    //    }

    //    public int this[int index]
    //    {
    //        get { return array[index]; }
    //        set
    //        {
    //            if (index >= array.Length)
    //            {
    //                Array.Resize<int>(ref array, index + 1);
    //                Console.WriteLine($"Array Resized : {array.Length}");
    //            }

    //            array[index] = value;
    //        }
    //    }

    //    // IEnumerator 멤버
    //    // 프로퍼티는 현재 위치의 요소를 반환
    //    public object Current
    //    {
    //        get { return array[position]; }
    //    }

    //    // IEnumerator 멤버
    //    public bool MoveNext()
    //    {
    //        if(position == array.Length -1)
    //        {
    //            Reset();
    //            return false;
    //        }

    //        position++;
    //        return (position < array.Length);
    //    }

    //    // IEnumerator 멤버
    //    public void Reset()
    //    {
    //        position = -1;
    //    }

    //    // IEnumerable 멤버
    //    public IEnumerator GetEnumerator()
    //    {
    //        return this;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList list = new MyList();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            list[i] = i;
    //        }

    //        foreach (int e in list)
    //            Console.WriteLine(e);
    //    }
    //}



    // P408 CopyingArray
    //class MainApp
    //{
    //    static void CopyArray<T>(T[] source, T[] target)
    //    {
    //        for (int i = 0; i < source.Length; i++)
    //        {
    //            target[i] = source[i];
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] source = { 1, 2, 3, 4, 5 };
    //        int[] target = new int[source.Length];

    //        CopyArray<int>(source, target);

    //        foreach (int element in target)
    //            Console.WriteLine(element);

    //        string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
    //        string[] target2 = new string[source2.Length];

    //        CopyArray<string>(source2, target2);
    //        foreach (string element in target2)
    //            Console.WriteLine(element);

    //    }
    //}



    // P411 Generic
    //class MyList<T>
    //{
    //    private T[] array;

    //    public MyList()
    //    {
    //        array = new T[3];
    //    }

    //    public T this[int index]
    //    {
    //        get { return array[index]; }
    //        set
    //        {
    //            if(index >= array.Length)
    //            {
    //                Array.Resize<T>(ref array, index + 1);
    //                Console.WriteLine($"Array Resized : {array.Length}");
    //            }
    //            array[index] = value;
    //        }
    //    }

    //    public int Length
    //    {
    //        get { return array.Length; }
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        MyList<string> str_list = new MyList<string>();
    //        str_list[0] = "abc";
    //        str_list[1] = "def";
    //        str_list[2] = "ghi";
    //        str_list[3] = "jkl";
    //        str_list[4] = "mno";


    //        for (int i = 0; i < str_list.Length; i++)
    //        {
    //            Console.WriteLine(str_list[i]);
    //        }
    //        Console.WriteLine();


    //        MyList<int> int_list = new MyList<int>();
    //        int_list[0] = 0;
    //        int_list[1] = 1;
    //        int_list[2] = 2;
    //        int_list[3] = 3;
    //        int_list[4] = 4;

    //        for (int i = 0; i < int_list.Length; i++)
    //        {
    //            Console.WriteLine(int_list[i]);
    //        }
    //    }      
    //}


   // P416 ContraintsOnTypeParameters
   //class StructArray<T> where T : struct
   // {
   //     public T[] Array { get; set; }
   //     public StructArray(int size)
   //     {
   //         Array = new T[size];
   //     }
   // }

   // class RefArray<T> where T : class
   // {
   //     public T[] Array { get; set; }
   //     public RefArray(int size)
   //     {
   //         Array = new T[size];
   //     }
   // }

   // class Base { }
   // class Derived : Base { }
   // class BaseArray<U> where U : Base
   // {
   //     public U[] Array { get; set; }
   //     public BaseArray(int size)
   //     {
   //         Array = new U[size];
   //     }

   //     public void CopyArray<T>(T[] Source) where T : U
   //     {
   //         Source.CopyTo(Array, 0);
   //     }
   // }


   // class MainApp
   // {
   //     public static T CreateInstance<T>() where T : new()
   //     {
   //         return new T();
   //     }

   //     static void Main(string[] args)
   //     {
   //         StructArray<int> a = new StructArray<int>(3);
   //         a.Array[0] = 0;
   //         a.Array[1] = 1;
   //         a.Array[2] = 2;

   //         RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
   //         b.Array[0] = new StructArray<double>(5);
   //         b.Array[1] = new StructArray<double>(10);
   //         b.Array[2] = new StructArray<double>(1005);


   //         BaseArray<Base> c = new BaseArray<Base>(3);
   //         c.Array[0] = new Base();
   //         c.Array[1] = new Derived();
   //         c.Array[2] = CreateInstance<Base>();

   //         BaseArray<Derived> d = new BaseArray<Derived>(3);
   //         c.Array[0] = new Derived();
   //         c.Array[1] = CreateInstance<Derived>();
   //         c.Array[2] = CreateInstance<Derived>();


   //         BaseArray<Derived> e = new BaseArray<Derived>(3);
   //         e.CopyArray<Derived>(d.Array); 
   //     }
   // }



    // P420 UsingGenericList
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        List<int> list = new List<int>();
    //        for (int i = 0; i < 5; i++)
    //        {
    //            list.Add(i);
    //        }

    //        foreach (int element in list)
    //            Console.Write($"{element} ");
    //        Console.WriteLine();

    //        list.RemoveAt(2);

    //        foreach (int element in list)
    //            Console.Write($"{element} ");
    //        Console.WriteLine();

    //        list.Insert(2, 2);

    //        foreach (int element in list)
    //            Console.Write($"{element} ");
    //        Console.WriteLine();
    //    }
    //}



   // P435 TryCatch
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] arr = { 1, 2, 3 };

    //        try
    //        {
    //            for (int i = 0; i < 5; i++)
    //            {
    //                Console.WriteLine(arr[i]);
    //            }
    //        }
    //        catch(IndexOutOfRangeException e)
    //        {
    //            Console.WriteLine($"예외가 발생했습니다 : {e.Message}");
    //        }

    //        Console.WriteLine("종료");
    //    }
    //}


    // P439 Throw
    //class MainApp
    //{
    //    static void DoSomething(int arg)
    //    {
    //        if (arg < 10)
    //            Console.WriteLine($"arg : {arg}");
    //        else
    //            throw new Exception("arg가 10보다 큽니다.");
    //    }

    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            DoSomething(1);
    //            DoSomething(3);
    //            DoSomething(5);
    //            DoSomething(7);
    //            DoSomething(9);
    //            DoSomething(11); // 예외발생해서 아래 코드 실행 안됨
    //            DoSomething(13);
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //    }
    //}


    // P444 Finally
    //class MainApp
    //{
    //    static int Divide(int dividend, int divisor)
    //    {
    //        try
    //        {
    //            Console.WriteLine("Divide() 시작");
    //            return dividend / divisor;
    //        }
    //        catch(DivideByZeroException e)
    //        {
    //            Console.WriteLine("Divide() 예외 발생");
    //            throw e;
    //        }
    //        finally
    //        {
    //            Console.WriteLine("Divide() 끝");
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Console.WriteLine("제수를 입력하세요 : ");
    //            string temp = Console.ReadLine();
    //            int diviend = Convert.ToInt32(temp);

    //            Console.Write("피제수를 입력하세요 : ");
    //            temp = Console.ReadLine();
    //            int divisor = Convert.ToInt32(temp);

    //            Console.WriteLine("{0}/{1} = {2}", diviend, divisor, Divide(diviend, divisor));
    //        }
    //        catch (FormatException e)
    //        {
    //            Console.WriteLine("에러 : " + e.Message);
    //        }
    //        catch ( DivideByZeroException e)
    //        {
    //            Console.WriteLine("에러 : " + e.Message);
    //        }
    //        finally
    //        {
    //            Console.WriteLine("프로그램을 종료합니다.");
    //        }
    //    }
    //}


    
   // P450 ExceptionFiltering
   //class FilterableException : Exception
   // {
   //     public int ErrorNo { get; set; }
   // }

   // class MainApp
   // {
   //     static void Main(string[] args)
   //     {
   //         Console.WriteLine("Enter Number Between 0~10");
   //         string input = Console.ReadLine();
   //         try
   //         {
   //             int num = Int32.Parse(input);

   //             if (num < 0 || num > 10)
   //                 throw new FilterableException() { ErrorNo = num };
   //             else
   //                 Console.WriteLine($"OUtput : {num}");
   //         }
   //         catch (FilterableException e) when (e.ErrorNo < 0)
   //         {
   //             Console.WriteLine("Negative input is not allowed");
   //         }
   //         catch(FilterableException e) when (e.ErrorNo > 10)
   //         {
   //             Console.WriteLine("Too big number is not allowed");
   //         }
   //     }
   // }



    // P453 StackTrace
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            int a = 1;
    //            Console.WriteLine(3 / --a);
    //        }
    //        catch (DivideByZeroException e)
    //        {
    //            Console.WriteLine(e.StackTrace);
    //        }
    //    }
    //}



    // P454 연습문제
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
            }

            try
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch
            {
                Array.Resize(ref arr, arr.Length - 1);
                Console.WriteLine("배열의 크기를 벗어났습니다. 조정하겠습니다.");
            }
           
        }
    }
}
