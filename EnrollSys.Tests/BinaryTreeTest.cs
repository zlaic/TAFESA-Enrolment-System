using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EnrollSys;


namespace EnrollSys.Tests
{
    internal class BinaryTreeTest
    {
        public class BinaryTreeTests
        {
            private BinaryTree tree;

            [SetUp]
            public void Setup()
            {
                tree = new BinaryTree();
                
                int[] studentIDs = { 4, 2, 6, 1, 3, 5, 7 };

                
                foreach (var id in studentIDs)
                {
                    tree.Add(id);
                }

            }

            [Test]
            public void FindStudentIDInTree()
            {
                
                Assert.That(tree.Find(1), Is.Not.Null);
                Assert.That(tree.Find(5), Is.Not.Null);
                Assert.That(tree.Find(10), Is.Null);
                
            }

            [Test]
            public void TraversePreOrder()
            {
                using var sw = new StringWriter();
                Console.SetOut(sw);


                tree.TraversePreOrder(tree.Root);
                var result = sw.ToString().Trim();
                Assert.That(result, Is.EqualTo("4 2 1 3 6 5 7"));
            }

            [Test]
            public void TraverseInOrder()
            {
                using var sw = new StringWriter();
                Console.SetOut(sw);

           
                tree.TraverseInOrder(tree.Root);
                var result = sw.ToString().Trim();
                Assert.That(result, Is.EqualTo("1 2 3 4 5 6 7"));
            }

            [Test]
            public void TraversePostOrder()
            {
                using var sw = new StringWriter();
                Console.SetOut(sw);

                tree.TraversePostOrder(tree.Root);

                var result = sw.ToString().Trim();
                Assert.That(result, Is.EqualTo("1 3 2 5 7 6 4"));
            }
        }
    }
}

