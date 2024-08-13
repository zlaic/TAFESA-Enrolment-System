using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollSys
{
    public class Student : Person
    {
        public const string DEF_ID = "0";
        public const string DEF_PROGRAM = "none";
        public static readonly DateTime DEF_DATE_REGISTERED = DateTime.Now;

        public string StudentID { get; set; }
        public string Program { get; set; }
        public DateTime DateRegistered { get; set; }
        public Address Address { get; set; }

        public Student(): this(DEF_NAME,DEF_EMAIL,DEF_PN, DEF_ID, DEF_PROGRAM, DEF_DATE_REGISTERED, new Address()) { }
        public Student(string name, string email, string phoneNumber, string studentID, string program, DateTime dateRegistered, Address address)
            : base(name, email, phoneNumber)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
            Address = address;
        }

        public override string ToString()
        {
            return base.ToString() + $", StudentID: {StudentID}, Program: {Program}, Date Registered: {DateRegistered.ToShortDateString()}, Address: {Address}";
        }

        //equals based on the unique studentID
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
        public static bool operator ==(Student lhs, Student rhs) {return object.Equals(lhs,rhs);}
        public static bool operator !=(Student lhs, Student rhs) { return object.Equals(lhs, rhs);}
        //override using equals method above
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

        public override int GetHashCode()
        {
            return this.StudentID.GetHashCode();
        }
    }

}
