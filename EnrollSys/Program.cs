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


            Console.WriteLine(student);
            Console.WriteLine(subject);
            Console.WriteLine(enrollment);

            Student student1 = new Student("Andrew Bob", "AB@gmail.com", "0400000000", "1", "IT", DateTime.Now, address);
            Console.WriteLine(student1==student);
            Console.ReadKey();

            
        }
    }
}
