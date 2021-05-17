using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Stream
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string path = @"F:\SomeDir2";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }

           

            using (Stream fStream = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate))
            {

                byte[] bytes = new byte[] { 95, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 };
                //{'H','e','l','l','o',' ','W','o','r','l','d'}.
                fStream.Write(bytes, 0, bytes.Length);

                fStream.WriteByte(33); //=!

                Console.WriteLine("Text is write");
            } 


            
            using (Stream fStream = File.OpenRead($"{path}\\note.txt"))
            {
                
                byte[] byteS = new byte[fStream.Length];

                fStream.Read(byteS, 0, byteS.Length);
                
                string textFromFile = Encoding.Default.GetString(byteS);
                Console.WriteLine($"Text in file: {textFromFile}");
            }

             

            Console.ReadKey();
        }
    }
}
