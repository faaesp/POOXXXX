using System;

namespace P4ImplementInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson student = new Student { Name = "Eric Solomon", Age = 20 };
            student.DisplayInfo();
        }
    }
}