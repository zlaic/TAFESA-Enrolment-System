using NUnit.Framework;

namespace EnrollSys.Tests
{
    public class Tests
    {
        [TestFixture]
        public class UtilityTests
        {
            Student[] students;

            [SetUp]
            public void Setup()
            {
                students = new Student[]
                {
                    new Student("Eve", "eve@example.com", "5678901234", new Address(105, "Birch St", "City E", "56789", "FL"), "S005", "Data Science", DateTime.Now.AddDays(-50), new Enrollment()),
                    new Student("David", "david@example.com", "4567890123", new Address(104, "Maple St", "City D", "45678", "TX"), "S004", "Software Engineering", DateTime.Now.AddDays(-40), new Enrollment()),
                    new Student("Alice", "alice@example.com", "1234567890", new Address(101, "Main St", "City A", "12345", "CA"), "S001", "Computer Science", DateTime.Now.AddDays(-10), new Enrollment()),
                    new Student("Charlie", "charlie@example.com", "3456789012", new Address(103, "Pine St", "City C", "34567", "NY"), "S003", "Cybersecurity", DateTime.Now.AddDays(-30), new Enrollment()),
                    new Student("Hank", "hank@example.com", "8901234567", new Address(108, "Palm St", "City H", "89012", "OR"), "S008", "Business Analytics", DateTime.Now.AddDays(-80), new Enrollment()),
                    new Student("Jack", "jack@example.com", "0123456789", new Address(110, "Fir St", "City J", "01234", "CO"), "S010", "Networking", DateTime.Now.AddDays(-100), new Enrollment()),
                    new Student("Bob", "bob@example.com", "2345678901", new Address(102, "Oak St", "City B", "23456", "CA"), "S002", "Information Technology", DateTime.Now.AddDays(-20), new Enrollment()),
                    new Student("Grace", "grace@example.com", "7890123456", new Address(107, "Redwood St", "City G", "78901", "AZ"), "S007", "Artificial Intelligence", DateTime.Now.AddDays(-70), new Enrollment()),
                    new Student("Ivy", "ivy@example.com", "9012345678", new Address(109, "Spruce St", "City I", "90123", "WA"), "S009", "Cloud Computing", DateTime.Now.AddDays(-90), new Enrollment()),
                    new Student("Frank", "frank@example.com", "6789012345", new Address(106, "Cedar St", "City F", "67890", "NV"), "S006", "Machine Learning", DateTime.Now.AddDays(-60), new Enrollment())
                };
                


            }

            [Test]
            public void TestLinearSearch()
            {
                
                Student targetStudent = new Student("", "", "", new Address(), "S004", "", DateTime.Now, new Enrollment()); //"David"
                int expectedIndex = 1;
                int index = Utility.LinearSearchArray(students, targetStudent);
                Assert.That(index, Is.EqualTo(expectedIndex));
            }

            [Test]
            public void TestLinearSearchFail()
            {

                Student targetStudent = new Student("", "", "", new Address(), "S011", "", DateTime.Now, new Enrollment()); //"Not Exist"
                int expectedIndex = -1;
                int index = Utility.LinearSearchArray(students, targetStudent);
                Assert.That(index, Is.EqualTo(expectedIndex));
            }

            [Test]
            public void TestBinarySearch()
            {
                Array.Sort(students); 
                Student targetStudent = new Student("", "", "", new Address(), "S006", "", DateTime.Now, new Enrollment()); //"Frank"
                int expectedIndex = 5;
                int index = Utility.BinarySearchArray(students, targetStudent);
                Assert.That(index, Is.EqualTo(expectedIndex));
            }

            [Test]
            public void TestBinarySearchFail()
            {
                Array.Sort(students);
                Student targetStudent = new Student("", "", "", new Address(), "S011", "", DateTime.Now, new Enrollment()); //"Not Exist"
                int expectedIndex = -1;
                int index = Utility.BinarySearchArray(students, targetStudent);
                Assert.That(index, Is.EqualTo(expectedIndex));
            }

            [Test]
            public void TestSortAscending()
            {
                Utility.QuickSortAscending(students);
                Assert.That(IsSortedAscending(students));
            }

            //Method to check if array is sorted in ascending order
            private bool IsSortedAscending(Student[] array)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (string.Compare(array[i - 1].StudentID, array[i].StudentID, StringComparison.Ordinal) > 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            [Test]
            public void TestSortDescending()
            {
                Utility.QuickSortDescending(students); // Assuming you have a QuickSortDescending method
                Assert.That(IsSortedDescending(students));
            }

            //Method to check if array is sorted in descending order
            private bool IsSortedDescending(Student[] array)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (string.Compare(array[i - 1].StudentID, array[i].StudentID, StringComparison.Ordinal) < 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }

}
