using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial
{
    class Section5
    {
        /*
         Section 5 - OOP, Inheritance, Abstraction...
            Inheritance 
            Classes Employee, Lawyer, Accountant
             Employee 	   	        - Name, ID
             Lawyer: Employee 	    - CalcSalary()
             Accountant: Employee 	- GoToCourt()
            
             Accountant acc = new Accountant();
             Lawyer law = new Lawyer()
             acc.Name = "Alan";
             law.GoToCourt();
            
            
            Abstraction, Encapsualtion
             abstract Employee : IEmployee	- abstract Work();
             Lawyer 	            - override Work()
             Accountant 	        - override Work()
            
            
            Interface
             interface IWorker	- Name, Work(), StartWork()
             class worker		- Name, Work(), StartWork()
             
             IWorker worker = new Worker();
            
            
            Polymophism
             Overloading (same method different params)
             Overriding (inheritance, same method name, return base or be different)
             Virtual method can be overriden
         */

        public void PrintHello()
        {
            Console.WriteLine("S5 Hello World!");
        }

        public void Section5_1()
        {
        }
    }
}
