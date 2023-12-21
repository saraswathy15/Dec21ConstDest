using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21ConstDest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(""))
            {
                sw.WriteLine();
                sw.Close();// any junk in stream is thrown out 
                           //  sw = null;// making it as null no value
            }// here sw object released
           
            Directory.CreateDirectory("D:\\Mphasis\\hello");
            Directory.Delete("D:\\Mphasis\\hello");
            DateTime dt1 = Directory.GetCreationTime("D:\\Mphasis\\hello");
            Console.WriteLine(dt1);
            //for (int i = 0; i < 10; i++)
            //{// print hello 10 times
            //    Console.WriteLine("hello "+i);
            //   // Console.WriteLine(i);
            //}
            //int[] nums = { 10, 20, 30, 40,100 };
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //    // Console.WriteLine(item);
            //}
        }
    }
}

