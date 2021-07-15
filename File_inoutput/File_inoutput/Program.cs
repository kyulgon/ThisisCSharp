using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FS = System.IO.FileStream;
using System.Runtime.Serialization.Formatters.Binary;

namespace File_inoutput
{
    // P607 Dir
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string directory;
    //        if (args.Length < 1)
    //            directory = ".";
    //        else
    //            directory = args[0];

    //        Console.WriteLine($"{directory} directory Info");
    //        Console.WriteLine("- Directories :");
    //        // 하위 디렉토리 목록 조회
    //        var directories = (from dir in Directory.GetDirectories(directory)
    //                           let info = new DirectoryInfo(dir)// let은 LINQ 안에서 변수를 만듦. LINQ의 var
    //                           select new
    //                           {
    //                               Name = info.Name,
    //                               Attributes = info.Attributes
    //                           }).ToList();

    //        foreach (var d in directories)
    //            Console.WriteLine($"{d.Name} : {d.Attributes}");


    //        // 하위 파일 목록 조회
    //        Console.WriteLine("- Files :");
    //        var files = (from file in Directory.GetFiles(directory)
    //                     let info = new FileInfo(file) // let은 LINQ 안에서 변수를 만듦. LINQ의 var
    //                     select new
    //                     {
    //                         Name = info.Name,
    //                         FileSize = info.Length,
    //                         Attribute = info.Attributes
    //                     }).ToList();

    //        foreach (var f in files)
    //            Console.WriteLine($"{f.Name} : {f.FileSize}, {f.Attribute}");

    //    }
    //}



    // P609 Touch
    //class MainApp
    //{
    //    static void OnWrongPathType(string type)
    //    {
    //        Console.WriteLine($"{type} is wrong type");
    //        return;
    //    }

    //    static void Main(string[] args)
    //    {
    //        if (args.Length == 0)
    //        {
    //            Console.WriteLine("Usage : Touch.exe <Path> [Type:File/Directory]");
    //            return;
    //        }

    //        string path = args[0];
    //        string type = "File";

    //        if (args.Length > 1)
    //            type = args[1];

    //        if (File.Exists(path) || Directory.Exists(path))
    //        {
    //            if (type == "File")
    //                File.SetLastWriteTime(path, DateTime.Now);
    //            else if (type == "Directory")
    //                Directory.SetLastWriteTime(path, DateTime.Now);
    //            else
    //            {
    //                OnWrongPathType(path);
    //                return;
    //            }
    //            Console.WriteLine($"Updated {path} {type}");
    //        }
    //        else
    //        {
    //            if (type == "File")
    //                File.Create(path).Close();
    //            else if (type == "Directory")
    //                Directory.CreateDirectory(path);
    //            else
    //            {
    //                OnWrongPathType(path);
    //                return;
    //            }
    //            Console.WriteLine($"Created {path} {type}");
    //        }
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        FileStream fsa = File.Create("a.txt");
    //        FileInfo file = new FileInfo("b.txt");
    //        FileStream fsb = file.Create();

    //        fsa.Close();
    //        fsb.Close();
    //        File.Copy("a.txt", "c.txt");
    //        FileInfo dst = file.CopyTo("d.txt");
    //    }
    //}


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StreamWriter sw = new StreamWriter("a.txt");
    //        sw.Write("sw.Write()");
    //        sw.Write("  sw.Write()");
    //        sw.WriteLine(" sw.WriteLine()");
    //        sw.WriteLine("sw.WriteLine()");

    //        sw.Close();

    //        // StreamReader
    //        StreamReader sr = new StreamReader("a.txt");

    //        while(sr.Peek() >= 0)
    //        {
    //            Console.WriteLine(sr.ReadLine());
    //        }
    //        sr.Close();
    //    }
    //}



    // P617 BasicIO
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        long someValue = 0x123456789ABCDEF0;
    //        Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

    //        Stream outStream = new FileStream("a.dat", FileMode.Create);
    //        byte[] wBytes = BitConverter.GetBytes(someValue);

    //        Console.Write("{0,-13} : ", "Byte array");

    //        foreach (byte b in wBytes)
    //            Console.Write("{0:X2} ", b);
    //        Console.WriteLine();

    //        outStream.Write(wBytes, 0, wBytes.Length);
    //        outStream.Close();

    //        Stream insStream = new FileStream("a.dat", FileMode.Open);
    //        byte[] rbytes = new byte[8];

    //        int i = 0;
    //        while (insStream.Position < insStream.Length)
    //            rbytes[i++] = (byte)insStream.ReadByte();

    //        long readValue = BitConverter.ToInt64(rbytes, 0);

    //        Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
    //        insStream.Close();
    //    }
    //}


    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Stream outStream = new FileStream("a.dat", FileMode.Create);
    //        Console.WriteLine($"Position : {outStream.Position}");

    //        outStream.WriteByte(0x01);
    //        Console.WriteLine($"Position : {outStream.Position}");

    //        outStream.WriteByte(0x02);
    //        Console.WriteLine($"Position : {outStream.Position}");

