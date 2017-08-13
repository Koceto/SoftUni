using NUnit.Framework;
using System;
using Moq;

namespace Lab.Tests
{
    [TestFixture]
    public class AxeTest
    {
        [Test]
        public void AxeLoosesDurability()
        {
            // Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void AttackWithBrokenAxe()
        {
            // Arrange
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(100, 100);

            // Act
            axe.Attack(dummy);

            // Assert
            Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
        }
    }
}