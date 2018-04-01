using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeService
{
    class Program
    {
        static void Main(string[] args)
        {
            var myclient = new StudentServiceProxy();

            int studentId = 1;
            Console.WriteLine("Calling StudentService with StudentId = 1…..");
            Console.WriteLine("Student Name = {0}", myclient.GetStudentInfo(studentId));
            Console.ReadLine();
        }
    }
}
