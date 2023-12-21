using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21ConstDest
{
    public class ABC1
    {
        public ABC1() { Console.WriteLine("abc 1 constructor "); }
        // ~ABC1(){ Console.WriteLine("destcructor of abc1"); }
    }
    public class ABC2 : ABC1 { public ABC2() { Console.WriteLine("ABC 2 Constructor "); } ~ABC2() { Console.WriteLine("ABC2 Destructor"); } }
    public class ABC3 : ABC2
    {
        public ABC3()
        {
            Console.WriteLine("ABC 3 Constructor ");
        }
        ~ABC3() { Console.WriteLine("ABC3 Destructor "); }
        static void Main(string[] args)
        {
            Console.WriteLine(" all abc1,abc2,abc3 object are creating");
            ABC3 obj = new ABC3();// will call its constructor abc1,abc2,abc3 call
            obj = null;// it is unused object 
            Console.WriteLine(" we are about release objects ");
            Console.WriteLine("released memory ");
            // GC.Collect();//call finalize()-> destructors are called abc3,abc2,abc1
            Console.ReadLine();
        }// throu destructor how finalize is performing 
    }
}
