using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeLosesDurabilityAfterAttack()
        {
            //Arrange
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            //Act
            axe.Attack(dummy);

            //Assert
            Assert.AreEqual(9, axe.DurabilityPoints,"Axe Durability doesnt change after attack.");

        }

        [Test]
        public void AttackWithBrokenAxe()
        {
            //Arrange
            Axe axe = new Axe(1, 1);
            Dummy dummy = new Dummy(20, 20);

            //Act
            axe.Attack(dummy);

            //Assert
            var ex=Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual("Axe is broken.", ex.Message);
        }
    }
}
