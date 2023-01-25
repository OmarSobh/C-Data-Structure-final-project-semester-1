using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    internal class Course
    {
        int courseCode;
        string courseName;
        double courseGrade;
        public Course(int courseCode, string courseName, double courseGrade)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;   
            this.courseGrade = courseGrade;
        }
        public Course(Course other)
        {
            this.courseCode = other.courseCode;
            this.courseName = other.courseName;
            this.courseGrade= other.courseGrade;
        }
       
        public string getCourseName() { return courseName; }
        public double getCourseGrade(){return courseGrade; }
        public int getCourseCode() { return courseCode; }

        public void setCourseName(string courseName) { this.courseName = courseName; }
        public void setCourseCode (int courseCode) { this.courseCode = courseCode; }
        public void setCourseGrade(double courseGrade) { this.courseGrade = courseGrade;}



        public override string  ToString()
        {
            return $" Course Code : {this.courseCode}\n" +
                $"Course Name : {this.courseName}\n" +
                $"Course Grade : {this.courseGrade}\n";
        }
    }

}
