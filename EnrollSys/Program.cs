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

            // Create an Address instance
            Address address = new Address(1, "Street St", "Adelaide", "5000", "SA");

            // Create a Student instance
            Student student = new Student("Andrew Bob", "AB@gmail.com", "0400000000", address, "1", "IT", DateTime.Now, new Enrollment());

            // Create a Subject instance
            Subject subject = new Subject("IT", "IT Basics", 1000);

            // Create Enrollment instances
            Enrollment enrollment = new Enrollment(DateTime.Now, "P", 1, subject);
            Enrollment enrollment1 = new Enrollment();

            // Assign enrollment to the student
            student.Enrollment = enrollment;

            // Output details
            Console.WriteLine(student);
            Console.WriteLine(subject);
            Console.WriteLine(enrollment);
            Console.WriteLine(enrollment1);

            // Create Student instances for comparison
            Student student1 = new Student("Andrew Bob", "AB@gmail.com", "0400000000", address, "1", "IT", DateTime.Now, enrollment);
            Student student2 = new Student();
            Student student3 = new Student();

            // Output comparison results
            Console.WriteLine(student1 == student);//T
            Console.WriteLine(Student.Equals(student1, student));//T
            Console.WriteLine(student2 == student3);//T
            Console.WriteLine(Student.Equals(student1, student3));//F
            Console.WriteLine(student3 == student1);//F
            Console.WriteLine(student2 != student);//T

            Console.WriteLine(student2);
            Console.WriteLine(student3);

            Console.ReadKey();

        }
    }
}
