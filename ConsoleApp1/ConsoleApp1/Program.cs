using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FS = System.IO.FileStream;

namespace ConsoleApp1
{
    class MainApp
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

            using (Stream outStream = new FS("a.dat", FileMode.Create))
            {
                byte[] wBytes = BitConverter.GetBytes(someValue);

                Console.Write("{0,-13} : ", "Byte array");

                foreach (byte b in wBytes)
                    Console.Write("{0:X2} ", b);
                Console.WriteLine();

                outStream.Write(wBytes, 0, wBytes.Length);
            }

            FS fileStream = new FS("a.dat", FileMode.Open);

            Stream instream = fileStream;
            byte[] rbytes = new byte[8];

            int i = 0;
            while (instream.Position < instream.Length)
                rbytes[i++] = (byte)instream.ReadByte();

            long readValue = BitConverter.ToInt64(rbytes, 0);

            Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);

            // instream.Close();
        }
    }
}
