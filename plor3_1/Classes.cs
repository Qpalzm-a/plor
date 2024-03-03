using System;
using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    class Student : Person
    {
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

        //public student(string name, string surname, int age, double avg)
        //{
        //    this.name = name;
        //    this.surname = surname;
        //    this.age = age;
        //    this.avg = avg;
        //}

        public int record_book;
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
            record_book_number++;
            student.record_book = record_book_number;
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);
        }

        public void RemoveStudentByRecordBook(int record_book)
        {
            students.Remove(students.FirstOrDefault(student => student.record_book == record_book));
        }

        public void RemoveStudentByNumber(int number)
        {
            students.Remove(students.FirstOrDefault(student => student.Number == number)); ;
        }

        public string FindStudent(Student student)
        {
            if (students.Contains(student)) return "The student has been found";
            else return "The student hasn't been found";
        }

        private int record_book_number = 0;
    }


    class Person
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
        private string Patronymic { get; set; }

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

        private DateTime BirthDate { get; set; }

        private int number;

        public int Number
        {
            get { return number; }
        }


        static private int counter = 0;


        public Person()
        {
            Persons.AddPerson(this);
            counter++;
            number = counter;
        }
    }


    static class Persons 
    { 
        private static List<Person> persons = new List<Person>();

        public static void AddPerson(Person person)
        {
            persons.Add(person);
        }
    }

    

}