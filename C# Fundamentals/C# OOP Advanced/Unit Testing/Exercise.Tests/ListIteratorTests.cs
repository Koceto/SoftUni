using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Exercise.Tests
{
    [TestFixture]
    public class ListIteratorTests
    {
        private ListIterator listIterator;

        [SetUp]
        public void SetUp()
        {
            this.listIterator = new ListIterator(new List<string>() { "a", "b" });
        }

        [Test]
        public void MoveReturnsFalseWhenIndexOutOfCollection()
        {
            // Arrange

            // Act
            this.listIterator.Move();

            // Assert
            Assert.IsFalse(this.listIterator.Move());
        }

        [Test]
        public void MoveReturnsTrueWhenIndexInsideCollection()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsTrue(this.listIterator.Move());
        }

        [Test]
        public void HasNextCorrectlyReturnsFalse()
        {
            // Arrange

            // Act
            this.listIterator.Move();

            // Assert
            Assert.IsFalse(this.listIterator.HasNext());
        }

        [Test]
        public void HasNextCorrectlyReturnsTrue()
        {
            // Arrange

            // Act

            // Assert
            Assert.IsTrue(this.listIterator.HasNext());
        }

        [Test]
        public void PrintCurrentElement()
        {
            // Arrange

            // Act
            string element = this.listIterator.Print();

            // Assert
            Assert.AreEqual("a", element);
        }

        [Test]
        public void TryPrintWhenEmpty()
        {
            // Arrange
            this.listIterator = new ListIterator(new List<string>());

            // Act

            // Assert
            Exception e = Assert.Throws<InvalidOperationException>(() => this.listIterator.Print());
            Assert.AreEqual("Invalid Operation!", e.Message);
        }
    }
}