    //        outStream.WriteByte(0x03);
    //        Console.WriteLine($"Position : {outStream.Position}");

    //        outStream.Seek(5, SeekOrigin.Current);
    //        Console.WriteLine($"Position : {outStream.Position}");

    //        outStream.WriteByte(0x04);
    //        Console.WriteLine($"Position : {outStream.Position}");

    //        outStream.Close();
    //    }
    //}


    // P624 UsingDeclaration
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        long someValue = 0x123456789ABCDEF0;
    //        Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

    //        using (Stream outStream = new FS("a.dat", FileMode.Create))
    //        {
    //            byte[] wBytes = BitConverter.GetBytes(someValue);

    //            Console.Write("{0,-13} : ", "Byte array");

    //            foreach (byte b in wBytes)
    //                Console.Write("{0:X2} ", b);
    //            Console.WriteLine();

    //            outStream.Write(wBytes, 0, wBytes.Length);
    //        }

    //        using Stream instream = new FS("a.dat", FileMode.Open);
    //        byte[] rbytes = new byte[8];

    //        int i = 0;
    //        while (instream.Position < instream.Length)
    //            rbytes[i++] = (byte)instream.ReadByte();

    //        long readValue = BitConverter.ToInt64(rbytes, 0);

    //        Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
    //    }
    //}



    // P627 BinaryFile
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        using (BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create)))
    //        {
    //            bw.Write(int.MaxValue);
    //            bw.Write("Good morning");
    //            bw.Write(uint.MaxValue);
    //            bw.Write("안녕하세요!");
    //            bw.Write(double.MaxValue);
    //        }

    //        BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

    //        Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
    //        Console.WriteLine($"{br.ReadInt32()}");
    //        Console.WriteLine($"{br.ReadString()}");
    //        Console.WriteLine($"{br.ReadUInt32()}");
    //        Console.WriteLine($"{br.ReadString()}");
    //        Console.WriteLine($"{br.ReadDouble()}");

    //        br.Close();
    //    }
    //}


    
    // P630 TextFile
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        using (StreamWriter sw = new StreamWriter(new FileStream("a.txt", FileMode.Create)))
    //        {
    //            sw.WriteLine(int.MaxValue);
    //            sw.WriteLine("Good morning");
    //            sw.WriteLine(uint.MaxValue);
    //            sw.WriteLine("안녕하세요!");
    //            sw.WriteLine(double.MaxValue);
    //        }
    //        using (StreamReader sr = new StreamReader(new FileStream("a.txt", FileMode.Open)))
    //        {
    //            Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

    //            while (sr.EndOfStream == false)
    //            {
    //                Console.WriteLine(sr.ReadLine());
    //            }
    //        }
    //    }      
    //}



    // P635 Serialization
    //[Serializable]
    //class NameCard
    //{
    //    public string Name;
    //    public string Phone;
    //    public int Age;
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {

    //        using (Stream ws = new FileStream("ab.dat", FileMode.Create))
    //        {
    //            BinaryFormatter serializer = new BinaryFormatter();

    //            NameCard nc = new NameCard();
    //            nc.Name = "김율곤";
    //            nc.Phone = "010-1234-5678";
    //            nc.Age = 27;

    //            serializer.Serialize(ws, nc);
    //        }

    //        Stream rs = new FileStream("a.dat", FileMode.Open);
    //        BinaryFormatter deserializer = new BinaryFormatter();

    //        NameCard nc2;
    //        nc2 = (NameCard)deserializer.Deserialize(rs);

    //        Console.WriteLine($"Name: {nc2.Name}");
    //        Console.WriteLine($"Phone: {nc2.Phone}");
    //        Console.WriteLine($"Age: {nc2.Age}");

    //        rs.Close();
    //    }
    //}



    // P637 SerializingCollection
    //[Serializable]
    //class NameCard
    //{
    //    public NameCard(string Name, string Phone, int Age)
    //    {
    //        this.Name = Name;
    //        this.Phone = Phone;
    //        this.Age = Age;
    //    }

    //    public string Name;
    //    public string Phone;
    //    public int Age;
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        using (Stream ws = new FileStream("a.dat", FileMode.Create))
    //        {
    //            BinaryFormatter serializer = new BinaryFormatter();

    //            List<NameCard> list = new List<NameCard>();
    //            list.Add(new NameCard("김", "010-1111-1111", 11));
    //            list.Add(new NameCard("율", "010-2222-1111", 22));
    //            list.Add(new NameCard("곤", "010-3333-1111", 1331));

    //            serializer.Serialize(ws, list);
    //        }

    //        Stream rs = new FileStream("a.dat", FileMode.Open);
    //        BinaryFormatter deserializer = new BinaryFormatter();

    //        List<NameCard> list2;
    //        list2 = (List<NameCard>)deserializer.Deserialize(rs);

    //        foreach(NameCard nc in list2)
    //        {
    //            Console.WriteLine($"Name: {nc.Name}, Phone: {nc.Phone}, Age: {nc.Age}");
    //        }

    //        rs.Close();
    //    }
    //}
}
