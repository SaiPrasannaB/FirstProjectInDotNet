using System;

namespace OOPS_Programing
{
    // Single/Simple Level inheritance
    class Inheritance
    {
        public void parentSingleMethod1()
        {
            Console.WriteLine("Parent Single Method1");
        }
    }
    class ClassSingleParent2 : Inheritance
    {
        public void parentSingleMethod2()
        {
            Console.WriteLine("Parent Single Method2");
        }
    }

    class Faculty
    {
        public static int basicSalary = 50000;
    }

    class DotNetFaculty : Faculty
    {
        public static int FacultyBonus = 10000;
    }

    //Multilevel inheritance

    class multiLevelFaculty
    {
        public static int basicSalary = 50000;
    }
    class multiLevelHRA : multiLevelFaculty
    {
        public static int HRA = basicSalary * 30 / 100;
    }
    class multiLevelDA : multiLevelHRA
    {
        public static int DA = basicSalary * 20 / 100;
    }
    class multiLevelTA : multiLevelDA
    {
        public static int TA = basicSalary * 10 / 100;
    }
    class multiLevelBonus : multiLevelTA
    {
        public static int Bonus = basicSalary * 5 / 100;
    }

    //Heirerachial inheritance

    class HeirerachialEmp
    {
        public static int basicSalary = 5000;
    }
    class HeirerachialVillEmp : HeirerachialEmp
    {
        public static int villageEmp = basicSalary * 11 / 100;
    }
    class HeirerachialCityEmp : HeirerachialEmp
    {
        public int CityEmp = basicSalary * 24 / 100;
    }

    //Multtiple inheritance
    class MultipleParent1
    {
        public void ParentMethod1()
        {
            Console.WriteLine("Multtiple inheritance Parent Method1");
        }
    }
    class MultipleParent2
    {
        public void ParentMethod2()
        {
            Console.WriteLine("Multtiple inheritance Parent Method2");
        }
    }
    class MultipleChild /*: MultipleParent1,MultipleParent2*/
    {
        public void ChildMethod()
        {
            Console.WriteLine("Multtiple inheritance Child Method");
        }
    }
    //Multiple Inheritance is not possible in C# dot net by using interfaces we can acheive multiple inheritance

    //Hybrid inheritance
    class HybridParent1
    {
        public void HybridParentMethod1()
        {
            Console.WriteLine("Hybrid Parent Method1");
        }
    }
    class HybridParent2
    {
        public void HybridParentMethod2()
        {
            Console.WriteLine("Hybrid Parent Method2");
        }
    }
    class HybridParentChild
    {
        public void HybridParentChildMethod()
        {
            Console.WriteLine("Hybrid Parent Child Method");
        }
    }

    //Method Overiding
    public class MethodOveriding1
    {
        virtual public void overrideMethod()
        {
            Console.WriteLine("123");
        }
    }
    public class MethodOveriding2 : MethodOveriding1
    {
        override public void overrideMethod()
        {
            Console.WriteLine("abc");
        }
    }

    //Method Overloading
    //Different Count of parameters
    class MethodOverloading
    {
        public void methodOverloadingMethod1(int add1, int add2)
        {
            Console.WriteLine(add1 + add2);
        }
        public void methodOverloadingMethod1(int add1, int add2, int add3)
        {
            Console.WriteLine(add1 + add2 + add3);
        }
        public void methodOverloadingMethod1(int add1, int add2, int add3, int add4)
        {
            Console.WriteLine(add1 + add2 + add3 + add4);
        }
    }

    //Different type of parameters
    class MethodOverloadingDifferentparams
    {
        public void methodOverloadingMethod2(int add1, int add2)
        {
            Console.WriteLine(add1 + add2);
        }
        public void methodOverloadingMethod2(int add1, double add2)
        {
            Console.WriteLine(add1 + add2);
        }
    }

    //Order of the parameters
    class MethodOverloadingDifferentOrder
    {
        public void methodOverloadingMethod3(double add1, int add2)
        {
            Console.WriteLine(add1 + add2);
        }
        public void methodOverloadingMethod3(int add1, double add2)
        {
            Console.WriteLine(add1 + add2);
        }
    }

