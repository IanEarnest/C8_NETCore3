using System;

namespace Tutorial
{
    class Program
    {
        /*
        Section 1 - Intro, tools
        Section 2 - Variables, expressions
        Section 3 - If and Loops
        Section 4 - Methods and Files
        Section 5 - OOP, Inheritance, Abstraction...
        Section 6 - .NET Standard, WPF and Winforms
        Section 7 - .NET Core app 
         */
        public static Section1 S1 = new Section1();
        public static Section2 S2 = new Section2();
        public static Section3 S3 = new Section3();
        public static Section4 S4 = new Section4();
        public static Section5 S5 = new Section5();
        public static Section6 S6 = new Section6();
        public static Section7 S7 = new Section7();



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            S1.PrintHello();

            S2.PrintHello();
            //S2.Section2_1();

            S3.PrintHello();
            //S3.Section3_1();
            S3.Section3_2();

            S4.PrintHello();
            S4.Section4_1();

            S5.PrintHello();
            S5.Section5_1();

            S6.PrintHello();
            S6.Section6_1();

            S7.PrintHello();
            S7.Section7_1();
        }
    }
}
