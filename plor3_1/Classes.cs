using System.Collections.Generic;

namespace Classes
{
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value ?? "Student hasn't name"; }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set { surname = value ?? "Student hasn't surname"; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0) age = value;
                else age = 0;
            }
        }

        private double avg;
        public double Avg
        {
            get { return avg; }
            set
            {
                if (value < 2 || value > 5) avg = 0;
                else avg = value;
            }
        }

        public Student(string name, string surname, int age, double avg)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.avg = avg;
        }
    }


    class University
    {
        private List<Student> students = new List<Student> { };

        public List<Student> GetStudents
        {
            get { return students; }
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }


        public string FindStudent(Student student)
        {
            if (students.Contains(student)) return "The student has been found";
            else return "The student hasn't been found";
        }
    }
}