using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myNum = 12;
            var myString = "sam";
            var status = true;
            var grade = 'A';
            Console.WriteLine("value stored in myNum is: " + myNum + "\n datatype: "+myNum.GetType());
            Console.WriteLine("value stored in myString is: " + myString + "\n datatype: " + myString.GetType());
            Console.WriteLine("value stored in status is: " + status + "\n datatype: " + status.GetType());
            Console.WriteLine("value stored in grade is: " + grade + "\n datatype: " + grade.GetType());
            Console.ReadKey();
        }
    }
}
