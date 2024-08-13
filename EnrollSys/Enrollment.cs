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
        public static readonly DateTime DEF_DATE_ENROLLED = DateTime.Now;
        public const string DEF_GRADE = "N";
        public const int DEF_SEMESTER = 0;

        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public int Semester { get; set; }
        public Student Student { get; set; }
        public Subject Subject { get; set; }

        public Enrollment(): this(DEF_DATE_ENROLLED,DEF_GRADE,DEF_SEMESTER, new Student(), new Subject()) { }
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
