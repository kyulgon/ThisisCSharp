using System;
//using static System.Console;

namespace ThisisCSharp
{
    class MainApp
    {
        //static void Main(string[] args) // 프로그램 실행이 시작되는 곳
        //{
        //    P19
        //    if (args.Length == 0)
        //    {
        //        Console.WriteLine("사용법 : Hello.exe <이름>");
        //        return; // 밑에 코드 실행이 안됨
        //    }
        //    WriteLine("Hello, {0}!", args[0]); // Hello, World를 프롬프트에 출력  

        //    P39
        //    Console.WriteLine("여러분, 안녕하세요?");
        //    Console.WriteLine("반갑습니다!");
        //}



        // P49 데이터 형식에 따른 크기 확인하기
        //static void Main(string[] args)  
        //{
        //    sbyte a = -10;
        //    byte b = 40;
        //    Console.WriteLine($"a = {a}, b={b}");

        //    short c = -3000;
        //    ushort d = 6000;
        //    Console.WriteLine($"c = {c}, d={d}");

        //    int e = -10000000;
        //    uint f = 300000000;
        //    Console.WriteLine($"e = {e}, f={f}");

        //    long g = -500000000000;
        //    ulong h = 2000000000000000000;
        //    Console.WriteLine($"g = {g}, h={h}");
        //}



        // P51 각 진수에 따른 리터럴 확인
        //static void Main(string[] args)  
        //{
        //    byte a = 240; // 10진수 리터렬
        //    Console.WriteLine($"a={a}");

        //    byte b = 0b1111_0000; // 2진수 리터럴
        //    Console.WriteLine($"b={b}");

        //    byte c = 0XF0; // 16진수 리터럴
        //    Console.WriteLine($"c={c}");

        //    uint d = 0x1234_abcd; // 16진수 리터럴
        //    Console.WriteLine($"d={d}");
        //}


        // P54 보수 확인
        //static void Main(string[] args) 
        //{
        //    byte a = 255;
        //    sbyte b = (sbyte)a;

        //    Console.WriteLine(a);
        //    Console.WriteLine(b);

        //}

        // P55 Overflow
        //static void Main(string[] args)
        //{
        //    uint a = uint.MaxValue;

        //    Console.WriteLine(a);

        //    a += 1;
        //    Console.WriteLine(a);

        //}

        // P58 FloatingPoint
        //static void Main(string[] args)
        //{
        //    float a = 3.14159265358979323846f;
        //    Console.WriteLine(a);

        //    double b = 3.14159265358979323846;
        //    Console.WriteLine(b);
        //}



        // P60 Decimal
        //static void Main(string[] args)
        //{
        //    float a = 3.141592653589793238462643383279f;
        //    double b = 3.141592653589793238462643383279;
        //    decimal c = 3.141592653589793238462643383279m;

        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    Console.WriteLine(c);
        //}


        // P61 Char & String
        //static void Main(string[] args)
        //{
        //    char a = '안';
        //    char b = '녕';
        //    char c = '하';
        //    char d = '세';
        //    char e = '요';

        //    Console.Write(a);
        //    Console.Write(b);
        //    Console.Write(c);
        //    Console.Write(d);
        //    Console.Write(e);
        //    Console.WriteLine();

        //    string f = "안녕하세요";
        //    string g = "홍길동입니다.";

        //    Console.WriteLine(f);
        //    Console.WriteLine(g);
        //}




        // P67 Object
        //static void Main(string[] args)
        //{
        //    object a = 123;
        //    object b = 3.141592653545464545543m;
        //    object c = true;
        //    object d = "안녕하세요";

        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    Console.WriteLine(c);
        //    Console.WriteLine(d);
        //}



        // P69 BoxingUnboxing
        //static void Main(string[] args)
        //{
        //    int a = 123;
        //    object b = (object)a; // a에 담긴 값을 박싱해서 힙에 저장
        //    int c = (int)b; // b에 담긴 값을 언박싱해서 스택에 저장

        //    Console.WriteLine(a);
        //    Console.WriteLine(b);
        //    Console.WriteLine(c);

        //    double x = 3.1414231;
        //    object y = x; // x에 담긴 값을 박싱해서 힙에 저장
        //    double z = (double)y; // y에 담긴 값을 언박싱해서 스택에 저장

        //    Console.WriteLine(x);
        //    Console.WriteLine(y);
        //    Console.WriteLine(z);
        //}



        // P71 IntegralConversion
        //static void Main(string[] args)
        //{
        //    sbyte a = 127;
        //    Console.WriteLine(a);

        //    int b = (int)a;
        //    Console.WriteLine(b);

        //    int x = 128; // sbyte의 최대값 127보다 1 큰 수
        //    Console.WriteLine(x);

        //    sbyte y = (sbyte)x; // 오버플로가 발생
        //    Console.WriteLine(y);
        //}


        // P73 FloatConversion
        //static void Main(string[] args)
        //{
        //    float a = 69.6875f;
        //    Console.WriteLine("a = {0}", a);

        //    double b = (double)a;
        //    Console.WriteLine("b ={0}", b);
        //    Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

        //    float x = 0.1f;
        //    Console.WriteLine("x : {0}", x);

        //    double y = (double)x;
        //    Console.WriteLine("y : {0}", y);

        //    Console.WriteLine("0.1 == y : {0}", 0.1 == y);
        //}




        // P75 FloatToIntegral
        //static void Main(string[] args)
        //{
        //    float a = 0.9f;
        //    int b = (int)a;
        //    Console.WriteLine(b);

        //    float c = 1.1f;
        //    int d = (int)c;
        //    Console.WriteLine(d);
        //}




