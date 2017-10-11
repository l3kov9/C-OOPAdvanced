using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        private const int dummyHealth = 10;
        private const int dummyExperience = 10;

        private Dummy dummy;

        [SetUp]
        public void SetInit()
        {
            this.dummy=new Dummy(dummyHealth, dummyExperience);
        }

        [Test]
        public void DummyLosesHealthAfterAttack()
        {
            //Act
            this.dummy.TakeAttack(5);

            //Assert
            Assert.AreEqual(5, this.dummy.Health);
        }

        [Test]
        public void DeadDummyThrowsExceptionAfterAttacked()
        {
            //Arrange
            this.dummy = new Dummy(0, 10);

            //Assert
            Assert.Throws<InvalidOperationException>(() => this.dummy.TakeAttack(10),
                "Dummy is dead.");
        }

        [Test]
        public void DeadDummyCanGiveExperience()
        {
            //Arrange
            this.dummy = new Dummy(0, 10);

            //Act
            var experience=this.dummy.GiveExperience();

            //Assert
            Assert.AreEqual(10, experience,"Dead Dummy doesnt give experience");
        }

        [Test]
        public void AliveDummyCantGiveExperience()
        {
            Assert.Throws<InvalidOperationException>(() => this.dummy.GiveExperience(),
                "Target is not dead.");
        }
    }
}