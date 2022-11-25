using NUnit.Framework;
using unittestingeg;

namespace calculationtest
    
{
    [TestFixture]

    public class Tests
    {
        public static ICalculation calci;
        [SetUp]
        public void Setup()
        {
             calci = new calculationclient();
        }

        [Test]
        public void TestSImethod()
        {
            float expres = 240;
            float actualres = calci.Si(1000, 2, 12);
            Assert.AreEqual(expres, actualres);
            
        }
    }
}