using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Skeleton.Test
{
    [TestClass]
    public class AxeTests
    {

        [TestMethod]
        public void AxeLosesDurabilyAfterAttack()
        {
            var axe = new Axe(10, 10);
            var dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [TestMethod]
        public void AttackWithBrokenWeapon()
        {
            var axe = new Axe(0, 0);
            var dummy = new Dummy(10, 10);

            Exception exception = Assert.ThrowsException<InvalidOperationException>(
            () => axe.Attack(dummy),
            "Attack with a broken axe is not allowed!");

            Assert.AreEqual("Axe is broken.", exception.Message);
        }
    }
}
