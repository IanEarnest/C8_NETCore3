using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Section2
    {
        /*
         Section 2 - Variables, expressions
            Stack = pre-defined size         (Value type and address of Reference)
            Heap = dynamic but inefficient  (Reference type)

            Lambda
            public string GetString(){ return "myString"; }
            public int Count { get { return 5; } }
            into
            public string GetString() => "myString";
            public int Count => return 5;
         */
        public void PrintHello()
        {
            Console.WriteLine("S2 Hello World!");
        }

        public void Section2_1()
        {
            int count = 5;
            string name = "Steve";
            //char c = 'S';
            Console.WriteLine($"Name: {name}, {name.ToUpper()}, {name.ToLower()}, {name.Replace("Steve", "Alan")}");

            bool isTrue;
            isTrue = count == 11;
            Console.WriteLine($"1. {isTrue}");
            isTrue = count > 3;
            Console.WriteLine($"2. {isTrue}");

            Console.WriteLine($"Lambda. {GetString()}, {GetString2()}");
            Console.WriteLine($"Lambda2. {count}, {Count2}");
        }
        public string GetString() { return "myString"; }
        public int Count { get { return 5; } }
        // Lambda
        public string GetString2() => "myString";
        public int Count2 => 5;
    }
}
