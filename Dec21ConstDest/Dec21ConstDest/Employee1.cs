using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec21ConstDest
{
    public class Employee1
    {
        int empId, ContactNo; string empName; double Salary;
        public Employee1() { Console.WriteLine("no parameter C"); }
        public Employee1(int id, string name, double pay)
        {
            this.empId = id; this.empName = name; this.Salary = pay;
            Console.WriteLine("{0}\t{1}\t{2}", this.empId, this.empName, this.Salary);
        }
        public Employee1(int id, string name, double pay, int cNo)
        {
            this.empId = id; this.empName = name; this.Salary = pay;
            this.ContactNo = cNo;
            Console.WriteLine("{0}\t{1}\t{2}\t{3}", this.empId, this.empName, this.Salary, this.ContactNo);
        }
        static Employee1() { Console.WriteLine(" SC will execute before Main"); }
        static void Main(string[] args)
        {
            Employee1 emp1, emp2, emp3;
            emp1 = new Employee1(1, "amit", 9.99, 12345);//call line 15
            emp2 = new Employee1(2, "bala", 96666);// call line 11th
            emp3 = new Employee1();// calls 10 line
            Console.ReadLine();
        }
    }
}

