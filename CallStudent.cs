using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsProject1
{
    internal class CallStudent
    {
        static void Main(string[] args)
        {
            TestStudent obj= new TestStudent();
            Console.WriteLine("STUDENT DETAILS");
            Console.WriteLine("STUDENT  ID: " + obj[1]);
            Console.WriteLine("STUDENT  Name: " + obj[2]);
            Console.WriteLine("SEC " + obj[3]);
            Console.WriteLine("ROLLNUMBER: " + obj[4]);
            Console.WriteLine("ADDRESS: " + obj[5]);
            Console.WriteLine("NUMBER: " + obj[6]);
            Console.WriteLine();

        }
    }
}