    //Encapsulation
    class encapsulation
    {
        void method1()
        {

        }
        void method2()
        {

        }
    }

    //Abstraction
    abstract class Abstract
    {
        public abstract void AbstractMethod();
        public void NonAbstractMethod()
        {
            Console.WriteLine("NonAbstractMethod");
        }
    }

    class ChildAbstract2 : Abstract
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("AbstractMethod");
        }
    }

    abstract class EmployeeAbstract
    {
        public int AbstractEmpNo;
        public string AbstractEmpName;
        public string AbstractCompanyName;
        public void NonAbstractEmpInfo()
        {
            Console.WriteLine(AbstractEmpNo + " " + AbstractEmpName + " " + AbstractCompanyName);
        }
        public abstract void AbstractEmpSalary(double basicSalary);
    }

    class childRegularEmployeeAbstract : EmployeeAbstract
    {
        public override void AbstractEmpSalary(double basicSalary)
        {
            double hra = basicSalary * 30 / 100;
            double da = basicSalary * 20 / 100;
            double ta = basicSalary * 10 / 100;
            double totalSalary = basicSalary + hra + da + ta;
            Console.WriteLine($"Regular Employee Total Salary: {totalSalary}");
        }
    }
    class childContractEmployeeAbstract : EmployeeAbstract
    {
        public override void AbstractEmpSalary(double basicSalary)
        {
            double bonus = basicSalary * 3 / 100;
            double ta = basicSalary * 10 / 100;
            double totalSalary = basicSalary + bonus + ta;
            Console.WriteLine($"Contract Employee Total Salary: {totalSalary}");
        }
    }
    //Interface
    interface interfaceName
    {
        void interfaceMethod();
    }
    class interfaceClass : interfaceName
    {
        public void interfaceMethod()
        {
            Console.WriteLine("Interface Method Implementation");
        }
    }

    interface interfaceBank
    {
        void rateofInterest();
    }
    class SbiBank : interfaceBank
    {
        public void rateofInterest()
        {
            Console.WriteLine("ROI : 6%");
        }
    }
    class HdfcBank : interfaceBank
    {
        public void rateofInterest()
        {
            Console.WriteLine("ROI : 8%");
        }
    }

    //Multiple inheritance using interface
    interface parent1
    {
        void parentInterface();
    }
    interface parent2
    {
        void parentInterface2();
    }
    class child:parent1, parent2
    {
        public void parentInterface()
        {
            Console.WriteLine("Parent one interface in child class");
        }
        public void parentInterface2()
        {
            Console.WriteLine("Parent two interface in child class");
        }
    }

    //Method Conflict
    interface father
    {
        void house();
    }
    interface Mother
    {
        void house();
    }
    class child2:father,Mother
    {
        void father.house()
        {
            Console.WriteLine("Father Prop");
        }
        void Mother.house()
        {
            Console.WriteLine("Mother Prop");
        }
    }

    //class will give better performance and it has first priority
    interface prorityInterface
    {
        void interfaceM();
    }
    class priorityClass1
    {
        public void classMethod() { Console.WriteLine("class method"); }
    }

    class priorityClass: priorityClass1, prorityInterface
    {
        public void interfaceM()
        {
            Console.WriteLine("interface Method");
        }
    }

    //Partial Class
    partial class partialClass
    {
        partial void PartialMethod();
    }
    partial class partialClass
    {
        partial void PartialMethod()
        {
            Console.WriteLine("Partial Method");
        }
    }

    //Extension Methods
    public class extensionClass
    {
        public void extensionMethod()
        {
            Console.WriteLine("Extension Method1");
        }
    }
    public class extensionClass3
    {
        public void extensionMethod3()
        {
            Console.WriteLine("Extension Method3");
        }
    }
    static class extensionClass2
    {
        public static void extensionMethod2(this extensionClass e2, extensionClass3 e3)
        {
            Console.WriteLine("Extension Method2");
        }
    }
}