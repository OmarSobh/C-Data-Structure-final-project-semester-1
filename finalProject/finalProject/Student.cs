using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    internal class Student
    {
        string studentFirstName;
        string studentLastName;
        Node<Course> courses;

        public Student(string studentFirstName, string studentLastName, Node<Course> courses)
        {
            this.studentFirstName = studentFirstName;
            this.studentLastName = studentLastName;
            this.courses = courses;
        }

        public void SetStudentFirstName(string studentName)
        {
            this.studentFirstName = studentName;
        }
        public void SetStudentLastName(string studentLastName)
        {
            this.studentLastName = studentLastName;
        }
        public void  SetStudentCourses(Node<Course> courses)
        {
            this.courses = courses;
        }


        public string GetStudentFirstName()
        {
            return this.studentFirstName;
        }
        public string GetStudentLastName()
        {
            return this.studentLastName;
        }
        public Node<Course> GetStudentCourses()
        {
            return this.courses;
        }

    }
}
