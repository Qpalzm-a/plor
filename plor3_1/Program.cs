using Classes;
using System;

namespace plor3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Student student2 = new Student();
            University university = new University();
            University university2 = new University();

            university.AddStudent(student);
            university2.AddStudent(student2);

            Console.WriteLine(university.GetStudents[0].Number);
            Console.WriteLine(university2.GetStudents[0].Number);
            Console.WriteLine(university.GetStudents[0].record_book);
            Console.WriteLine(university2.GetStudents[0].record_book + "\n");

            Console.WriteLine(university.GetStudents.Count);
            university.RemoveStudentByNumber(1);
            Console.WriteLine(university.GetStudents.Count);

            Console.WriteLine(university2.GetStudents.Count);
            university2.RemoveStudentByRecordBook(1);
            Console.WriteLine(university2.GetStudents.Count);
        }
    }
}


