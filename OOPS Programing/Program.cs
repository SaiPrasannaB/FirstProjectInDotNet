using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Programing
{
    internal class Program
    {
        //Class Variables

        static int staticVariable = 100; //Static Variable
        int instanceVariable = 100; //Instance Variable
        void add(int param1,int param2)//Method Parameters
        {
            Console.WriteLine("Method Parameter: "+param1 + param2);//Method parameter can perform operations in main method
            //Local Variables will perform operation in same method
            int a = 100;
            int b = 100;
            int c = a+b;
        }

        //*******************************************************************************************************

        //Calculate Employee Total Salary

        static string companyName = "HealthEdge"; //Static Variable
        // Instance Variables
        int employeeID; 
        string employeeName;
        long phoneNumber;
        string address;
        double totalSalary;
        public void calculateTotalSalary(double basicsalary)
        {
            double hra = basicsalary * 30 / 100;//30000 Local Variable Calculations
            double da= basicsalary * 20/100;//20000 Local Variable Calculations
            double ta=basicsalary * 10/100;//10000 Local Variable Calculations
            totalSalary = basicsalary+ hra+da+ta;
            Console.WriteLine(employeeID + " " + employeeName + " " + phoneNumber + " " + address + " " + totalSalary);
        }

        //*******************************************************************************************************

        //Static Variable - Sharable 

        static int sharable=100;
        public static void sharableMethod() //Static Method
        {
            sharable = sharable + 100;
            Console.WriteLine(sharable);
        }
        public void sharableMethod2()
        {
            sharable = sharable + 100;
            Console.WriteLine(sharable);
        }


        //*******************************************************************************************************

        //Instance Variable - Non-sharable 

        int nonsharable = 100;
        public void nonSharableMethod() //instance Method
        {
            nonsharable = nonsharable + 100;
            Console.WriteLine(nonsharable);
        }

        //*******************************************************************************************************

        // Void Return Type: no return type

         void voidreturn()
        {
            int void1 = 10;
            int void2 = 20;
            Console.WriteLine("Int Void Return Type:"+(void1+void2));
            string void3 = "10";
            string void4 = "20";
            Console.WriteLine("string Void Return Type:" + (void3 + void4));
        }
        void voidreturn1(int void5,int void6)
        {
            Console.WriteLine("void method parameter return type:"+(void5 + void6));
        }
        //*******************************************************************************************************
        //With Return Type:return type should be int
        int intreturn()
        {
            string intreturn1 = "100";
            string intreturn2 = "200";
            string intreturn3=intreturn1 + intreturn2;
            return int.Parse(intreturn3);
        }
        //*******************************************************************************************************

        //Default Constructor
        int defualtValueofInt;

        void defaultConstructor()
        {
            Console.WriteLine("defaultConstructor");
        }

        //*******************************************************************************************************
        //Parameterless Constructor
        //Program()
        //{
        //    Console.WriteLine("Parameter less constructor");
        //}
         static Program()
        {
            Console.WriteLine("Parameter less constructor");
        }

        static void Main()
        {
            //Class Variables

            Program.staticVariable = 10; // Acessing static variable with class name, we cannot create object for static variables 
            Program instance = new Program();
            instance.instanceVariable = 10; // Acessing Instance variable with class object, we cannot acess with class name
            instance.add(1, 2);//Acessing Method Parameters with class object

            //*******************************************************************************************************

            // Employee Total Salary

            Program employee1 = new Program();
            employee1.employeeID = 10871;
            employee1.employeeName = "Sai Prasanna";
            employee1.phoneNumber = 9951727015;
            employee1.address = "Vijayawada";
            employee1.calculateTotalSalary(100000);

            //*******************************************************************************************************

            //static variable will point to same memory location, so the value will be increment every time

            //Static Variable - Sharable 
            Program.sharableMethod();//200
            Program.sharableMethod();//300
            Program sharableObj=new Program();
            sharableObj.sharableMethod2();//400
            Program sharableObj2 = new Program();
            sharableObj2.sharableMethod2();//500
            sharableObj2.sharableMethod2();


            //*******************************************************************************************************

            //While we create new object then it will point to new memory location

            //Inastance Variable - Non-sharable 
            Program instanceObj=new Program();
            instanceObj.nonSharableMethod();//200
            instanceObj.nonSharableMethod();//300
            Program instanceObj1 = new Program();
            instanceObj1.nonSharableMethod();//200
            Program instanceObj2 = new Program();
            instanceObj2.nonSharableMethod();//200

            //*******************************************************************************************************

            // Void Return Type: no return type

            Program voidObj = new Program();
            voidObj.voidreturn();
            voidObj.voidreturn1(10, 20);

            //*******************************************************************************************************
            //With Return Type:return type should be int
            Program intreturnObj=new Program();
            int intReturn4=intreturnObj.intreturn();
            Console.WriteLine("Return type of int"+intReturn4);

            //*******************************************************************************************************
            //Default Constructor
            Console.WriteLine("**Default Constructor**");
            Program intdefaultValue =new Program();
            Console.WriteLine(intdefaultValue.defualtValueofInt);
            Program defaultConstrucor=new Program();
            defaultConstrucor.defaultConstructor();
            new Program().defaultConstructor(); // other way to access

            //*******************************************************************************************************
            //Parameterless Constructor

            Program parameterlessConstrucor = new Program(); 
            //*******************************************************************************************************
            //Parameter Construcor

            Console.WriteLine();
            Console.WriteLine("*Parameter Constructor*");
            Constructor ParamConstructor=new Constructor(100,200);
            new Constructor(10, 20);
            
            //This 
            
            ParamConstructor.calculations();
            
            //Constructor Chaining
            
            //new Constructor();
            new Constructor("sai");
            new Constructor("sai","Sai");

            //Copy Constructor
            new Constructor(10, "Sai");
            Constructor empCopy = new Constructor(100,"Sai");
            Manager mgrCopy=new Manager(empCopy);
            //*******************************************************************************************************
            //Destructor
            Destructor destructor=new Destructor();
            //*******************************************************************************************************
           
            //Inheritance
            Console.WriteLine("**Single/Simple Level inheritance**");
            Inheritance single=new Inheritance();
            single.parentSingleMethod1();
            ClassSingleParent2 single1=new ClassSingleParent2();
            single1.parentSingleMethod1();
            single1.parentSingleMethod2();
            Console.WriteLine(DotNetFaculty.basicSalary);
            Console.WriteLine(DotNetFaculty.FacultyBonus);
            Console.WriteLine(DotNetFaculty.basicSalary+DotNetFaculty.FacultyBonus);

            Console.WriteLine("**Multi Level inheritance**");
            Console.WriteLine("Basic Salary:" + multiLevelBonus.basicSalary);
            Console.WriteLine("Basic Salary:" + multiLevelBonus.HRA);
            Console.WriteLine("Basic Salary:" + multiLevelBonus.DA);
            Console.WriteLine("Basic Salary:" + multiLevelBonus.TA);
            Console.WriteLine("Basic Salary:" + multiLevelBonus.Bonus);
            Console.WriteLine("Basic Salary:" + (multiLevelBonus.basicSalary+ multiLevelBonus.HRA+ multiLevelBonus.DA + multiLevelBonus.TA + multiLevelBonus.Bonus));

            Console.WriteLine("**Hirerachial Level inheritance**");
            Console.WriteLine("Village Employee Basic Salary: "+(HeirerachialVillEmp.basicSalary+ HeirerachialVillEmp.villageEmp));
            HeirerachialCityEmp city = new HeirerachialCityEmp();
            Console.WriteLine("City Employee Basic Salary: "+(HeirerachialCityEmp.basicSalary+ city.CityEmp));

            Console.WriteLine("**Method Overriding**");
            MethodOveriding1 mo;//mo is super class ref
            mo = new MethodOveriding2();// new MethodOveriding2() sub class object
            mo.overrideMethod();
            //or
            MethodOveriding1 m = new MethodOveriding2(); 
            m.overrideMethod();

            Console.WriteLine("**Method Overloading**");
            MethodOverloading moM = new MethodOverloading();
            moM.methodOverloadingMethod1(10, 20);
            moM.methodOverloadingMethod1(10, 20,30);
            moM.methodOverloadingMethod1(10, 20,30,40);
            MethodOverloadingDifferentparams momDp= new MethodOverloadingDifferentparams(); 
            momDp.methodOverloadingMethod2(10,20);
            momDp.methodOverloadingMethod2(10,20);
            MethodOverloadingDifferentOrder moldo=new MethodOverloadingDifferentOrder();
            moldo.methodOverloadingMethod3(10.1,20);
            moldo.methodOverloadingMethod3(10,20.0);

            Console.WriteLine("**Absraction**");
            ChildAbstract2 abstract2 = new ChildAbstract2();
            abstract2.AbstractMethod();
            abstract2.NonAbstractMethod();
            //Upcasting: We can access only super class info
            Abstract @abstract = new ChildAbstract2();
            @abstract.AbstractMethod();
            @abstract.NonAbstractMethod();

            EmployeeAbstract e1=new childRegularEmployeeAbstract();
            e1.AbstractEmpNo = 10871;
            e1.AbstractEmpName = "Sai Prasanna";
            e1.AbstractCompanyName = "HealthEdge";
            e1.NonAbstractEmpInfo();
            e1.AbstractEmpSalary(500);
            EmployeeAbstract e2 = new childContractEmployeeAbstract();
            e1.NonAbstractEmpInfo();
            e2.AbstractEmpSalary(500);

            Console.WriteLine("**Interface**");
            interfaceClass @interface=new interfaceClass();
            @interface.interfaceMethod();
            //or
            //Interface Upcasting : by using upcasting we can access only interface methods
            interfaceName in1=new interfaceClass();
            in1.interfaceMethod();
            interfaceBank ib = new SbiBank();
            ib.rateofInterest();
            interfaceBank ib2 = new HdfcBank();
            ib2.rateofInterest();

            //Multiple inheritance using interface
            parent1 p1 = new child();
            p1.parentInterface();
            parent2 p2=new child();
            p2.parentInterface2();

            //Method Conflict
            father f = new child2();
            f.house();
            Mother m2 = new child2();
            m2.house();

            priorityClass pc=new priorityClass();
            pc.interfaceM();
            pc.classMethod();

            //Extension Methods
            extensionClass e = new extensionClass();
            e.extensionMethod();
            e.extensionMethod2();

        }
    }
}
