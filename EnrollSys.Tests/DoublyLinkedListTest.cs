using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EnrollSys;

namespace EnrollSys.Tests
{
    internal class DoublyLinkedListTest
    {
        [TestFixture]
        public class DoublyLinkedListTests
        {
            [Test]
            public void AddsStudentAtHead()
            {
                var list = new DoublyLinkedList<Student>();
                var student = new Student { StudentID = "S001", Name = "Jane Doe" };

                list.AddFirst(student);
                Assert.That(list.Head.Value, Is.EqualTo(student));
            }

            [Test]
            public void AddsStudentAtTail()
            {
                var list = new DoublyLinkedList<Student>();
                var student1 = new Student { StudentID = "01", Name = "Jane Doe" };
                var student2 = new Student { StudentID = "02", Name = "Burnice White" };

                
                list.AddFirst(student1);
                list.AddLast(student2);
                Assert.That(list.Tail.Value, Is.EqualTo(student2));
            }

            [Test]
            public void ReturnsTrueIfStudentExists()
            {
                var list = new DoublyLinkedList<Student>();
                var student = new Student { StudentID = "01", Name = "Jane Doe" };

                
                list.AddFirst(student);
                var contains = list.Contains(student);
                Assert.That(contains, Is.True);
            }

            [Test]
            public void RemovesStudentFromHead()
            {
                var list = new DoublyLinkedList<Student>();
                var student1 = new Student { StudentID = "01", Name = "Jane Doe" };
                var student2 = new Student { StudentID = "02", Name = "Burnice White" };

                list.AddFirst(student1);
                list.AddLast(student2);

                list.RemoveFirst();
                Assert.That(list.Head.Value, Is.EqualTo(student2));
            }

            [Test]
            public void RemovesStudentFromTail()
            {
                var list = new DoublyLinkedList<Student>();
                var student1 = new Student { StudentID = "01", Name = "Jane Doe" };
                var student2 = new Student { StudentID = "02", Name = "Burnice White" };

                list.AddFirst(student1);
                list.AddLast(student2);

                list.RemoveLast();
                Assert.That(list.Tail.Value, Is.EqualTo(student1));
                
            }
        }
    }
}
