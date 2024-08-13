using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EnrollSys
{
    public class Enrollment
    {
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }

        public Enrollment(DateTime dateEnrolled, string grade, int semester, Student student, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Student = student;
            Subject = subject;
        }

        public override string ToString()
        {
            return $"Date Enrolled: {DateEnrolled.ToShortDateString()}, Grade: {Grade}, Semester: {Semester}, Student: {Student.Name}, Subject: {Subject.SubjectName}";
        }
    }

}
