using BashSoft.Contracts;
using BashSoft.Models.DataStructures;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BashSoft.Tests
{
    [TestFixture]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [SetUp]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>();
        }

        [Test]
        public void TestEmptyConstructor()
        {
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestConstructorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);

            Assert.AreEqual(20, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestConstructorWithInitialComparer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);

            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestConstructorWithAllParams()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);

            Assert.AreEqual(30, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestAddIncreasesSize()
        {
            this.names.Add("MyName");

            Assert.AreEqual(1, this.names.Size);
        }

        [Test]
        public void TestAddNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.Add(null));
        }

        [Test]
        public void TestJoinWorksFine()
        {
            this.names.Add("1");
            this.names.Add("2");

            Assert.AreEqual("1=2", this.names.JoinWith("="));
        }

        [Test]
        public void TestJoinWithEmptyString()
        {
            this.names.Add("1");
            this.names.Add("2");

            Assert.AreEqual("12", this.names.JoinWith(String.Empty));
        }

        [Test]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            this.names.Add("R");
            this.names.Add("Z");
            this.names.Add("A");

            Assert.AreEqual("ARZ", this.names.JoinWith(String.Empty));
        }

        [Test]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add(i.ToString());
            }

            Assert.AreEqual(32, this.names.Capacity);
            Assert.AreEqual(17, this.names.Size);
        }

        [Test]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            this.names.AddAll(new List<string>()
            {
                "1",
                "2"
            });

            Assert.AreEqual(2, this.names.Size);
        }

        [Test]
        public void TestAddAllFromNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.AddAll(null));
        }

        [Test]
        public void TestAddAllKeepsSorted()
        {
            this.names.AddAll(new List<string>()
            {
                "Z",
                "R",
                "A",
                "Y"
            });

            Assert.AreEqual("ARYZ", this.names.JoinWith(String.Empty));
        }

        [Test]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.names.Add("a");

            this.names.Remove("a");

            Assert.AreEqual(0, this.names.Size);
        }

        [Test]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.Add("a");
            this.names.Add("b");

            this.names.Remove("a");

            Assert.AreEqual("b", this.names.JoinWith(String.Empty));
        }

        [Test]
        public void TestRemovingNullThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => this.names.Remove(null));
        }

        [Test]
        public void TestJoinWithNull()
        {
            this.names.AddAll(new List<string>()
            {
                "a",
                "b",
                "c"
            });

            Assert.Throws<ArgumentNullException>(() => this.names.JoinWith(null));
        }
    }
}