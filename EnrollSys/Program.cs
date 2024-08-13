using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollSys
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Address address = new Address(1, "Street St", "Adelaide", "5000", "SA");
            Student student = new Student("Andrew Bob", "AB@gmail.com", "0400000000", "1", "IT", DateTime.Now, address);
            Subject subject = new Subject("IT", "IT Basics", 1000);
            Enrollment enrollment = new Enrollment(DateTime.Now, "P", 1, student, subject);
            Enrollment enrollment1 = new Enrollment();


            Console.WriteLine(student);
            Console.WriteLine(subject);
            Console.WriteLine(enrollment);
            Console.WriteLine(enrollment1);

            Student student1 = new Student("Andrew Bob", "AB@gmail.com", "0400000000", "1", "IT", DateTime.Now, address);
            Student student2 = new Student();
            Student student3 = new Student();

            Console.WriteLine(student1==student);
            Console.WriteLine(Student.Equals(student1,student));
            Console.WriteLine(student2==student3);
            Console.WriteLine(student2);
            Console.WriteLine(student3);
            Console.ReadKey();

            
        }
    }
}
