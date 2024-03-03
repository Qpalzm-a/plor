using System.Collections.Generic;
using System.IO;
using Classes;


namespace DataAccess
{
    internal static class StudentsRepository
    {
        public static void WriteToFile(string path, List<Student> students)
        {
            string data = "";

            foreach (Student student in students)
            {
                data += student.Name + ":";
                data += student.Surname + ":";
                data += student.Age.ToString() + ":";
                data += student.Avg.ToString() + "\n";

                File.WriteAllText(path, data);
            }
        }


        public static string[] ReadFromFile(string path) 
        { 
            return File.ReadAllLines(path);
        }

    }
}
