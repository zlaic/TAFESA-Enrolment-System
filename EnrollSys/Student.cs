using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EnrollSys
{
    public class Student : Person, IComparable<Student>
    {
        public const string DEF_ID = "0";
        public const string DEF_PROGRAM = "none";
        public static readonly DateTime DEF_DATE_REGISTERED = DateTime.Now;

        public string StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }

        public Enrollment Enrollment { get; set; }

        public Student(): this(DEF_NAME,DEF_EMAIL,DEF_PN, new Address(), DEF_ID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Enrollment()) { }
        public Student(string name, string email, string phoneNumber, Address address, string studentID, string program, DateTime dateRegistered, Enrollment enrollment)
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Enrollment = enrollment;
        }

        public override string ToString()
        {
            return base.ToString() + $", StudentID: {StudentID}, Program: {Program}, Date Registered: {DateRegistered.ToShortDateString()}, Address: {Address}";
        }

        /// <summary>
        /// Equals to check if the current instance of student is the same as given based on ID
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true if both objects have the same ID, else false</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Student student = (Student)obj;
            return student.StudentID == this.StudentID;
        }
        /// <summary>
        /// Overrides == operator
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>true if both objects have the same ID, else false</returns>
        public static bool operator ==(Student lhs, Student rhs) {return object.Equals(lhs,rhs);}
        /// <summary>
        /// Overrides != operator
        /// </summary>
        /// <param name="lhs"></param>
        /// <param name="rhs"></param>
        /// <returns>true if both objects have the same ID, else false</returns>
        public static bool operator !=(Student lhs, Student rhs) { return !object.Equals(lhs, rhs);}
        
        /// <summary>
        /// Equals to check object is equal to another object
        /// </summary>
        /// <param name="obj1"></param>
        /// <param name="obj2"></param>
        /// <returns>true if both objects have the same ID, else false </returns>
        public static bool Equals(object obj1, object obj2)
        {
            if (obj1 == obj2)
            {
                return true;
            }
            if (obj1 == null || obj2 == null)
            {
                return false;
            }
            else
            {
                return obj1.Equals(obj2);
            }
        }

        /// <summary>
        /// Serves as a hash function for the Student 
        /// </summary>
        /// <returns>Hashcode</returns>
        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode();
        }

        // Implementation of IComparable<Student>
        public int CompareTo(Student other)
        {
            if (other == null) return 1; // This means "this" is greater
            return this.StudentID.CompareTo(other.StudentID);
        }
    }

}
