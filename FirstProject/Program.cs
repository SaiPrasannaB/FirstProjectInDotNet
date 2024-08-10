using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace FirstProject
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("First Program in Dot Net");
            Console.WriteLine("-------------------------");

            /**************************************************************************************************/

            // DLL File
            Console.WriteLine("Output of DLL Reference File");
            DllClass dll = new DllClass();
            dll.DllMethod();

            /**************************************************************************************************/

            // *Integer Data Type*
            Console.WriteLine("-------------------------");
            Console.WriteLine("Integer Data Type");
            Console.WriteLine();

            int i;
            i = new int();//new int() is constructor
            Console.WriteLine(i);
            i = default;
            Console.WriteLine(i);
            i = int.MaxValue;
            Console.WriteLine("Max Value " + i);//Max value of int--Upper bound
            Console.WriteLine(i + 1);//Min value of integer
            i = int.MinValue;
            Console.WriteLine("Min Value " + i);//Min Value of int--Lower Bound
            Console.WriteLine(i - 1);//It will give max value
            Console.WriteLine(int.MinValue + 1);
            Console.WriteLine(int.MaxValue - 1);
            i = 'A';
            Console.WriteLine("ASCII Value of A : " + i);//it will diaplay ascii value
            int? i1 = null;//non nullable
            Console.WriteLine(i1);
            //int i2 = null;

            /**************************************************************************************************/

            // *Double Data Type*
            /* 1.Double only accepts 8 bytes of Memory
               2.It also accepts Single Character
            */
            Console.WriteLine("-------------------------");
            Console.WriteLine("Double Data Type");
            Console.WriteLine();

            double d = 1;
            Console.WriteLine(d);
            d = 100.0;
            Console.WriteLine(d);
            d = 1.0002;
            Console.WriteLine(d);
            d = 'A';
            Console.WriteLine("Ascii value for double: " + d);
            double d2 = default;
            Console.WriteLine("Default Value of Double " + d2);
            double d3 = new Double();
            Console.WriteLine("Default Value of Double " + d3);
            d = double.MaxValue;
            Console.WriteLine("Max Value of Double " + d);
            d = double.MinValue;
            Console.WriteLine("Min Value of Double " + d);
            d = 100.2;
            Console.WriteLine(d);
            double? d1 = null;
            Console.WriteLine(d1);

            // d = "10";
            // d1 = '10';
            // d = "A";
            // d = 'abc';
            //d = false;
            //d = null;


            /**************************************************************************************************/

            // *Float Data Type*

            /* 1.Float only accepts 4 bytes of Memory
               2.It also accepts Single Character
               3.At the end of the value we need to give the suffix f(Ex:100.2f) 
            */
            Console.WriteLine("-------------------------");
            Console.WriteLine("Float Data Type");
            Console.WriteLine();
            float f = 1;
            Console.WriteLine(f);
            f = '1';
            f = 100.0f;
            Console.WriteLine(f);
            f = (float)100.0;
            Console.WriteLine(f);
            f = 1.0002f;
            Console.WriteLine(f);
            f = 'A';
            Console.WriteLine("Ascii Value for float: " + f);
            float f1 = default;
            Console.WriteLine("Default Value of Float " + f1);
            float f2 = new float();
            Console.WriteLine("Default Value of Float " + f2);
            f = float.MaxValue;
            Console.WriteLine("Max Value of Float " + f);
            f = float.MinValue;
            Console.WriteLine("Min Value of Float " + f);
            float? f3 = null;
            Console.WriteLine(f3);

            // f = "A";
            // f = 'abc';
            //f = false;
            //f = null;
            // f = "10";

            /**************************************************************************************************/

            /* Char Data type*/
            /*1.Char data type does not supports concatination*/

            Console.WriteLine("-------------------------");
            Console.WriteLine("Char Data Type");
            Console.WriteLine();
            char c = 'A';
            Console.WriteLine(c);
            char c3 = 'B';
            Console.WriteLine(c3);
            Console.WriteLine("Output of A & B: " + (c + c3));
            Console.WriteLine(c - c3);
            char c1 = default;
            Console.WriteLine("Default Value of Char: " + (c1));
            char c7 = '\0';
            Console.WriteLine(c1 == c7);
            char? c2 = null;
            Console.WriteLine(c2);
            char c5 = '0';
            char c6 = '0';
            Console.WriteLine(c5 + c6);

            //c = 'abc';
            //c = 100;
            //c = 100.0;
            //c = "100";
            //c = '1';
            //c = "A";
            //c = true;
            //char c1=null;

            /**************************************************************************************************/

            /* Bool Data type*/

            Console.WriteLine("-------------------------");
            Console.WriteLine("Bool Data Type");
            Console.WriteLine();
            bool b4 = true;
            Console.WriteLine(b4);
            b4 = false;
            Console.WriteLine(b4);
            bool? b6 = null;
            Console.WriteLine(b6);
            b6 = new bool();
            Console.WriteLine(b6);

            //bool b6 = 0;
            //bool b = 'A';
            //bool b1 = '1';
            //bool b2 = "A";
            //bool b3 = "100";
            //bool b5 = null;

            /**************************************************************************************************/

            // *String Data Type*
            Console.WriteLine("-------------------------");
            Console.WriteLine("String Data Type");
            Console.WriteLine();

            String s = "100";
            Console.WriteLine(s);
            Console.WriteLine("s");
            s = "ABC";
            Console.WriteLine(s);
            string s1 = null;
            Console.WriteLine(s1);
            String s2 = default;
            Console.WriteLine(s2);
            string s3 = " ";
            Console.WriteLine(s3 == s2);
            string s4 = "Hello";
            Console.WriteLine(s4[0]);//Index Postion of 0
            Console.WriteLine(s4.Length);// Finding Length of Character
            Console.WriteLine(s4[s4.Length - 1]);
            Console.WriteLine(s4[s4.Length - 4]);
            string s5 = "World";
            Console.WriteLine(s4 + s5);
            Console.WriteLine(string.Concat(s4, s5));
            s5.Replace('o', 's');
            Console.WriteLine(s5);
            Console.WriteLine(s5.GetHashCode());// Using gethashcode finding memory
            Console.WriteLine(s5.Replace('o', 's').GetHashCode());

            //s = 1;
            //s = a;
            //s = 'a';
            //s = 100.0;
            //s = true;

            /**************************************************************************************************/

            //Asignment: String Data Type Methods

            Console.WriteLine("--------------");
            Console.WriteLine("Assignement - String Data Type");
            Console.WriteLine();
            string fName = "Sai";
            Console.WriteLine(fName.ToLower());//Converting to name to Lower Case
            Console.WriteLine(fName.ToUpper());//Converting to name to Upper Case
            string lName = "Prasanna";
            Console.WriteLine("{0} {1}", fName, lName);//String Formatting
            Console.WriteLine($"{fName} {lName}");//Interpolation
            Console.WriteLine(lName.IndexOf("a"));//first index it will print of a
            Console.WriteLine(lName.LastIndexOf("a"));//last index of a it will print
            String myName = "Sai Prasanna";
            Console.WriteLine(myName.Substring(4));// By using sub string we can display the output from the middle of the part what ever we need by giving the index value 
            string name = string.Copy(myName);//by using copy we can copy the name in the variable and we can assign that variable to another variable
            Console.WriteLine(name);
            string sname = (string)myName.Clone();//by using clone method we can read the variable from one varaiable and we can assign it to another varaible (same as copy)
            Console.WriteLine(sname);
            string doubleQuotes = "\"Prasanna\"";// using \(slash) it will help us to add double quotes for the value
            Console.WriteLine(doubleQuotes);
            string firstName = "MyName";
            string lastName = "MyName";
            Console.WriteLine(string.Compare(firstName, lastName));
            /* Comapre Method:
             * using compare method will compare two varaiables data, output will be in 0 or 1 format.
             * if both are equal it will print 0.
             * If the first value is high then it will print 1,if second value is high it will print -1.
             */
            Console.WriteLine(myName.Contains("Pra"));
            /* Contains Method:
               By using contains method we are checking the value is present in that varaible or not
               It is case senstive
               output format will be true or false
             */
            Console.WriteLine(myName.StartsWith("Sai"));// using starts with method knowing any varaiable value is starting with the same value or not 
            Console.WriteLine(myName.EndsWith("a"));// using Ends with method knowing any varaiable value is Ending with the same value or not 
            Console.WriteLine(myName.Insert(0, "Bandi "));
            /*Insert Method:
             * By using insert method we are adding any value to the existing variable value
             * insert method accepts two parameters one is index and other one is value.
             * Based on the index given by us it will add the value to the existing value.
             */
            string s15 = "  ";
            Console.WriteLine(string.IsNullOrEmpty(s15));//Using IsNullOrEmpty we will get to know the varaiable value is null or not.
            Console.WriteLine(firstName.Equals(lastName));//Using Equals method comparing the data between the values.
            Console.WriteLine(myName.Remove(0, 4));
            /*Remove method:
             * Remove method help to remove the value from any index position.
             * It accepts two parameters index and count
             * from index it will start removing and till before the count.
             */
            String sTrim = "  sai  ";
            Console.WriteLine(sTrim.Trim());//to remove spaces at starting and ending positions we will use trim 
            String sTrim2 = "sai";
            Console.WriteLine(sTrim2.Trim('s'));//And also it will remove starting and ending character

            /**************************************************************************************************/

            // *StringBuilder Data Type*
            Console.WriteLine("-------------------------");
            Console.WriteLine("StringBuilder Data Type");
            Console.WriteLine();

            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine(sb.Replace('H', 'h'));

            /*Asignment: String Builder accepts Concatination ?
            Answer: Possible
            by using arthematic operators it will not possible
            */

            StringBuilder sb1 = new StringBuilder("World");
            Console.WriteLine(string.Concat(sb, sb1));

            /**************************************************************************************************/

            // *Type Casting*
            Console.WriteLine("-------------------------");
            Console.WriteLine("Type Casting");
            Console.WriteLine();

            //Implicit Conversion
            Console.WriteLine("a.Implicit Type Casting");
            Console.WriteLine();
            int imp = 100;
            long l = imp;
            Console.WriteLine(imp);
            Console.WriteLine(l);

            //Explicit Conversion
            Console.WriteLine();
            Console.WriteLine("b.Explicit Type Casting");
            Console.WriteLine();

            //C++ Model
            Console.WriteLine("i.C++ Model");
            Console.WriteLine("************");
            long lCModel = 100;
            int expCModel = (int)lCModel;
            Console.WriteLine(expCModel);
            Console.WriteLine();

            //Parsing
            Console.WriteLine("ii.Parsing");
            Console.WriteLine("**********");
            string stringExpParsing = "100";
            int intExpParsing = int.Parse(stringExpParsing);
            Console.WriteLine(intExpParsing);
            string stringExpParsing1 = "100";
            int intExpParsing1 = int.Parse(stringExpParsing1);
            Console.WriteLine(intExpParsing1 + intExpParsing);

            //Console.Write("Enter the Value1: ");
            //int value = Console.Read();
            //Console.WriteLine(value);

            //Console.Write("Enter the Value2: ");
            //string value23 = Console.ReadLine();
            //Console.WriteLine(value23);

            //Adding Two Numbers
            //Console.WriteLine("Enter Number:");
            //string fnumber = Console.ReadLine();
            //Console.WriteLine("Enter Number:");
            //string lnumber = Console.ReadLine();
            //Console.WriteLine(fnumber + lnumber);
            //int fnum = int.Parse(fnumber);
            //int lnum = int.Parse(lnumber);
            //Console.WriteLine(fnum + lnum);

            //Convert
            Console.WriteLine();
            Console.WriteLine("iii.Convert");
            Console.WriteLine("***********");

            Console.WriteLine("a.ToInt32()");
            Console.WriteLine();
            double doubletoint = 100.45;
            Console.WriteLine(Convert.ToInt32(doubletoint));
            char chartoInt = 'A';
            Console.WriteLine(Convert.ToInt32(chartoInt));
            bool boolToInt = true;
            Console.WriteLine(Convert.ToInt32(boolToInt));
            String stringToInt = "100";
            Console.WriteLine(Convert.ToInt32(stringToInt));
            string stringToInt1 = "ABC";//Not Possible
            //Console.WriteLine(Convert.ToInt32(stringToInt1));
            stringToInt1 = null;
            Console.WriteLine(Convert.ToInt32(stringToInt1));
            // Console.WriteLine(int.Parse(stringToInt1));//Not possible

            Console.WriteLine("");
            Console.WriteLine("b.ToChar()");
            Console.WriteLine();
            int IntotoChar = 100;
            Console.WriteLine(Convert.ToChar(IntotoChar));
            String stringtoChar = "1";
            Console.WriteLine(Convert.ToChar(stringtoChar));
            //double doubletoChar = 100;//Not Possible
            //Console.WriteLine(Convert.ToChar(doubletoChar));
            //bool boolToChar = true;
            //Console.WriteLine(Convert.ToChar(boolToChar));
            string stringToChar2 = "A";
            Console.WriteLine(Convert.ToChar(stringToChar2));
            //stringToChar2 = null;
            //Console.WriteLine(Convert.ToChar(stringToChar2));
            stringToChar2 = "\0";
            Console.WriteLine(Convert.ToChar(stringToChar2));

            Console.WriteLine("");
            Console.WriteLine("c.ToDouble()");
            Console.WriteLine();
            int intToDouble = 100;
            Console.WriteLine(Convert.ToDouble(intToDouble));
            string stringToDouble = "100";
            Console.WriteLine(Convert.ToDouble(stringToDouble));
            //string stringtoDouble1 = "A";
            //Console.WriteLine(Convert.ToDouble(stringtoDouble1));
            // char charToDouble = '1';
            //Console.WriteLine(Convert.ToDouble(charToDouble));
            bool boolToDouble = true;
            Console.WriteLine(Convert.ToDouble(boolToDouble));
            string nullvalue = null;
            Console.WriteLine(Convert.ToDouble(nullvalue));

            Console.WriteLine("");
            Console.WriteLine("d.ToBoolean()");
            Console.WriteLine();
            int inttoBool = 110;
            Console.WriteLine(Convert.ToBoolean(inttoBool));
            //string stringtobool = "Abc";
            //Console.WriteLine(Convert.ToBoolean(stringtobool));
            string stringtobool1 = "false";
            Console.WriteLine(Convert.ToBoolean(stringtobool1));
            //char charToBool = 'A';
            //Console.WriteLine(Convert.ToBoolean(charToBool));
            double doubleToBool = 100;
            Console.WriteLine(Convert.ToBoolean(doubleToBool));
            float floatToBool = 100;
            Console.WriteLine(Convert.ToBoolean(floatToBool));

            Console.WriteLine("");
            Console.WriteLine("d.ToByte()");
            Console.WriteLine();
            int intToByte = 100;
            Console.WriteLine(Convert.ToByte(intToByte));
            double doubleToByte = 10.5;
            Console.WriteLine(Convert.ToByte(doubleToByte));
            float floatToByte = 12.5f;
            Console.WriteLine(Convert.ToByte(floatToByte));
            char chartoByte = 'A';
            Console.WriteLine(Convert.ToByte(chartoByte));
            chartoByte = '1';
            Console.WriteLine(Convert.ToByte(chartoByte));
            string stringToByte = "100";
            Console.WriteLine(Convert.ToByte(stringToByte));
            stringToByte = null;
            Console.WriteLine(Convert.ToByte(stringToByte));

            Console.WriteLine("");
            Console.WriteLine("e.ToString()");
            Console.WriteLine();
            int intToString = 100;
            Console.WriteLine(Convert.ToString(intToString));
            double doubleToString = 10.0;
            Console.WriteLine(Convert.ToString(doubleToString));
            float floatToString = 12.5f;
            Console.WriteLine(Convert.ToString(floatToString));
            char chartoString = 'A';
            Console.WriteLine(Convert.ToString(chartoString));
            chartoString = '1';
            Console.WriteLine(Convert.ToString(chartoString));

            //Boxing
            Console.WriteLine("");
            Console.WriteLine("iv.Boxing");
            Console.WriteLine("************");
            int boxing = 100;
            object objBoxing;
            objBoxing = boxing;
            Console.WriteLine(objBoxing);

            //Unboxing
            Console.WriteLine("");
            Console.WriteLine("iv.UnBoxing");
            Console.WriteLine("**************");
            object objUnBoxing = 100;
            int unboxing = Convert.ToInt32(objUnBoxing);
            Console.WriteLine(unboxing);

            //ValueType & Ref Type
            //Ref Type: we need to use ref key word

            Console.WriteLine("");
            Console.WriteLine("ValueType");
            Console.WriteLine("");
            ValueType vT = new ValueType();
            int value2 = 100;
            vT.ValueMethod(ref value2);
            Console.WriteLine(value2);

            /**************************************************************************************************/

            //Operators
            //1.Arthametic Operators
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Operators");
            Console.WriteLine();
            Console.WriteLine("1.Arthametic Operators");
            Console.WriteLine("************************");
            int addA = 10;
            int addB = 10;
            Console.WriteLine(addA + addB);
            addA = 9;
            addB = 20;
            Console.WriteLine(addA % addB);
            Console.WriteLine(addA / addB);
            addA = 0;
            Console.WriteLine(addA / addB);
            int operatora = 5;
            int operatorb = 6;
            int operatorc = operatora + operatorb * operatora;
            Console.WriteLine(operatorc);
            operatorc = (operatora + operatorb) * operatora;
            Console.WriteLine(operatorc);
            operatora = 5;
            operatorb = 6;
            operatorc = operatora + operatorb / operatorb + operatora;
            Console.WriteLine(operatorc);
            operatorc = (operatora + operatorb) / (operatorb + operatora);
            Console.WriteLine(operatorc);

            //2.Assignment Operators
            Console.WriteLine("");
            Console.WriteLine("2.Assignment Operators");
            Console.WriteLine("************************");
            int assignmenta = 10;
            int assignmentb = 20;
            assignmenta += assignmentb;
            Console.WriteLine(assignmenta);
            assignmenta *= assignmentb;
            Console.WriteLine(assignmenta);
            assignmenta -= assignmentb;
            Console.WriteLine(assignmenta);

            //3.BitWise Operators
            Console.WriteLine("");
            Console.WriteLine("3.BitWise Operators");
            Console.WriteLine("************************");
            int BitWisea = 10;
            int BitWiseb = 15;
            Console.WriteLine(BitWisea & BitWiseb);
            Console.WriteLine(BitWisea | BitWiseb);
            Console.WriteLine(BitWisea ^ BitWiseb);
            BitWisea &= BitWiseb;
            Console.WriteLine(BitWisea);
            BitWisea |= BitWiseb;
            Console.WriteLine(BitWisea);
            BitWisea ^= BitWiseb;
            Console.WriteLine(BitWisea);

            //4.Shift Operators
            Console.WriteLine("");
            Console.WriteLine("Shift Operators");
            Console.WriteLine("************************");
            Console.WriteLine(100 << 2);//left shift
            Console.WriteLine(100 << 4);
            Console.WriteLine(100 >> 2);//Right Shift
            Console.WriteLine(100 >> 4);

            //5.Relational Operators
            Console.WriteLine("");
            Console.WriteLine("Relational Operators");
            Console.WriteLine("************************");
            int RelationalOpeartorA = 10;
            int RelationalOpeartorB = 20;
            Console.WriteLine(RelationalOpeartorA < RelationalOpeartorB);
            Console.WriteLine(RelationalOpeartorA <= RelationalOpeartorB);
            Console.WriteLine(RelationalOpeartorA = RelationalOpeartorB);

            //6.Logical Operators
            Console.WriteLine("");
            Console.WriteLine("Logical Operators");
            Console.WriteLine("************************");
            int LogicalOpeartorA = 10;
            int LogicalOpeartorB = 20;
            int LogicalOpeartorC = 30;
            Console.WriteLine(LogicalOpeartorA < LogicalOpeartorB && LogicalOpeartorB < LogicalOpeartorC);
            Console.WriteLine(LogicalOpeartorA < LogicalOpeartorB && LogicalOpeartorB > LogicalOpeartorC);
            Console.WriteLine(LogicalOpeartorA < LogicalOpeartorB || LogicalOpeartorB < LogicalOpeartorC);
            bool logicalOperatord = true;
            Console.WriteLine(!logicalOperatord);

            //7.Increment & Decrement Operators
            Console.WriteLine("");
            Console.WriteLine("Increment & Decrement Operators");
            Console.WriteLine("*********************************");
            int incDecA = 100;
            Console.WriteLine(incDecA);//100
            Console.WriteLine(incDecA++);//100
            Console.WriteLine(incDecA);//101
            Console.WriteLine(++incDecA);//102
            Console.WriteLine(incDecA--);//102
            Console.WriteLine(--incDecA);//100

            //8.String Operator(+)
            Console.WriteLine("");
            Console.WriteLine("String Operator(+)");
            Console.WriteLine("********************");
            string stringoperatorA = "abc";
            string stringoperatorB = "abc";
            Console.WriteLine(stringoperatorA + stringoperatorB);
            Console.WriteLine(string.Concat(stringoperatorA, stringoperatorB));

            //9.Ternary Operator/Conditional Operator(?:)
            Console.WriteLine("");
            Console.WriteLine("Ternary Operator/Conditional Operator: Short form of if-else)");
            Console.WriteLine("******************************************************************");
            int ternarya = 10;
            int ternaryb = 20;
            if (ternarya > ternaryb)
            {
                Console.WriteLine(ternarya + ternaryb);
            }
            else
            {
                Console.WriteLine(ternarya - ternaryb);
            }
            Console.WriteLine(ternarya > ternaryb ? ternarya + ternaryb : ternarya - ternaryb);

            /**************************************************************************************************/

            //Conditions
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Conditions");
            Console.WriteLine();
            Console.WriteLine("1.If Conditions");
            Console.WriteLine("");

            //Simple If
            Console.WriteLine("a.Simple If");
            Console.WriteLine();
            int condition1 = 0;
            if (condition1 % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }

            //if - else
            Console.WriteLine();
            Console.WriteLine("b.If else");
            Console.WriteLine();
            if (condition1 > 0)
            {
                Console.WriteLine("Postive");
            }
            else
            {
                Console.WriteLine("Negative");
            }

            //if - elseif
            Console.WriteLine();
            Console.WriteLine("c.If elseif");
            Console.WriteLine();
            if (condition1 > 0)
            {
                Console.WriteLine("Postive");
            }
            else if (condition1 < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }

           // Console.WriteLine();
           //Console.WriteLine("Enter Number 1: ");
           //int oneValue = 1;
           //Console.WriteLine("Enter Number 2: ");
           //int TwoValue = 2;
           //if (oneValue > TwoValue)
           //{
           //    Console.WriteLine("{0} is greater than :{1}", oneValue, TwoValue);
           //}
           //else if (oneValue < TwoValue)
           //{
           //    Console.WriteLine($"{oneValue} value is Lessthan : {TwoValue}");
           //}
           //else
           //{
           //    Console.WriteLine("out of boundary");
           //}

           //Power Bill Reading
            //Console.WriteLine();
            //Console.WriteLine("Power Bill Reading");
            //Console.WriteLine("Enter Last Month Reading: ");
            //int lastMonthReading = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Current Month Reading: ");
            //int currentMonthReading = Convert.ToInt32(Console.ReadLine());

            //if (lastMonthReading >= 1000)
            //{
            //    lastMonthReading = lastMonthReading * 10;
            //    Console.WriteLine("10rs per unit-Last Month Reading: " + lastMonthReading);
            //}
            //else if (lastMonthReading >= 500 && lastMonthReading <= 999)
            //{
            //    lastMonthReading = lastMonthReading * 9;
            //    Console.WriteLine("9rs per unit-Last Month Reading: " + lastMonthReading);
            //}
            //else if (lastMonthReading >= 200 && lastMonthReading <= 499)
            //{
            //    lastMonthReading = lastMonthReading * 5;
            //    Console.WriteLine("5rs per unit-Last Month Reading: " + lastMonthReading);
            //}
            //else if (lastMonthReading <= 199)
            //{
            //    lastMonthReading = lastMonthReading * 2;
            //    Console.WriteLine("2rs per unit-Last Month Reading: " + lastMonthReading);
            //}
            //if (currentMonthReading >= 1000)
            //{
            //    currentMonthReading = currentMonthReading * 10;
            //    Console.WriteLine("10rs per unit-Current Month Reading: " + currentMonthReading);
            //}
            //else if (currentMonthReading >= 500 && currentMonthReading <= 999)
            //{
            //    currentMonthReading = currentMonthReading * 9;
            //    Console.WriteLine("9rs per unit-Current Month Reading: " + currentMonthReading);
            //}
            //else if (currentMonthReading >= 200 && currentMonthReading <= 499)
            //{
            //    currentMonthReading = currentMonthReading * 5;
            //    Console.WriteLine("5rs per unit-Current Month Reading: " + currentMonthReading);
            //}
            //else if (currentMonthReading <= 199)
            //{                
            //currentMonthReading = currentMonthReading * 2;
            //    Console.WriteLine("2rs per unit-Current Month Reading: " + currentMonthReading);
            //}

            Console.WriteLine();
            Console.WriteLine("d.Nested If");
            Console.WriteLine();
            //Nested IF
            /* Console.WriteLine();
             Console.WriteLine("Enter age: ");
             int age = int.Parse(Console.ReadLine());*/
            int age = 20;
            if (age >= 18)
            {
                Console.WriteLine("Major");
                string gender = "Female";
                if (gender == "Male")
                {
                    Console.WriteLine("Allowing party");
                }
                else
                {
                    Console.WriteLine("Not allow party(Female)");
                }
            }
            else
            {
                Console.WriteLine("not allowing party beacuse of age(Minor)");
            }

            //Switch Case
            Console.WriteLine();
            Console.WriteLine("2.Switch Case");
            Console.WriteLine();
            //Console.WriteLine("Enetr 1/2 numbers: ");
            int switchValue = default;
            switch (switchValue)
            {
                case 1:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Switch 1");
                    break;
                case 2:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Switch 2");
                    break;

                default:
                    Console.WriteLine("default");
                    break;
            }

            //Console.WriteLine("Enter values for Arthametic Operations");
            //Console.WriteLine("Enter Number 1: ");
            int switchValue1 = 10;
            //Console.WriteLine("Enter Number 2: ");
            int switchValue2 = 20;
            //Console.WriteLine("Enter 1 for Addition");
            //Console.WriteLine("Enter 2 for Multiplication");
            //Console.WriteLine("Enter 3 for Subtraction");
            //Console.WriteLine("Enter 4 for Divison");
            switchValue = 2;
            switch (switchValue)
            {
                case 1:
                    Console.WriteLine("If the user value is 1 Adding two numbers: " + (switchValue1 + switchValue2));
                    break;
                case 2:
                    Console.WriteLine("If the user value is 2 multiplying two numbers: " + (switchValue1 * switchValue2));
                    break;
                case 3:
                    Console.WriteLine("If the user value is 3 Subtracting two numbers: " + (switchValue1 - switchValue2));
                    break;
                case 4:
                    Console.WriteLine("If the user value is 4 Dividing two numbers: " + (switchValue1 / switchValue2));
                    break;
                case 5:
                    goto case 1;
                case 6:
                case 7:
                    goto case 2;
                default:
                    Console.WriteLine("Default Value");
                    break;
            }

            /**************************************************************************************************/

            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Loops Concept");
            Console.WriteLine();
            //For Loop
            Console.WriteLine("1.For Loop");
            Console.WriteLine();

            for (int forloop = 1; forloop <= 10; forloop = forloop + 2)
            {
                Console.WriteLine(forloop);
            }
            Console.WriteLine();

            Console.WriteLine("Sum of 5=1+2+3+4+5:");
            int sum = 0;
            for (int sum2 = 1; sum2 <= 5; sum2++)
            {
                sum = sum + sum2;
            }
            Console.WriteLine(sum);
            Console.WriteLine();

            //Table
            Console.WriteLine("2 table:");
            sum = 2;
            for (int sum3 = 1; sum3 <= 10; sum3++)
            {
                Console.WriteLine("{0}*{1}={2}", sum, sum3, sum * sum3);
            }

            //using for loop display A to Z characters
            Console.WriteLine();
            Console.WriteLine("A to Z Characters");
            for (char alphabet = 'A'; alphabet <= 'Z'; alphabet++)
            {
                Console.Write(alphabet);
            }
            Console.WriteLine();

            //using for loop display 1 10 100 even numbers
            Console.WriteLine();
            Console.WriteLine("Print 1 to 100 Even Numbers");
            int even = 0;
            for (int even1 = 1; even1 <= 100; even1 = even1 + 2)
            {
                even = even1 + 1;
                Console.Write(even);
            }

            //Using for loops display 1,2,3,4,5 for 5 times
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Pattrens");
            Console.WriteLine();

            for (int pattern1 = 1; pattern1 <= 5; pattern1++)
            {
                for (int pattren = 1; pattren <= 5; pattren++)
                {
                    Console.Write(pattren);
                }
                Console.WriteLine();
            }


            //Using for loops display 1,2,3,4,5 for 5 times
            Console.WriteLine();
            Console.WriteLine();
            for (int pattern1 = 1; pattern1 <= 5; pattern1++)
            {
                for (int pattren = 1; pattren <= pattern1; pattren++)
                {
                    Console.Write(pattern1);
                }
                Console.WriteLine();
            }

            //While Loop
            Console.WriteLine();
            Console.WriteLine("2.While Loop");
            Console.WriteLine();
            Console.WriteLine("Displaying 1 to 10 numbers by using While Loop");
            int whileloop = 1;
            while (whileloop <= 10)
            {
                Console.WriteLine(whileloop);
                whileloop++;
            }

            Console.WriteLine();
            Console.WriteLine("Pattrens");
            int whileloop1 = 1;
            while (whileloop1 <= 5)
            {
                int whileloop2 = 5;
                while (whileloop2 >= whileloop1)
                {
                    Console.Write("*");
                    whileloop2--;
                }
                Console.WriteLine();
                whileloop1++;
            }

            //Sum of digits while loop
            Console.WriteLine();
            Console.WriteLine("Sum");
            int whileLoop3 = 345;
            int sumwhile = 0;
            int remainder;
            while (whileLoop3 != 0)
            {
                remainder = whileLoop3 % 10;
                sumwhile = sumwhile + remainder;
                whileLoop3 = whileLoop3 / 10;
            }
            Console.WriteLine(sumwhile);


            //Factorial with While loop
            Console.WriteLine();
            Console.WriteLine("Factorial with While loop");
            Console.WriteLine();
            int factWhile = 145;
            int factIntial = 1;
            int factremind = 0;
            int factSum = 0;
            while (factWhile != 0)
            {
                int factmodule = factWhile % 10;
                factremind = factremind + factmodule;
                factWhile = factWhile / 10;
                while (factmodule >= 1)
                {
                    factIntial = factIntial * factmodule;
                    factmodule--;
                }
                Console.WriteLine($"Single digit factorial {factIntial}");
                factSum = factIntial + factSum;
                factIntial = 1;
            }
            Console.WriteLine($"Sum of Factorial output : {factSum}");
            Console.WriteLine($"Output of sum of 145: {factremind}");

            //Sum of Squares
            Console.WriteLine();
            Console.WriteLine("Sum Of Squares");
            Console.WriteLine();
            int square = 345;
            int StoreSquareValue = 0;
            while (square != 0)
            {
                int squareremind = square % 10;
                StoreSquareValue = StoreSquareValue + Convert.ToInt32(Math.Pow(squareremind, 2));
                square = square / 10;
            }
            Console.WriteLine(StoreSquareValue);

            //Do while
            Console.WriteLine();
            Console.WriteLine("3.Do while");
            Console.WriteLine();
            int dowhile = 1;
            do
            {
                Console.WriteLine(dowhile);
                dowhile++;
            }
            while (dowhile <= 10);
            Console.WriteLine(dowhile);

            //--------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine("Pattrens same number");
            Console.WriteLine();
            int samepattren = 25;
            for (int patt1 = 0; patt1 <= 2; patt1++)
            {
                for (int patt = 0; patt <= 4; patt++)
                {
                    Console.Write("{0}", samepattren + " ");
                }
                Console.WriteLine();
                for (int patt2 = 0; patt2 <= 4; patt2++)
                {
                    Console.Write(samepattren);
                }
                Console.WriteLine();
            }

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Pattrens: rectangle");
            Console.WriteLine();
            int rectanglePattren = 5;
            for (int rectpatt2 = 0; rectpatt2 <= 4; rectpatt2++)
            {
                if (rectpatt2 == 0 || rectpatt2 == 4)
                {
                    Console.Write("{0}{0}{0}", rectanglePattren);
                }
                else
                {
                    Console.Write("{0} {0}", rectanglePattren);
                }
                Console.WriteLine();
            }


            /**************************************************************************************************/

            //Array
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Arrays");
            Console.WriteLine("1.Single Dimensional Array");
            Console.WriteLine();

            //First Syntax
            Console.WriteLine("First Syntax in Array");
            Console.WriteLine();

            int[] array = new int[5];
            array[0] = 100;
            array[1] = 200;
            array[2] = 300;
            array[3] = 400;
            array[4] = 500;

            Console.WriteLine(array.Length);//Finding Length of array
            Console.WriteLine(array[0]);//reading value from 0th index
            for (int array1 = 0; array1 < array.Length; array1++)//reading all values from array
            {
                Console.WriteLine(array[array1]);
            }

            Array.Resize(ref array, 10);//increasing array size by using resize method
            Console.WriteLine(array.Length);
            for (int array1 = 0; array1 < array.Length; array1++)//reading all values from array
            {
                Console.WriteLine(array[array1]);
            }

            //--------------------------------------------------------------------------------------

            //Second Syntax
            Console.WriteLine();
            Console.WriteLine("Second Syntax in array");
            Console.WriteLine();

            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array2.Length);
            for (int array3 = 0; array3 < array2.Length; array3++)//reading all values from array
            {
                Console.WriteLine(array2[array3]);
            }
            //array2[8] = 9; //Not Possible
            //Console.WriteLine(array2[8]);

            Array.Resize(ref array2, 6);
            Console.WriteLine(array2.Length);
            for (int array3 = 0; array3 < array2.Length; array3++)//reading all values from array
            {
                Console.WriteLine(array2[array3]);
            }

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Empty Array");
            Console.WriteLine();
            int[] array5 = new int[] { };
            Console.WriteLine(array5.Length); //output:0
            //array5[0] = 1;
            //Console.WriteLine(array5[0]);//argument exception
            //Console.WriteLine(array5[0]);//index out of range expecption
            //Array.Resize(ref array5, -1);//Array will not accept negative number
            //Console.WriteLine(array5.Length);
            Array.Resize(ref array5, 1);
            Console.WriteLine(array5.Length);
            Console.WriteLine(array5[0]);//0
            //Console.WriteLine(array5[1]);

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Sum of the array elements");
            Console.WriteLine();
            int[] sumArray = new int[5] { 10, 20, 30, 40, 50 };
            int sumArray2 = 0;
            for (int sumarray3 = 0; sumarray3 < sumArray.Length; sumarray3++)
            {
                sumArray2 = sumArray2 + sumArray[sumarray3];
            }
            Console.WriteLine(sumArray2);

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Sum of index Even & odd numbers");
            Console.WriteLine();
            int[] arrayList = new int[5] { 10, 20, 30, 40, 50 };
            int evenarray = 0;
            int oddarray = 0;
            for (int sumarray3 = 0; sumarray3 < arrayList.Length; sumarray3++)
            {
                if (sumarray3 % 2 == 0)
                {
                    evenarray = evenarray + arrayList[sumarray3];
                }
                else
                {
                    oddarray = oddarray + arrayList[sumarray3];
                }
            }
            Console.WriteLine(evenarray);
            Console.WriteLine(oddarray);

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Sum of Even & odd numbers");
            Console.WriteLine();
            int[] arrayList2 = new int[5] { 1, 2, 3, 4, 5 };
            int evenarray1 = 0;
            int oddarray1 = 0;
            for (int sumarray4 = 0; sumarray4 < arrayList.Length; sumarray4++)
            {
                if (arrayList2[sumarray4] % 2 == 0)
                {
                    evenarray1 = evenarray1 + arrayList2[sumarray4];
                }
                else
                {
                    oddarray1 = oddarray1 + arrayList2[sumarray4];
                }
            }
            Console.WriteLine(evenarray1);
            Console.WriteLine(oddarray1);

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Array Sorting");
            Console.WriteLine();

            int[] SortOrder = new int[] { 20, 10, 50, 30, 40 };
            for (int sort = 0; sort < SortOrder.Length; sort++)
            {
                Console.WriteLine(SortOrder[sort]);
            }
            Console.WriteLine();
            Array.Sort(SortOrder);
            for (int sort = 0; sort < SortOrder.Length; sort++)
            {
                Console.WriteLine(SortOrder[sort]);
            }

            Console.WriteLine();
            Console.WriteLine("Reverse Order");
            Console.WriteLine();

            Array.Reverse(SortOrder);
            for (int sort = 0; sort < SortOrder.Length; sort++)
            {
                Console.WriteLine(SortOrder[sort]);
            }

            Console.WriteLine(SortOrder.Sum()); //By using Sum() method we are directly doing sum operation for entire array

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Method With Array Parameter");
            Console.WriteLine();
            Program prgm = new Program();
            prgm.arrayMethod(10);
            prgm.arrayMethod(new int[3] { 10, 20, 30 });// without params we need to declare new int[] {}
            prgm.arrayMethod(10, 20, 30, 40); //by using params parameter it will possible

            //--------------------------------------------------------------------------------------

            Console.WriteLine();
            Console.WriteLine("Min Value of Array");
            Console.WriteLine();
            int[] arrayMinValue = new int[5] { 10, 20, 20, 50, 40 };
            int minarray = arrayMinValue[0];
            int maxArray = 0;
            for (int arrayMinValue1 = 0; arrayMinValue1 < arrayMinValue.Length; arrayMinValue1++)
            {
                if (minarray >= arrayMinValue[arrayMinValue1])
                {
                    minarray = arrayMinValue[arrayMinValue1];//0 0 0 0
                }
                else if (maxArray <= arrayMinValue[arrayMinValue1])
                {
                    maxArray = arrayMinValue[arrayMinValue1];//10,20,20,50
                }
            }
            Console.WriteLine(minarray);
            Console.WriteLine(maxArray);

            //--------------------------------------------------------------------------------------
            //String Array

            Console.WriteLine();
            Console.WriteLine("String Array");
            Console.WriteLine();
            string[] stringArray = new string[] { "Prasanna", "Sai" };
            for (int stringArray2 = 0; stringArray2 < stringArray.Length; stringArray2++)
            {
                Console.WriteLine(stringArray[stringArray2]);
            }
            Array.Reverse(stringArray);
            for (int stringArray2 = 0; stringArray2 < stringArray.Length; stringArray2++)
            {
                Console.WriteLine(stringArray[stringArray2]);
            }
            Array.Sort(stringArray);
            for (int stringArray2 = 0; stringArray2 < stringArray.Length; stringArray2++)
            {
                Console.WriteLine(stringArray[stringArray2]);
            }
            Array.Reverse(stringArray);
            for (int stringArray2 = 0; stringArray2 < stringArray.Length; stringArray2++)
            {
                Console.WriteLine(stringArray[stringArray2]);
            }
            //--------------------------------------------------------------------------------------

            //Char Array

            Console.WriteLine();
            Console.WriteLine("Char Array");
            Console.WriteLine();
            char[] charArray = new char[] { '0', 'a', '2', 'b' };
            for (int charArray2 = 0; charArray2 < charArray.Length; charArray2++)
            {
                Console.WriteLine(charArray[charArray2]);
            }
            Console.WriteLine("Reverse Order");
            Array.Reverse(charArray);
            for (int charArray2 = 0; charArray2 < charArray.Length; charArray2++)
            {
                Console.WriteLine(charArray[charArray2]);
            }
            Console.WriteLine("Sort Order");
            Array.Sort(charArray);
            for (int charArray2 = 0; charArray2 < charArray.Length; charArray2++)
            {
                Console.WriteLine(charArray[charArray2]);
            }
            Console.WriteLine("Descending Order");
            Array.Reverse(charArray);
            for (int charArray2 = 0; charArray2 < charArray.Length; charArray2++)
            {
                Console.WriteLine(charArray[charArray2]);
            }
            //--------------------------------------------------------------------------------------
            //Multi Dimensional Array

            Console.WriteLine();
            Console.WriteLine("2.Multi Dimensional Array");
            Console.WriteLine();
            // 2D Array
            int[,] MultiArray = new int[4, 2] { { 10, 20 }, { 30, 40 }, { 50, 60 }, { 70, 80 } };
            Console.WriteLine(MultiArray.Length); // Complete Length 4*2=8 
            Console.WriteLine(MultiArray.GetLength(0)); //No of Rows
            Console.WriteLine(MultiArray.GetLength(1)); //No of Columns 
            for (int MultiArray2 = 0; MultiArray2 < MultiArray.GetLength(0); MultiArray2++)//For rows
            {
                for (int MultiArray3 = 0; MultiArray3 < MultiArray.GetLength(1); MultiArray3++)//For Columns
                {
                    Console.Write(MultiArray[MultiArray2, MultiArray3] + " ");
                    // Console.WriteLine("MultiArray[{0},{1}]={2}",MultiArray2,MultiArray3,MultiArray[MultiArray2, MultiArray3]);
                }
                Console.WriteLine();
            }
            //--------------------------------------------------------------------------------------
            //Sum of 2D dimensional Array
            Console.WriteLine();
            Console.WriteLine("Sum of 2 Dimensional Array");
            Console.WriteLine();
            int[,] SumArray = new int[4, 2] { { 10, 20 }, { 30, 40 }, { 50, 60 }, { 70, 80 } };
            int sumArray3 = 0;
            for (int SumArray1 = 0; SumArray1 < SumArray.GetLength(0); SumArray1++)//For rows
            {
                for (int SumArray2 = 0; SumArray2 < SumArray.GetLength(1); SumArray2++)//For Columns
                {
                    sumArray3 = sumArray3 + SumArray[SumArray1, SumArray2];
                }
            }
            Console.WriteLine(sumArray3);
            //--------------------------------------------------------------------------------------
            //2d support params parameter or not ?
            // params parameter supports only Single dimensional array
            //--------------------------------------------------------------------------------------
            //3d Array

            Console.WriteLine();
            Console.WriteLine("3 Dimensional Array");
            Console.WriteLine();
            int[,,] array3d = new int[2, 2, 3] //2 rows, 2 rows,3 values
            {
                { { 1,2,3}, {2,2,4 } },
                { { 7,8,9},{10,11,12 } }
            };
            Console.WriteLine(array3d[0, 0, 0]);
            Console.WriteLine(array3d.GetLength(0)); //No of Rows
            Console.WriteLine(array3d.GetLength(1)); //No of rows
            Console.WriteLine(array3d.GetLength(2)); //No of columns
            Console.WriteLine();
            for (int array3d1 = 0; array3d1 < array3d.GetLength(0); array3d1++)//For rows
            {
                for (int array3d2 = 0; array3d2 < array3d.GetLength(1); array3d2++)//For Rows
                {
                    for (int array3d3 = 0; array3d3 < array3d.GetLength(2); array3d3++)//For Columns
                    {
                        Console.Write(array3d[array3d1, array3d2, array3d3] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            //--------------------------------------------------------------------------------------
            //Sum of 3D dimensional Array
            Console.WriteLine("Sum of 3 Dimensional Array");
            int sum3d = 0;
            for (int array3d1 = 0; array3d1 < array3d.GetLength(0); array3d1++)//For rows
            {
                for (int array3d2 = 0; array3d2 < array3d.GetLength(1); array3d2++)//For Rows
                {
                    for (int array3d3 = 0; array3d3 < array3d.GetLength(2); array3d3++)//For Columns
                    {
                        sum3d = sum3d + array3d[array3d1, array3d2, array3d3];
                    }
                }
            }
            Console.WriteLine(sum3d);
            //--------------------------------------------------------------------------------------
            //Jagged Array

            Console.WriteLine();
            Console.WriteLine("3.Jagged Array");
            Console.WriteLine();
            //Single Dimensional Jagged Array
            int[][] jaggedArray = new int[3][] // 1st open brace row, second for column
            {
               new int[3] {1,2,3 }, // 1st row 3 columns 
               new int[5]{1,2,3,4,5 }, // 2nd row 5 columns
               new int[1] {10}
            };
            Console.WriteLine(jaggedArray.Length); //No of rows
            Console.WriteLine(jaggedArray.GetLength(0)); //No of rows
            //Console.WriteLine(jaggedArray.GetLength(1)); //In jagged array by using get length method we are unable to find columns

            for (int jaggedarray2 = 0; jaggedarray2 < jaggedArray.Length; jaggedarray2++)
            {
                for (int jaggedarray3 = 0; jaggedarray3 < jaggedArray[jaggedarray2].Length; jaggedarray3++)
                {
                    Console.Write(jaggedArray[jaggedarray2][jaggedarray3] + " ");
                }
                Console.WriteLine();
            }
            //--------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Jagged Array:Multi dimensional-Storing 2d values in single dimension");
            Console.WriteLine();
            int[][,] jaggedArrayMulti = new int[3][,]
            {
                new int[2,3]{{1,2,3},{1,2,3} },
                new int[,]{{1,2}},
                new int[,]{{1,2} }
            };
            for (int jaggedarray5 = 0; jaggedarray5 < jaggedArrayMulti.Length; jaggedarray5++)//1st row
            {
                for (int jaggedarray6 = 0; jaggedarray6 < jaggedArrayMulti[jaggedarray5].GetLength(0); jaggedarray6++)//2nd row
                {
                    for (int jaggedarray7 = 0; jaggedarray7 < jaggedArrayMulti[jaggedarray5].GetLength(1); jaggedarray7++)// column
                    {
                        Console.Write(jaggedArrayMulti[jaggedarray5][jaggedarray6, jaggedarray7] + " ");
                    }
                }
                Console.WriteLine();
            }
            //--------------------------------------------------------------------------------------
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Jagged Array:Multi dimensional-Storing single dimension values in 2d");
            Console.WriteLine();
            int[,][] jaggedArrayMulti2 = new int[2, 2][];
            jaggedArrayMulti2[0, 0] = new int[1] { 0 };
            jaggedArrayMulti2[0, 1] = new int[2] { 0, 1 };
            jaggedArrayMulti2[1, 0] = new int[2] { 0, 1 };
            jaggedArrayMulti2[1, 1] = new int[2] { 0, 1 };
            for (int jaggedarray8 = 0; jaggedarray8 < jaggedArrayMulti2.GetLength(0); jaggedarray8++)
            {
                for (int jaggedarray9 = 0; jaggedarray9 < jaggedArrayMulti2.GetLength(1); jaggedarray9++)
                {
                    for (int jaggedarray10 = 0; jaggedarray10 < jaggedArrayMulti2[jaggedarray8, jaggedarray9].Length; jaggedarray10++)
                    {
                        Console.WriteLine(jaggedArrayMulti2[jaggedarray8, jaggedarray9][jaggedarray10]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        void arrayMethod(params int[] arraymethod1)
        {
            int arraySum = 0;
            for (int arraySumParam = 0; arraySumParam < arraymethod1.Length; arraySumParam++)
            {
                arraySum = arraySum + arraymethod1[arraySumParam];
            }
            Console.WriteLine(arraySum);
        }
    }
}

class ValueType
{
    public void ValueMethod(ref int value)
    {
        value = value + 5;
        Console.WriteLine(value);
    }
}


