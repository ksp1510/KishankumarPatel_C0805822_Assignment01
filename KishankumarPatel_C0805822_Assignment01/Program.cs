using System;

namespace KishankumarPatel_C0805822_Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********Question 01********\n");
            ushort var1 = 52130;
            sbyte var2 = -115;
            int var3 = 4825932;
            byte var4 = 97;
            short var5 = -10000;
            Console.WriteLine("var1 is ushort type: {0,8}\nvar2 is sbyte type: {1,7}\nvar3 is int type: {2,13}" +
                                "\nvar4 is byte type: {3,7}\nvar5 is short type: {4,9}", var1, var2, var3, var4, var5);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 02********\n");
            float float1 = 12.345f, float2 = 3456.091f;
            double double1 = 34.567839023, double2 = 8923.1234857;
            Console.WriteLine("Values of float type:\nfloat1 =   {0} and float2 =  {1}", float1, float2);
            Console.WriteLine("Values of double type:\ndouble1 = {0} and double2 = {1}", double1, double2);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 03********\n");
            float a = 5.123456f, b = 50123457f;
            Console.WriteLine("Is a greater than b: {0}", a > b);
            Console.WriteLine("Is a less than b:    {0}", a < b);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 04********\n");
            int hex = 0xFF;
            Console.WriteLine("Decimal equivalent of hexagonal value '0xFF' is {0}", hex);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 05********\n");
            int hexa = 0x48;
            char c = (char)hexa;
            Console.WriteLine("The symbol that has unicode code '72' is {0}", c);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 06********\n");
            bool isFemale = false;
            Console.WriteLine("My gender is female: "+ isFemale);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 07********\n");
            String s1 = "Hello", s2 = "World", s3;
            object obj = s1 + " " + s2;
            s3 = (string)obj;
            Console.WriteLine("The string is "+ s3);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 08********\n");
            String str1 = "The use of quotations causes difficulties.",
                   str2 = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine("The string without quotations: " + str1);
            Console.WriteLine("The string with quotations:    " + str2);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 09********\n");
            char copy = '©';
            Console.WriteLine("{0,4}\n{0,3}{0,2}\n{0,2}{0,4}\n{0,1}{0,2}{0,2}{0,2}", copy);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 10********\n");
            String first_name, family_name;
            byte age;
            char gender;
            uint ID_number, unique_employee_number;
            Console.WriteLine("First Name:             {0}", first_name = "Kishankumar");
            Console.WriteLine("Last Name:              {0}", family_name = "Patel");
            Console.WriteLine("Gender:                 {0}", gender = 'M');
            Console.WriteLine("Age:                    {0}", age = 23);
            Console.WriteLine("ID Number:              {0}", ID_number = 245536);
            Console.WriteLine("Unique Employee Number: {0}", unique_employee_number = 14523365);
            Console.WriteLine("\n***************************\n\n");


            Console.WriteLine("\n\n********Question 11********\n");
            int x = 5, y = 10;
            Console.WriteLine("Before interchanging value of x is {0} and y is {1}", x, y);
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After interchanging value of x is {0} and y is {1}", x, y);
            Console.WriteLine("\n***************************");
            Console.ReadLine();
        }
    }
}