        // P77 StringNumberConverion
        //static void Main(string[] args)
        //{
        //    int a = 123;
        //    string b = a.ToString();
        //    Console.WriteLine(b);

        //    float c = 3.14f;
        //    string d = c.ToString();
        //    Console.WriteLine(d);

        //    string e = "123456";
        //    int f = Convert.ToInt32(e);
        //    Console.WriteLine(f);

        //    string g = "1.2345";
        //    float h = float.Parse(g);
        //    Console.WriteLine(h);
        //}

        
        // P82 Enum
        //enum DialogResult
        //{
        //    YES, NO, CANCEL, CONFIRM, OK
        //}

        //static void Main(string[] args)
        //{
        //    DialogResult result = DialogResult.YES;

        //    Console.WriteLine(result == DialogResult.YES);
        //    Console.WriteLine(result ==DialogResult.NO);
        //    Console.WriteLine(result == DialogResult.CANCEL);
        //    Console.WriteLine(result == DialogResult.CONFIRM);
        //    Console.WriteLine(result == DialogResult.OK);
        //}

        



        // P87 Nullable
        //static void Main(string[] args)
        //{
        //    int? a = null;
        //    Console.WriteLine(a.HasValue);
        //    Console.WriteLine(a != null);

        //    a = 3;

        //    Console.WriteLine(a.HasValue);
        //    Console.WriteLine(a != null);
        //    Console.WriteLine(a.Value);
        //}



        // P89 UsingVar
        //static void Main(string[] args)
        //{
        //    var a = 20;
        //    Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

        //    var b = 3.1414213;
        //    Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

        //    var c = "Hello, World!";
        //    Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

        //    var d = new int[] { 10, 20, 30, 40 };
        //    Console.Write("Type : {0}, Value : ", d.GetType());

        //    foreach(var e in d)
        //    {
        //        Console.Write("{0}" + " ", e);
        //    }

        //    Console.WriteLine();
        //}



        // P92 CTS
        //static void Main(string[] args)
        //{
        //    System.Int32 a = 123;
        //    int b = 456;

        //    Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a);
        //    Console.WriteLine("b type:{0}, value:{1}", b.GetType().ToString(), b);

        //    System.String c = "abc";
        //    string d = "def";

        //    Console.WriteLine("c type:{0}, value:{1}", c.GetType().ToString(), c);
        //    Console.WriteLine("d type:{0}, value:{1}", d.GetType().ToString(), d);
        //}




        // P94 StringSearch
        //static void Main(string[] args)
        //{
        //    string greeting = "Good Morning";

        //    Console.WriteLine(greeting);
        //    Console.WriteLine();

        //    // IndexOf()
        //    Console.WriteLine("Indexof 'Good' : {0}", greeting.IndexOf("Good"));
        //    Console.WriteLine("Indexof 'o' : {0}", greeting.IndexOf("o"));

        //    // LastIndexOf()
        //    Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
        //    Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

        //    // StartsWith()
        //    Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
        //    Console.WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

        //    // EndsWith()
        //    Console.WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
        //    Console.WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

        //    // Contains()
        //    Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
        //    Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

        //    // Replace()
        //    Console.WriteLine("Replaced 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
        //}





        // P96 StringModify
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("ToLower() : {0}", "ABC".ToLower());
        //    Console.WriteLine("ToUpper() : {0}", "abc".ToUpper());

        //    Console.WriteLine("Insert() : {0}", "Happy Friday!".Insert(5, "Sunny"));
        //    Console.WriteLine("Remove() : {0}", "I Don't Love You.".Remove(2, 6));

        //    Console.WriteLine("Trim() : {0}", "No Spaces ".Trim());
        //    Console.WriteLine("TrimStart() : {0}", " No Spaces ".TrimStart());
        //    Console.WriteLine("TrimEnd() : {0}", " No Spaces ".TrimEnd());

        //    string greeting = "Good morning.";

        //    Console.WriteLine(greeting.Substring(0, 5));
        //    Console.WriteLine(greeting.Substring(5));
        //    Console.WriteLine();

        //    string[] arr = greeting.Split(new string[] { " " }, StringSplitOptions.None);
        //    Console.WriteLine("Word Count : {0}", arr.Length);

        //    foreach (string element in arr)
        //    {
        //        Console.WriteLine("{0}", element);
        //    }

        //    string fmt = "{0,-20}{1,-15}{2,30}";

        //    Console.WriteLine(fmt, "Publisher", "Author", "Title");
        //}



        // P104 StringFormatNumber
        //static void Main(string[] args)
        //{
        //    // D : 10진수
        //    Console.WriteLine("10진수 : {0:D}", 123);
        //    Console.WriteLine("10진수 : {0:D5}", 123);

        //    // X : 16진수
        //    Console.WriteLine("16진수 : 0x{0:X}", 0xFF1234);
        //    Console.WriteLine("16진수 : 0x{0:X8}", 0xFF1234);

        //    // N : 숫자
        //    Console.WriteLine("숫자 : {0:N}", 123456789);
        //    Console.WriteLine("숫자 : {0:N0}", 123456789);

        //    // F : 고정소수점
        //    Console.WriteLine("고정소수점 : {0:F}", 123.456);
        //    Console.WriteLine("고정소수점 : {0:F5}", 123.456);

        //    // E : 공학용
        //    Console.WriteLine("공학 : {0:E}", 123.456789);
        //}



        // P111 String
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("사각형의 너비를 입력하세요.");
        //    string width = Console.ReadLine();

        //    Console.WriteLine("사각형의 높이를 입력하세요.");
        //    string height = Console.ReadLine();

        //    int result = int.Parse(width) * int.Parse(height);
        //    Console.WriteLine(result);
        //}



    }
}
