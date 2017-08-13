using NUnit.Framework;
using System;

namespace Exercise.Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database database;

        [SetUp]
        public void SetUp()
        {
            this.database = new Database();
        }

        [Test]
        public void RemoveFromEmptyCollection()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Remove());
        }

        [Test]
        public void AddExistingUsername()
        {
            // Arrange

            // Act
            this.database.Add(1, "a");

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(2, "a"));
        }

        [Test]
        public void AddExistingId()
        {
            // Arrange

            // Act
            this.database.Add(1, "a");

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.Add(1, "b"));
        }

        [Test]
        public void TryFindNonExistentUsername()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername("a"));
        }

        [Test]
        public void TryFindNullUsername()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.FindByUsername(null));
        }

        [Test]
        public void TryFindNonExistentId()
        {
            // Arrange

            // Act

            // Assert
            Assert.Throws<InvalidOperationException>(() => this.database.FindById(1));
        }

        [Test]
        public void TryFindNegativeId()
        {
            // Arrange

            // Act
            this.database.Add(-1, "a");

            // Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => this.database.FindById(-1));
        }
    }
}