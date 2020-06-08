using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Tutorial
{
    class Section4
    {
        /*
         Section 4 - methods, files
            
         */


        //public string fileLocation = @"C:\Users\ianea\source\repos\C8_NETCore3\Tutorial\test.txt";
        //public string fileLocation = $"./";       // = Tutorial\bin\Debug\netcoreapp3.1\test.txt
        //public string fileLocation = $"../";      // = Tutorial\bin\Debug\test.txt
        //public string fileLocation = $"../../";   // = Tutorial\bin\test.txt
        //public string fileLocation = $"../../../";// = Tutorial\test.txt
        public string fileName = "test.txt";
        public string fileLocation = $"../../../";
        

        public Section4()
        {
            fileLocation += $"{fileName}"; // "../../../test.txt";
        }

        public void PrintHello()
        {
            Console.WriteLine("S4 Hello World!");
        }

        public void Section4_1()
        {
            // Method
            string fullName = GetFullName("Alan", "Steven");
            Console.WriteLine($"Full name: {fullName}");

            // Recursion
            int count = 0;
            int total = Recursive(7, ref count); // calls itself 4 times (10-7 = 3 + last run)
            Console.WriteLine($"Total: {total} Count: {count}");

            // System.io
            // Read and writing
            Save("Hello World!");
            string savedString = Load();
            Console.WriteLine($"Saved String: {savedString}");
        }
        //Method, params, returns
        public static string GetFullName(string fName, string lName)
        {
            return $"{fName} {lName}";
        }

        // recursion, method calling itself
        public int Recursive(int value, ref int count)
        {
            count++;

            if (value >= 10) // value starts at 7 
            {
                return value;
            }

            value++;
            return Recursive(value, ref count);
        }

        public void Save(string line)
        {
            StreamWriter writer = new StreamWriter(fileLocation);
            writer.WriteLine(line);
            writer.Close();
            writer.Dispose();
        }
        public string Load()
        {
            StreamReader reader = new StreamReader(fileLocation);
            string line = reader.ReadLine();
            reader.Close();
            reader.Dispose();
            return line;
        }
    }
}
