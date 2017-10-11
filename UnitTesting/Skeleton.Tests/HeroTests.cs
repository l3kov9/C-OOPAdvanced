using NUnit.Framework;

namespace Skeleton.Tests
{
    [TestFixture]
    public class HeroTests
    {
        [Test]
        public void HeroGetsExperienceAfterKillingTarget()
        {
            Hero hero = new Hero("Pesho");
            Dummy dummy = new Dummy(10, 10);

            hero.Attack(dummy);

            Assert.AreEqual(10, hero.Experience,"Hero doesnt gt experience");
        }
    }
}
