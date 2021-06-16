using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisisCSharp3
{
    // P 229 Constructor
    //class Cat
    // {
    //     public Cat()
    //     {
    //          Name = "";
    //          Color = "";
    //     }

    //     public Cat(string _Name, string _Color)
    //     {
    //         Name = _Name;
    //         Color = _Color;
    //     }

    //     ~Cat()
    //     {
    //         Console.WriteLine($"{Name} : 잘가");    
    //     }

    //     public string Name;
    //     public string Color;

    //     public void Meow()
    //     {
    //         Console.WriteLine($"{Name} : 야옹");
    //     }
    // }

    //class MainApp
    // {
    //     static void Main(string[] args)
    //     {
    //         Cat kitty = new Cat("키티", "하얀색");
    //         kitty.Meow();
    //         Console.WriteLine($"{kitty.Name} : {kitty.Color}");

    //         Cat nero = new Cat("네로", "검은색");
    //         nero.Meow();
    //         Console.WriteLine($"{nero.Name} : {nero.Color}");
    //     }
    // }



    // P232 StaticField
    //class Global
    //{
    //    public static int Count = 0;
    //}

    //class ClassA
    //{
    //    public ClassA()
    //    {
    //        Global.Count++;
    //    }
    //}

    //class ClassB
    //{
    //    public ClassB()
    //    {
    //        Global.Count++;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine($"Global.Count : {Global.Count}");

    //        new ClassA();
    //        new ClassA();
    //        new ClassB();
    //        new ClassB();

    //        Console.WriteLine($"Global.Count : {Global.Count}");
    //    }
    //}



    // P237 DeepCopy
    //class MyClass
    //{
    //    public int MyField1;
    //    public int MyField2;

    //    public MyClass DeepCopy()
    //    {
    //        MyClass newCopy = new MyClass();
    //        newCopy.MyField1 = this.MyField1;
    //        newCopy.MyField2 = this.MyField2;

    //        return newCopy;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Shallow Copy");

    //        {
    //            MyClass source = new MyClass();
    //            source.MyField1 = 10;
    //            source.MyField2 = 20;

    //            MyClass target = source;
    //            target.MyField2 = 30;

    //            Console.WriteLine($"{source.MyField1} {source.MyField2} ");
    //            Console.WriteLine($"{target.MyField1} {target.MyField2} ");
    //        }


    //        Console.WriteLine("Deep Copy");

    //        {
    //            MyClass source = new MyClass();
    //            source.MyField1 = 10;
    //            source.MyField2 = 20;

    //            MyClass target = source.DeepCopy();
    //            target.MyField2 = 30;

    //            Console.WriteLine($"{source.MyField1} {source.MyField2} ");
    //            Console.WriteLine($"{target.MyField1} {target.MyField2} ");
    //        }

    //    }        
    //}


    // P240 This
    //class Employee
    //{
    //    private string Name;
    //    private string Position;

    //    public void SetName(string Name)
    //    {
    //        this.Name = Name;
    //    }

    //    public string GetName()
    //    {
    //        return Name;
    //    }

    //    public void SetPosition(string Position)
    //    {
    //        this.Position = Position;
    //    }

    //    public string GetPosition()
    //    {
    //        return this.Position;
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Employee pooh = new Employee();
    //        pooh.SetName("Pooh");
    //        pooh.SetPosition("Waiter");
    //        Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

    //        Employee tigger = new Employee();
    //        tigger.SetName("tigger");
    //        tigger.SetPosition("Cleaner");
    //        Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
    //    }
    //}


    // P243 ThisContructor
    //class MyClass
    //{
    //    int a, b, c;

    //    public MyClass()
    //    {
    //        this.a = 654;
    //        Console.WriteLine("MyClass()");
    //    }

    //    public MyClass(int b) : this()
    //    {
    //        this.b = b;
    //        Console.WriteLine($"MyClass({b})");
    //    }

    //    public MyClass(int b, int c) : this(b)
    //    {
    //        this.c = c;
    //        Console.WriteLine($"MyClass({b}, {c})");
    //    }

    //    public void PrintFields()
    //    {
    //        Console.WriteLine($"a:{a}, b:{b}, c:{c}");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        MyClass a = new MyClass();
    //        a.PrintFields();
    //        Console.WriteLine();

    //        MyClass b = new MyClass(1);
    //        b.PrintFields();
    //        Console.WriteLine();

    //        MyClass c = new MyClass(10, 20);
    //        c.PrintFields();
    //    }
    //}


    // P247 AccessModifier
    //class WaterHeater
    //{
    //    protected int temperature;

    //    public void SetTemperature(int temperature)
    //    {
    //        if(temperature < -5 || temperature > 42)
    //        {
    //            throw new Exception("Out of temperature range");
    //        }

    //        this.temperature = temperature;
    //    }

    //    internal void TurnOnWater()
    //    {
    //        Console.WriteLine($"Turn on water : {temperature}");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            WaterHeater heater = new WaterHeater();
    //            heater.SetTemperature(20);
    //            heater.TurnOnWater();

    //            heater.SetTemperature(-2);
    //            heater.TurnOnWater();

    //            heater.SetTemperature(50);
    //            heater.TurnOnWater();
    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine(e.Message);
    //        }
    //    }
    //}


    // P253 Inheritance
    //class Base
    //{
    //    protected string Name;
    //    public Base(string Name)
    //    {
    //        this.Name = Name;
    //        Console.WriteLine($"{this.Name}.Base()");
    //    }

    //    ~Base()
    //    {
    //        Console.WriteLine($"{this.Name}.~Base()");
    //    }

    //    public void BaseMethod()
    //    {
    //        Console.WriteLine($"{Name}.BaseMethod()");
    //    }
    //}

    //class Derived : Base
    //{
    //    public Derived(string Name) : base(Name)
    //    {
    //        Console.WriteLine($"{this.Name}.Derived()");
    //    }

    //    ~Derived()
    //    {
    //        Console.WriteLine($"{this.Name}.~Derived()");
    //    }

    //    public void DerivedMethod()
    //    {
    //        Console.WriteLine($"{Name}.DerivedMethod()");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Base a = new Base("a");
    //        a.BaseMethod();

    //        Derived b = new Derived("b");
    //        b.BaseMethod();
    //        b.DerivedMethod();
    //    }
    //}



    // P258 TypeCasting
    //class Mammal
    //{
    //    public void Nurse()
    //    {
    //        Console.WriteLine("Nurese()");
    //    }
    //}

    //class Dog : Mammal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Bark()");
    //    }
    //}

    //class Cat : Mammal
    //{
    //    public void Meow()
    //    {
    //        Console.WriteLine("Meow()");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Mammal mammal = new Dog();
    //        Dog dog;

    //        if(mammal is Dog)
    //        {
    //            dog = (Dog)mammal;
    //            dog.Bark();
    //        }

    //        Mammal mammal2 = new Cat();

    //        Cat cat = mammal2 as Cat;
    //        if (cat != null)
    //            cat.Meow();

    //        Cat cat2 = mammal as Cat;
    //        if (cat2 != null)
    //            cat2.Meow();
    //        else
    //            Console.WriteLine("Cat2 is not a Cat");
    //    }
    //}



    // P262 Overriding
    //class ArmorSuite
    //{
    //    public virtual void Initialize()
    //    {
    //        Console.WriteLine("Armored");
    //    }
    //}

    //class IronMan : ArmorSuite
    //{
    //    public override void Initialize()
    //    {
    //        base.Initialize();
    //        Console.WriteLine("Repulsor Rays Armed");
    //    }
    //}

    //class WarMachine : ArmorSuite
    //{
    //    public override void Initialize()
    //    {
    //        base.Initialize();
    //        Console.WriteLine("Double-Barrel Cannons Armed");
    //        Console.WriteLine("Micro-Rocket Launcher Armed");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Creating ArmorSuite...");
    //        ArmorSuite armorsuite = new ArmorSuite();
    //        armorsuite.Initialize();

    //        Console.WriteLine("\nCreating IronMan...");
    //        ArmorSuite ironman = new IronMan();
    //        ironman.Initialize();

    //        Console.WriteLine("\nCreating WarMachine...");
    //        ArmorSuite warmachine = new WarMachine();
    //        warmachine.Initialize();
    //    }
    //}


    // P265 MehodHiding
    //class Base
    //{
    //    public void MyMethod()
    //    {
    //        Console.WriteLine("Base.MyMethod()");
    //    }
    //}

    //class Derived : Base
    //{
    //    public new void MyMethod()
    //    {
    //        Console.WriteLine("Derived.MyMethod()");
    //    }

    //    class MainApp
    //    {
    //        static void Main(string[] args)
    //        {
    //            Base baseObj = new Base();
    //            baseObj.MyMethod();

    //            Derived derivedObj = new Derived();
    //            derivedObj.MyMethod();

    //            Base basedOrDerived = new Derived();
    //            basedOrDerived.MyMethod();
    //        }
    //    }
    //}



    // P267 SealedMethod
    //class Base
    //{
    //    public virtual void SealMe()
    //    {

    //    }
    //}

    //class Derived : Base
    //{
    //    public sealed override void SealMe()
    //    {

    //    }
    //}

    //class WantToOverride : Derived
    //{
    //    public override void SealMe() // 오류
    //    {

    //    }
    //}


    P275 PartialClass
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }
    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }
        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
        }
    }




}
