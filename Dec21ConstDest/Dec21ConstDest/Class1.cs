using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21ConstDest
{
    public class Class1 : IDisposable// interface is used or implemeted 

    {
        private bool _disposed = false;
        public void Greeating(string name)
        {
            Console.WriteLine(string.Format("Hello from {0}", name));
        }
        ~Class1()
        {
            Console.WriteLine(" am destructor being called");
            Dispose(false);
        }
        public void Dispose()// belongs to IDisposable 
        {
            Dispose(true);
            GC.SuppressFinalize(this);// will stop Finalize now Dispose() works
        }
        public void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                { // clean obj= null

                }
                _disposed = true;
            }
        }
        static void Main(string[] args)
        {
            //Class1 c1 = new Class1();
            //Console.WriteLine("c1 object is created");
            //c1.Greeating("amit");
            //c1.Dispose();
            //c1 = null;
            //Console.WriteLine(" objects destroyed");
            //Console.ReadLine();
            using (Class1 c1 = new Class1())
            {
                Console.WriteLine("c1 object is created");
                c1.Greeating("amit");
                c1.Dispose();
                // c1 = null; 

            }// c1 become null 
        }
    }
}

