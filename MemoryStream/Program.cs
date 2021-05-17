using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Memory_Stream
{
    class MemoryStreamDemo
    {
        static void Main()
        {
            
            MemoryStream memoryStream = new MemoryStream(100);

           

            byte[] giorgi = Encoding.Default.GetBytes("Giorgi"); 
            byte[] giorgadze = Encoding.Default.GetBytes("Giorgadze");  

           
            memoryStream.Write(giorgi, 0, giorgi.Length);
            memoryStream.Write(giorgadze, 0, giorgadze.Length);

           
            Console.WriteLine("Capacity: {0} , Length: {1}",
                                  memoryStream.Capacity.ToString(),
                                  memoryStream.Length.ToString());

            
            Console.WriteLine("Position: " + memoryStream.Position);

           
            memoryStream.Seek(-9, SeekOrigin.Current);

           
            Console.WriteLine("Position: " + memoryStream.Position);

           
            byte[] vsBytes = Encoding.Default.GetBytes(" and ");
            
            memoryStream.Write(vsBytes, 0, vsBytes.Length);


        

            string data = Encoding.Default.GetString(memoryStream.GetBuffer());

          
            Console.WriteLine(data);

            Console.WriteLine();
            Console.WriteLine("Finish!");


            Console.ReadKey();


        }
    }

}
