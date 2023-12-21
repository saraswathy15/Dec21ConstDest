using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21ConstDest
{
    public class Employee
    {
        int empId, ContactNo; string empName; double Salary;
        public Employee() { Console.WriteLine("no parameter C"); }
        public Employee(int id, string name, double pay) : this()
        {
            this.empId = id;
            this.empName = name;
            this.Salary = pay;
            Console.WriteLine("{0}\t{1}\t{2}", this.empId, this.empName, this.Salary);
        }// this will force to excute 10th line after inside current C
        public Employee(int id, string name, double pay, int cNo) : this(id, name, pay)
        {// force go to 11th line , after 11th completes inside 
            this.ContactNo = cNo;
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", this.empId, this.empName, this.Salary, this.ContactNo);
        }
        static Employee() { Console.WriteLine(" SC will execute before Main"); }
        static void Main(string[] args)
        {
            Employee emp;
            emp = new Employee(1, "amit", 9.99, 12345);//4 p C==>3 p C==> zero C , this keyword
                                                       //   emp = new Employee(2, "bala", 89);// 3 parameter
                                                       //   emp = new Employee();// no parameter C
            Console.ReadLine();

        }
    }
}
// public void Display() { Console.WriteLine(" am display ()"); }
//static void Disl() { }
