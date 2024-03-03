using Classes;
using DataAccess;
using System;

namespace plor3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            University university = new University();
            Student student1 = new Student("name1", "surname1", 16, 2.8);
            Student student2 = new Student("name2", "surname2", 17, 2.8);
            Student student3 = new Student("name3", "surname3", 18, 2.8);
            university.AddStudent(student1);
            university.AddStudent(student2);
            university.AddStudent(student3);

            StudentsRepository.WriteToFile(@"Files\Students.txt", university.GetStudents);

            string[] readed = StudentsRepository.ReadFromFile(@"Files\Students.txt");
            foreach (string student in readed) 
            { 
                Console.WriteLine(student); 
            }
        }
    }
}


