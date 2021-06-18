using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisisCSharp5
{
    // P310 MultiInterfaceInheritance
    //interface IRunnable
    //{
    //    void Run();
    //}

    //interface IFlyable
    //{
    //    void Fly();
    //}

    //class FlyingCar : IRunnable, IFlyable
    //{
    //    public void Run()
    //    {
    //        Console.WriteLine("Run!");
    //    }

    //    public void Fly()
    //    {
    //        Console.WriteLine("Fly!");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        FlyingCar car = new FlyingCar();
    //        car.Run();
    //        car.Fly();

    //        IRunnable runnable = car as IRunnable;
    //        runnable.Run();

    //        IFlyable flyable = car as IFlyable;
    //        flyable.Fly();
    //    }
    //}



    // P317 AbstractClass
    //abstract class AbstractBase
    //{
    //    protected void PrivateMethodA()
    //    {
    //        Console.WriteLine("AbstactBase.PrivateMethodA()");
    //    }

    //    public void PublicMethodA()
    //    {
    //        Console.WriteLine("AbstactBase.PublicMethodA()");
    //    }

    //    public abstract void AbstractMethodA();
    //}

    //class Derived : AbstractBase
    //{
    //    public override void AbstractMethodA()
    //    {
    //        Console.WriteLine("Derived.AbstractMethodA()");
    //        PrivateMethodA();
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        AbstractBase obj = new Derived();
    //        obj.AbstractMethodA();
    //        obj.PublicMethodA();
    //    }
    //}


    // P326 Property
    //class BirthdayInfo
    //{
    //    private string name;
    //    private DateTime birthday;

    //    public string Name
    //    {
    //        get
    //        {
    //            return name;
    //        }
    //        set
    //        {
    //            name = value;
    //        }
    //    }

    //    public DateTime Birthday
    //    {
    //        get
    //        {
    //            return birthday;
    //        }
    //        set
    //        {
    //            birthday = value;
    //        }
    //    }

    //    public int Age
    //    {
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(birthday).Ticks).Year;
    //        }
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        BirthdayInfo birth = new BirthdayInfo();
    //        birth.Name = "서현";
    //        birth.Birthday = new DateTime(1991, 6, 28);

    //        Console.WriteLine($"Name : {birth.Name}");
    //        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //        Console.WriteLine($"Age : {birth.Age}");
    //    }
    //}



    // P330 AutoImplementedProperty
    //class BirthdayInfo
    //{
    //    public string Name { get; set; } = "Unkenown";
    //    public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);

    //    public int Age
    //    {
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
    //        }
    //    }

    //    class MainApp
    //    {
    //        static void Main(string[] args)
    //        {
    //            BirthdayInfo birth = new BirthdayInfo();
    //            //Console.WriteLine($"Name : {birth.Name}");
    //            //Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //            //Console.WriteLine($"Age : {birth.Age}");

    //            birth.Name = "서현";
    //            birth.Birthday = new DateTime(1991, 6, 28);
    //            Console.WriteLine($"Name : {birth.Name}");
    //            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //            Console.WriteLine($"Age : {birth.Age}");
    //        }
    //    }
    //}


    // P333 ConstructorWithProperty
    //class BirthdayInfo
    //{
    //    public string Name { get; set; }
    //    public DateTime Birthday { get; set; }

    //    public int Age
    //    {
    //        get
    //        {
    //            return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
    //        }
    //    } 
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        BirthdayInfo birth = new BirthdayInfo()
    //        {
    //            Name = "서현",
    //            Birthday = new DateTime(1991, 6, 28)
    //        };

    //        Console.WriteLine($"Name : {birth.Name}");
    //        Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
    //        Console.WriteLine($"Age : {birth.Age}");
    //    }
    //}




    // P 345 AnonymousType
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        var a = new { Name = "박상현", Age = 123 };
    //        Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");

    //        var b = new { Subject = "수학", Score = new int[] { 90, 80, 70, 60 } };
    //        Console.Write($"Subject:{b.Subject}, Score: ");
    //        foreach(var score in b.Score)
    //        {
    //            Console.Write($"{score} ");
    //        }
    //        Console.WriteLine();
    //    }
    //}



    // P348 PropertiesInInterface
    //interface INameValue
    //{
    //    string Name { get; set; }
    //    string Value { get; set; }
    //}

    //class NamedValue : INameValue
    //{
    //    public string Name { get; set; }
    //    public string Value { get; set; }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        NamedValue name = new NamedValue()
    //        { Name = "이름", Value = "박상현" };

    //        NamedValue height = new NamedValue()
    //        { Name = "키", Value = "177cm" };

    //        NamedValue weight = new NamedValue()
    //        { Name = "몸무게", Value = "90Kg" };

    //        Console.WriteLine($"{name.Name} : {name.Value}");
    //        Console.WriteLine($"{height.Name} : {height.Value}");
    //        Console.WriteLine($"{weight.Name} : {weight.Value}");
    //    }
    //}



    // P351 PropertiesInAbstractClass
    //abstract class Product
    //{
    //    private static int serial = 0;
    //    public string SerialID
    //    {
    //        get { return String.Format("{0:d5}", serial++); }
    //    }

    //    abstract public DateTime ProductDate
    //    {
    //        get; set;
    //    }
    //}

    //class MyProdut : Product
    //{
    //    public override DateTime ProductDate
    //    {
    //        get; set;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Product product_1 = new MyProdut()
    //        {
    //            ProductDate = new DateTime(2018, 1, 10)
    //        };

    //        Console.WriteLine("Prouct:{0}, Product Date : {1}", product_1.SerialID, product_1.ProductDate);

    //        Product product_2 = new MyProdut()
    //        {
    //            ProductDate = new DateTime(2018, 2, 3)
    //        };

    //        Console.WriteLine("Prouct:{0}, Product Date : {1}", product_2.SerialID, product_2.ProductDate);

    //    }
    //}



    // P353 연습문제1
    //class NameCard
    //{
    //    public int Age { get; set; }
    //    public string Name { get; set; }
    //}

    //class MainApp
    //{
    //    public static void Main()
    //    {
    //        NameCard MyCard = new NameCard();

    //        MyCard.Age = 24;
    //        MyCard.Name = "상현";

    //        Console.WriteLine("나이 : {0}", MyCard.Age);
    //        Console.WriteLine("이름 : {0}", MyCard.Name);

    //    }
    //}


    // P354 연습문제2
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        var nameCard = new { Name = "박상현", Age = "17" };
    //        Console.WriteLine("이름:{0}, 나이:{1}", nameCard.Name, nameCard.Age);

    //        var complex = new { Real = "2", Imaginary = "23" };
    //        Console.WriteLine("실제:{0}, 상상:{1}", complex.Real, complex.Imaginary);
    //    }
    //}



    // P359 ArraySample
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] scores = new int[5];
    //        scores[0] = 80;
    //        scores[1] = 74;
    //        scores[2] = 81;
    //        scores[3] = 90;
    //        scores[4] = 34;

    //        foreach (int score in scores)
    //            Console.WriteLine(score);

    //        int sum = 0;
    //        foreach (int score in scores)
    //            sum += score;

    //        int average = sum / scores.Length;

    //        Console.WriteLine($"Avarage Score : {average}");
    //    }
    //}




    // P363 InitializingArray
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        string[] array1 = new string[3] { "a", "b", "c" };
    //        Console.WriteLine("array1...");
    //        foreach (string greeting in array1)
    //            Console.WriteLine($"{greeting}");

    //        string[] array2 = new string[] { "a", "b", "c" };
    //        Console.WriteLine("array2...");
    //        foreach (string greeting in array2)
    //            Console.WriteLine($"{greeting}");

    //        string[] array3 =  { "a", "b", "c" };
    //        Console.WriteLine("array3...");
    //        foreach (string greeting in array3)
    //            Console.WriteLine($"{greeting}");
    //    }
    //}



    // P365 DerivedFromArray
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = new int[] { 10, 30, 20, 7, 1 };
    //        Console.WriteLine($"Type Of array : {array.GetType()}");
    //        Console.WriteLine($"Base type Of array : {array.GetType().BaseType}");
    //    }
    //}



    // P366 MoreOnArray
    //class MainApp
    //{
    //    private static bool CheckPassed(int score)
    //    {
    //        return score >= 60;
    //    }

    //    private static void Print(int value)
    //    {
    //        Console.Write($"{value} ");
    //    }

    //    static void Main(string[] args)
    //    {
    //        int[] scores = new int[] { 80, 74, 81, 90, 34 };

    //        foreach (int score in scores)
    //            Console.Write($"{score} ");
    //        Console.WriteLine();

    //        Array.Sort(scores);
    //        Array.ForEach<int>(scores, new Action<int>(Print));
    //        Console.WriteLine();

    //        Console.WriteLine($"Number of dimensions : {scores.Rank}");

    //        Console.WriteLine($"Binary Search : 81 is at " + $"{Array.IndexOf(scores, 90)}");

    //        Console.WriteLine($"Everyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

    //        int index = Array.FindIndex<int>(scores, (score) => score < 60);

    //        scores[index] = 61;
    //        Console.WriteLine($"Eveyone passed ? : " + $"{Array.TrueForAll<int>(scores, CheckPassed)}");

    //        Console.WriteLine("Old length of score : " + $"{scores.GetLength(0)}");

    //        Array.Resize<int>(ref scores, 10);
    //        Console.WriteLine($"New length of scores : {scores.Length}");

    //        Array.ForEach<int>(scores, new Action<int>(Print));
    //        Console.WriteLine();

    //        Array.Clear(scores, 3, 7);
    //        Array.ForEach<int>(scores, new Action<int>(Print));
    //        Console.WriteLine();

    //        int[] sliced = new int[3];
    //        Array.Copy(scores, 0, sliced, 0, 3);
    //        Array.ForEach<int>(sliced, new Action<int>(Print));
    //        Console.WriteLine();
    //    }
    //}



    // P374 2DArray
    class MainApp
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"[{i},{j}] : {arr[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
