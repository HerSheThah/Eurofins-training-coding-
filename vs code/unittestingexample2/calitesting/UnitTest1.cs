using NUnit.Framework;
using unittestingexample2;
namespace calitesting
{
    public class Tests
    {
        public static ICalculation obj;
        [SetUp]
        public void Setup()
        {
            obj = new calcclient();
        }

        [Test]
        public void TestSImethod()
        {
            //float actualres = obj.avg(30, 40);
            //float expres = 35;
            int actualres = obj.sum(9, 10);
            int expres = 19;
            Assert.AreEqual(actualres, expres);
        }
    }
}