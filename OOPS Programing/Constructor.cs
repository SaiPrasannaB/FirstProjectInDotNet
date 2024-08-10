using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Programing
{
    public class Constructor
    {
        //Parameter Constructor & This 
        int ConstParam0;
        int ConstParam01;
        public Constructor(int ConstParam1, int ConstParam2)
        {
            this.ConstParam0 = ConstParam1;
            this.ConstParam01 = ConstParam2;
            Console.WriteLine(ConstParam1 + ConstParam2);
        }
        public void calculations()
        {
            int i = this.ConstParam0 + 20;
            Console.WriteLine(i);
        }

        //Constructor Chaining + Different Count of Parameters(Constructor OverLoading)
        //public Constructor()
        //{
        //    Console.WriteLine("No Param Constructor");
        //}
        public Constructor(string ConstParameter)
        {
            //new Constructor();
            Console.WriteLine("Single Param Constructor");
        }
        public Constructor(String ConstParameter1, String ConstParameter2) : this("sai")
        {
            Console.WriteLine("Two Parameters");
        }

        //Constructor OverLoading

        //Different Type of Parameters
        //public Constructor(int oneConst, string OneConst){ }
        /*public Constructor(int SecConst, string SecConst){ }*/ // Same data type with different Varaibale names it is not possible
        public Constructor(float ThirdConst, string OneConst) { }

        //Order of the Parameters
        public Constructor(float orderParam1, int OrderParam2) { }
        public Constructor(int orderParam1, float OrderParam2) { }

        //Copy Constructor contains data
        public int empId;
        public string empName;
        public Constructor(int empId, string empName)
        {
            this.empId = empId;
            this.empName = empName;
            Console.WriteLine("Employee Copy Constructor: "+empId + " " + empName);
        }

        //Static Constructor
        //public Constructor()
        //{
        //    Console.WriteLine("Public");
        //}
        //static Constructor()
        //{
        //    Console.WriteLine("Static Constructor");
        //}
    }

    //Copy Constructor Class getting data from another class
    class Manager
    {
        public int Empno;
        public string Ename;
        public Manager(Constructor copyConst)
        {
            this.Empno = copyConst.empId;
            this.Ename = copyConst.empName;
            Console.WriteLine("Manager Copy Constructor: "+Empno + " " + Ename);
        }
    }
}
